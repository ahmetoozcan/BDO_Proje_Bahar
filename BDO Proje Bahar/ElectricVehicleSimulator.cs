using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace BDO_Proje_Bahar {
    internal class ElectricVehicleSimulator : IDisposable {
        private MqttClient mqttClient;
        private string statusTopic;
        private bool isTurnedOn;
        public bool IsTurnedOn { get { return isTurnedOn; } }
        private bool isCharging;
        private Thread simulateThread;
        private Thread chargingThread;
        private object lockObject = new object();
        private Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
        private bool disposed = false;
        private ChargeStationSimulator chargeStation = null;

        public ElectricVehicleSimulator(string brand, string model) {

            data["brand"] = brand;
            data["model"] = model;
            data["chargePercentage"] = 0;
            data["status"] = "OFF";
            data["connectorId"] = null;

            isTurnedOn = false;
            isCharging = false;
            mqttClient = new MqttClient("broker.hivemq.com");
            mqttClient.Connect(Guid.NewGuid().ToString());
            statusTopic = $"deneme/deneme";


            mqttClient.Publish(statusTopic, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        public void TurnOn() {
            if (!isTurnedOn) {
                isTurnedOn = true;
                StartSimulate();
            }
        }

        public void TurnOff() {
            if (isTurnedOn) {
                isTurnedOn = false;
                data["status"] = "OFF";
                mqttClient.Publish(statusTopic, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            }
        }

        public void Connect(ChargeStationSimulator chargeStation) {
            if (!isCharging) {
                this.chargeStation = chargeStation;
                if (chargeStation.Connect(this, data))
                    StartCharging();
            }
        }

        public void Disconnect() {
            chargeStation.Disconnect(data);
            chargeStation = null;
            data["status"] = "ON";
            StopCharging();
        }


        private void StartCharging() {
            if (isTurnedOn && !isCharging) {
                StartChargingProcess();
            }
        }

        private void StopCharging() {
            if (isCharging) {
                StopChargingProcess();
            }
        }

        private void StartSimulate() {
            data["status"] = "ON";
            simulateThread = new Thread(Simulate) {
                IsBackground = true,
            };
            simulateThread.Start();
        }


        private void StartChargingProcess() {
            isCharging = true;
            data["status"] = "Charging";
            chargingThread = new Thread(ChargingProcess) {
                IsBackground = true,
            };
            chargingThread.Start();
        }

        private void StopChargingProcess() {
            isCharging = false;
        }

        private void ChargingProcess() {
            while (isTurnedOn && isCharging) {
                lock (lockObject) {
                    if (data["chargePercentage"] < 100) {
                        data["chargePercentage"]++;
                    }
                }
                Thread.Sleep(3000);
            }
        }

        private void Simulate() {
            while (isTurnedOn) {
                lock (lockObject) {
                    mqttClient.Publish(statusTopic, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                }
                Thread.Sleep(3000);
            }
        }


        protected virtual void Dispose(bool disposing) {
            if (!disposed) {
                if (disposing) {
                    mqttClient?.Disconnect();
                    isTurnedOn = false;
                    isCharging = false;
                }

                disposed = true;
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ElectricVehicleSimulator() {
            Dispose(false);
        }
    }
}