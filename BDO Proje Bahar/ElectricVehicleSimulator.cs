using System;
using System.Threading;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace BDO_Proje_Bahar {
    internal class ElectricVehicleSimulator {
        private MqttClient mqttClient;
        private bool isRunning;
        private bool isCharging;
        private int chargeLevel;
        private Thread simulationThread;
        private Thread chargeThread;

        public ElectricVehicleSimulator() {
            // MQTT broker bağlantısı ve konfigürasyonu
            string brokerIpAddress = "broker.hivemq.com";
            int brokerPort = 1883;
            string clientId = Guid.NewGuid().ToString();
            mqttClient = new MqttClient(brokerIpAddress, brokerPort, false, null, null, MqttSslProtocols.None);

            // MQTT broker'a bağlan
            mqttClient.Connect(clientId);
            // Araç başlangıç değerleri
            isRunning = false;
            chargeLevel = 0;

        }

        public void Start() {
            if (!isRunning) {
                simulationThread = new Thread(Simulate) {
                    IsBackground = true
                };
                isRunning = true;
                PublishStatus("Running");
                simulationThread.Start();
            }
        }

        public void Stop() {
            if (isRunning) {
                isRunning = false;
                // Simülasyon iş parçacığının tamamlanmasını bekle
                PublishStatus("Stopped");
            }
        }

        public void StopCharge() {
            if (isCharging) {
                isCharging = false;

                PublishStatus("Stopped Charging");
            }
        }


        private void Charge() {
            PublishStatus("Charging");
            Thread.Sleep(1000);
            while (isRunning && chargeLevel <= 100 && isCharging) {
                chargeLevel += 1; // 1 saniye bekleyerek şarj seviyesini artır
                Thread.Sleep(1000);
            }
        }


        private void Simulate() {
            while (isRunning) {
                PublishChargeLevel();
                Thread.Sleep(1000); // Her 1 saniyede bir şarj durumunu yayınla
            }
        }

        private void PublishChargeLevel() {
            string topic = "arac/durumu";
            string message = chargeLevel.ToString();
            mqttClient.Publish(topic, System.Text.Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            Console.WriteLine($"Aracın şarj seviyesi: {chargeLevel}/100");
        }

        private void PublishStatus(string status) {
            string topic = "arac/durumu";
            string message = status; mqttClient.Publish(topic, System.Text.Encoding.UTF8.GetBytes(message), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            Console.WriteLine($"Araç durumu: {status}");
        }

        public void StartCharging() {
            if (!isCharging) {
                isCharging = true;
                chargeThread = new Thread(Charge) {
                    IsBackground = true
                };
                chargeThread.Start();
            }
        }

        public void KillThreads() {
            mqttClient.Disconnect();
        }

    }

}
