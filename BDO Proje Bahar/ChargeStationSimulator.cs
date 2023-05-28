using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace BDO_Proje_Bahar {
    internal class ChargeStationSimulator : IDisposable {

        private MqttClient mqttClient;
        private bool isEmpty = true;
        private bool isOn = true;
        private ElectricVehicleSimulator electricVehicle;
        private readonly object lockObject = new object();
        private Thread informThread;
        private Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
        private bool disposed = false;

        public ChargeStationSimulator(string chargeStationID) {

            data["action"] = "BootNotification";
            data["payload"] = new Dictionary<string, dynamic>();
            data["payload"]["connectorId"] = chargeStationID;
            data["payload"]["status"] = "Available";
            data["payload"]["current"] = 0;
            data["payload"]["voltage"] = 400;
            data["payload"]["energy"] = 0;
            data["payload"]["errorCode"] = null;
            data["payload"]["timestamp"] = GetTimeStamp();
            data["payload"]["modelId"] = "ModelY";
            data["id"] = "aaz980";



            string brokerIpAdress = "broker.hivemq.com";
            int brokerPort = 1883;
            string clientID = Guid.NewGuid().ToString();

            mqttClient = new MqttClient(brokerIpAdress, brokerPort, false, null, null, MqttSslProtocols.None);

            mqttClient.Connect(clientID);

            informThread = new Thread(HUBInform) {
                IsBackground = true,
            };

            informThread.Start();

        }

        protected virtual void Dispose(bool disposing) {
            if (!disposed) {
                if (disposing) {
                    mqttClient?.Disconnect();
                    isOn = false;
                }

                disposed = true;
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ChargeStationSimulator() {
            Dispose(false);
        }

        private void CalculateEnergy() {
            if (isEmpty)
                return;
            data["payload"]["energy"] += data["payload"]["current"] * data["payload"]["voltage"] / 100;
        }

        public bool Connect(ElectricVehicleSimulator electricVehicle, Dictionary<string, dynamic> carData) {
            if (!isEmpty) {
                return false;
            }
            isEmpty = false;
            data["action"] = "StartTransaction";
            StatusAndCurrent();

            carData["connectorId"] = data["payload"]["connectorId"];
            this.electricVehicle = electricVehicle;
            return true;
        }

        public void Disconnect(Dictionary<string, dynamic> carData) {
            isEmpty = true;

            carData["connectorId"] = null;
            electricVehicle = null;
            data["action"] = "StopTransaction";
            StatusAndCurrent();
        }


        private string GetTimeStamp() {
            DateTime currentTimestamp = DateTime.UtcNow.AddHours(3);
            string formattedTimestamp = currentTimestamp.ToString("yyyy-MM-ddTHH:mm:ssZ");

            return formattedTimestamp;
        }

        private void StatusAndCurrent() {
            if (isEmpty) {
                data["payload"]["status"] = "Available";
                data["payload"]["current"] = 0;
            }
            else {
                data["payload"]["status"] = "Occupied";
                data["payload"]["current"] = 32;
            }
        }

        public static string GetNextMessageId(string currentMessageId) {
            string prefix = currentMessageId.Substring(0, 3);
            int number = int.Parse(currentMessageId.Substring(3));

            if (number == 999) {
                char[] prefixArray = prefix.ToCharArray();
                int index = 2;

                while (index >= 0) {
                    if (prefixArray[index] == 'z') {
                        prefixArray[index] = 'a';
                        index--;
                    }
                    else {
                        prefixArray[index]++;
                        break;
                    }
                }

                prefix = new string(prefixArray);
                number = 0;
            }
            else {
                number++;
            }

            string nextMessageId = $"{prefix}{number:D3}";
            return nextMessageId;
        }


        public void HUBInform() {
            string HUBTopic = "chargestation/hub";
            while (isOn) {
                lock (lockObject) {
                    mqttClient.Publish(HUBTopic, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
                    data["action"] = "Heartbeat";
                    Thread.Sleep(2000);
                    data["id"] = GetNextMessageId(data["id"]);
                    data["payload"]["timestamp"] = GetTimeStamp();
                    CalculateEnergy();
                }

            }
        }

    }
}
