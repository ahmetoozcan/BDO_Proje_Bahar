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
        readonly double chargeTime;
        readonly double distance;
        public bool IsTurnedOn { get { return isTurnedOn; } }
        public string Brand { get { return data["brand"]; } }
        public string Model { get { return data["model"]; } }
        private bool isCharging;
        private Thread simulateThread;
        private Thread chargingThread;
        private object lockObject = new object();
        private Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
        private bool disposed = false;
        private ChargeStationSimulator chargeStation = null;

        public ElectricVehicleSimulator(string brand, string model, double chargeTime, double distance) {

            data["brand"] = brand;
            data["model"] = model;
            data["chargePercentage"] = 0;
            data["status"] = "OFF";
            data["connectorId"] = null;
            data["fullchargetime"] = null;
            data["batterytemp"] = null;
            data["distance"] = null;


            this.chargeTime = chargeTime;
            this.distance = distance;
            isTurnedOn = false;
            isCharging = false;
            mqttClient = new MqttClient("broker.hivemq.com");
            mqttClient.Connect(Guid.NewGuid().ToString());
            statusTopic = "test/test/test/test/test/test/test";


            mqttClient.Publish(statusTopic, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);

        }


        public void TurnOn() {
            if (!isTurnedOn) {
                isTurnedOn = true;
                data["batterytemp"] = 20;
                data["distance"] = distance * (double)(((double)data["chargePercentage"] / 100));
                StartSimulate();
            }
        }

        public void TurnOff() {
            if (isTurnedOn) {
                isTurnedOn = false;
                isCharging = false;
                data["status"] = "OFF";
                data["connectorId"] = null;
                data["fullchargetime"] = null;
                data["batterytemp"] = null;
                data["distance"] = null;
                data["chargePercentage"] = 0;
                chargeStation?.Disconnect(data);
                chargeStation = null;
                mqttClient.Publish(statusTopic, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
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
            Random random = new Random();
            bool firstCharge = true;
            while (isTurnedOn && isCharging) {
                lock (lockObject) {
                    if (!firstCharge)
                        data["chargePercentage"]++;
                    if (data["chargePercentage"] < 100)
                        data["fullchargetime"] = ((100 - data["chargePercentage"]) * chargeTime);
                }
                firstCharge = false;
                Thread.Sleep((int)(chargeTime * 1000));
            }
            data["fullchargetime"] = null;
        }

        private void Simulate() {
            Random random = new Random();
            while (isTurnedOn) {
                lock (lockObject) {
                    data["distance"] = distance * (double)(((double)data["chargePercentage"] / 100));
                    mqttClient.Publish(statusTopic, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);


                    if (isCharging)
                        if (data["batterytemp"] < 37) {
                            data["batterytemp"] += (random.NextDouble() * 2);
                        }
                        else if (data["batterytemp"] > 37) {
                            data["batterytemp"] -= (random.NextDouble() * 2);
                        }

                    if (data["batterytemp"] < 29) {
                        data["batterytemp"] += random.NextDouble();
                    }
                    else if (data["batterytemp"] > 29) {

                        data["batterytemp"] -= random.NextDouble();
                    }

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