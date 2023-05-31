using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace BDO_Proje_Bahar {
    public partial class Form1 : Form {

        Dictionary<string, Tabs> tabs = new Dictionary<string, Tabs>();
        private string filePath = string.Empty;

        readonly ChargeStationSimulator chargeStation1;
        readonly ChargeStationSimulator chargeStation2;
        readonly ElectricVehicleSimulator tesla;
        readonly ElectricVehicleSimulator mercedes;
        readonly ElectricVehicleSimulator toyota;

        MqttClient mqttClient;

        void OnMessageReceived(object sender, MqttMsgPublishEventArgs e) {
            string message = Encoding.Default.GetString(e.Message);
            string topic = e.Topic;


            Dictionary<string, dynamic> data = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(message);

            if (topic == "chargestation/hub") {
                if (data["payload"]["connectorId"] == "1") {
                    UpdateLabel(ŞarjİstasyonuALabel, StationLabelFormatter(data));
                    if (data["payload"]["status"] == "Available") {
                        UpdateRadioButton(TeslaChargeStationARadio, true);
                        UpdateRadioButton(MercedesChargeStationARadio, true);
                        UpdateRadioButton(ToyotaChargeStationARadio, true);
                    }
                    else {
                        UpdateRadioButton(TeslaChargeStationARadio, false);
                        UpdateRadioButton(MercedesChargeStationARadio, false);
                        UpdateRadioButton(ToyotaChargeStationARadio, false);
                    }

                }
                else if (data["payload"]["connectorId"] == "2") {
                    UpdateLabel(ŞarjİstasyonuBLabel, StationLabelFormatter(data));
                    if (data["payload"]["status"] == "Available") {
                        UpdateRadioButton(TeslaChargeStationBRadio, true);
                        UpdateRadioButton(MercedesChargeStationBRadio, true);
                        UpdateRadioButton(ToyotaChargeStationBRadio, true);
                    }
                    else {
                        UpdateRadioButton(TeslaChargeStationBRadio, false);
                        UpdateRadioButton(MercedesChargeStationBRadio, false);
                        UpdateRadioButton(ToyotaChargeStationBRadio, false);
                    }
                }
            }
            else if (topic == "test/test/test/test/test/test/test") {

                if (data["model"] == "BZ4X") {
                    UpdateLabel(ToyotaCarStatusLabel, VehicleLabelFormatter(data));
                    UpdateProgressBar(ToyotaProgressBar, data["chargePercentage"].ToString());
                    UpdateProgressBar(ToyotaProgressBar, data["chargePercentage"]);
                }
                else if (data["model"] == "ForTwo") {
                    UpdateLabel(MercedesCarStatusLabel, VehicleLabelFormatter(data));
                    UpdateProgressBar(MercedesProgressBar, data["chargePercentage"].ToString());
                    UpdateProgressBar(MercedesProgressBar, data["chargePercentage"]);
                }
                else if (data["model"] == "Model 3") {
                    UpdateLabel(TeslaCarStatusLabel, VehicleLabelFormatter(data));
                    UpdateProgressBar(TeslaProgressBar, data["chargePercentage"].ToString());
                    UpdateProgressBar(TeslaProgressBar, data["chargePercentage"]);
                }
                else {
                    UpdateLabel(tabs[data["model"]].TabPage.Controls[data["model"] + "StatusLabel"]
                        , VehicleLabelFormatter(data));
                    UpdateProgressBar(tabs[data["model"]].TabPage.Controls[data["model"] + "CircularProgressBar"]
                        , data["chargePercentage"].ToString());
                    UpdateProgressBar(tabs[data["model"]].TabPage.Controls[data["model"] + "CircularProgressBar"]
                        , data["chargePercentage"]);
                }


            }
        }



        private void UpdateLabel(Label label, string text) {
            if (label.InvokeRequired) {
                label.Invoke(new Action<Label, string>(UpdateLabel), label, text);
            }
            else {
                label.Text = text;
            }
        }

        private void UpdateRadioButton(RadioButton radioButton, bool isOccupied) {

            if (radioButton.InvokeRequired) {
                radioButton.Invoke(new Action<RadioButton, bool>(UpdateRadioButton), radioButton, isOccupied);
            }
            else {
                radioButton.Enabled = isOccupied;
            }
        }

        private void UpdateProgressBar(ProgressBar progressBar, Int64 value) {
            if (progressBar.InvokeRequired) {
                progressBar.Invoke(new Action<ProgressBar, Int64>(UpdateProgressBar), progressBar, (int)value);
            }
            else {
                progressBar.Value = (int)value;
            }
        }

        private void UpdateProgressBar(ProgressBar progressBar, string value) {
            if (progressBar.InvokeRequired) {
                progressBar.Invoke(new Action<ProgressBar, string>(UpdateProgressBar), progressBar, value);
            }
            else {
                progressBar.Text = value;
            }
        }

        static private string StationLabelFormatter(Dictionary<string, dynamic> dict) {
            return "{" + $"\n  \"action\": \"{dict["action"]}\","
                + "\n  \"payload\": {" + $"\n    \"connectorId\": {dict["payload"]["connectorId"]},"
                + $"\n    \"status\": \"{dict["payload"]["status"]}\","
                + $"\n    \"current\": {dict["payload"]["current"]},"
                + $"\n    \"voltage\": {dict["payload"]["voltage"]},"
                + $"\n    \"energy\": {dict["payload"]["energy"]},"
                + $"\n    \"errorCode\": {dict["payload"]["errorCode"]},"
                + $"\n    \"timestamp\": \"{dict["payload"]["timestamp"]}\","
                + $"\n    \"modelId\": \"{dict["payload"]["modelId"]}\"" + "\n  },"
                + $"\n  \"id\": \"{dict["id"]}\"" + "\n}";
        }

        static private string VehicleLabelFormatter(Dictionary<string, dynamic> dict) {
            string batteryTemp = dict["batterytemp"] == null ? "" : dict["batterytemp"].ToString("F0") + "°C";
            string distance = dict["distance"] == null ? "" : dict["distance"].ToString("F0") + " Km";
            string fullChargeTime = dict["fullchargetime"] == null ? "" : dict["fullchargetime"].ToString("F0") + " Saniye";
            return "Durum: " + dict["status"] + "\n" + "Bağlanılan Cihaz: " + dict["connectorId"]
                + "\n" + "Kalan Süre: " + fullChargeTime
                + "\n" + "Batarya Sıcaklığı: " + batteryTemp
                + "\n" + "Tahmini Mesafe: " + distance;

        }

        public Form1() {
            InitializeComponent();
            TeslaPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            MercedesPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ToyotaPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            mqttClient = new MqttClient("broker.hivemq.com", 1883, false, null, null, MqttSslProtocols.None);

            string clientID = Guid.NewGuid().ToString();

            mqttClient.Connect(clientID);

            string[] topics = { "chargestation/hub", "test/test/test/test/test/test/test" };
            byte[] qosLevels = { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };
            mqttClient.Subscribe(topics, qosLevels);



            mqttClient.MqttMsgPublishReceived += OnMessageReceived;

            chargeStation1 = new ChargeStationSimulator("1");
            chargeStation2 = new ChargeStationSimulator("2");
            tesla = new ElectricVehicleSimulator("Tesla", "Model 3", 5.75, 405);
            mercedes = new ElectricVehicleSimulator("Smart EQ", "ForTwo", 1.67, 100);
            toyota = new ElectricVehicleSimulator("Toyota", "BZ4X", 6.4, 340);


        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

            foreach (KeyValuePair<string, Tabs> tab in tabs) {
                tab.Value.ElectricVehicleSimulator.Dispose();
            }

            chargeStation1.Dispose();
            chargeStation2.Dispose();
            tesla.Dispose();
            mercedes.Dispose();
            toyota.Dispose();

            mqttClient.Disconnect();
        }

        private void TeslaStartButton_Click(object sender, EventArgs e) {
            tesla.TurnOn();
        }

        private void TeslaConnectChargeButton_Click(object sender, EventArgs e) {
            if (TeslaChargeStationARadio.Checked && tesla.IsTurnedOn) {
                tesla.Connect(chargeStation1);
            }
            else if (TeslaChargeStationBRadio.Checked && tesla.IsTurnedOn) {
                tesla.Connect(chargeStation2);
            }
            else {
                MessageBox.Show("Lütfen bir şarj aleti seçin ya da simülasyonu başlatın!\t", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TeslaDisconnectChargeButton_Click(object sender, EventArgs e) {
            tesla.Disconnect();
        }

        private void TeslaStopButton_Click(object sender, EventArgs e) {
            tesla.TurnOff();
        }

        private void MercedesStartButton_Click(object sender, EventArgs e) {
            mercedes.TurnOn();
        }

        private void MercedesConnectChargeButton_Click(object sender, EventArgs e) {
            if (MercedesChargeStationARadio.Checked && mercedes.IsTurnedOn) {
                mercedes.Connect(chargeStation1);
            }
            else if (MercedesChargeStationBRadio.Checked && mercedes.IsTurnedOn) {
                mercedes.Connect(chargeStation2);
            }
            else {
                MessageBox.Show("Lütfen bir şarj aleti seçin ya da simülasyonu başlatın!\t", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MercedesDisconnectChargeButton_Click(object sender, EventArgs e) {
            mercedes.Disconnect();
        }

        private void MercedesStopButton_Click(object sender, EventArgs e) {
            mercedes.TurnOff();
        }

        private void ToyotaStartButton_Click(object sender, EventArgs e) {
            toyota.TurnOn();
        }

        private void ToyotaConnectChargeButton_Click(object sender, EventArgs e) {
            if (ToyotaChargeStationARadio.Checked && toyota.IsTurnedOn) {
                toyota.Connect(chargeStation1);
            }
            else if (ToyotaChargeStationBRadio.Checked && toyota.IsTurnedOn) {
                toyota.Connect(chargeStation2);
            }
            else {
                MessageBox.Show("Lütfen bir şarj aleti seçin ya da simülasyonu başlatın!\t", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ToyotaDisconnectChargeButton_Click(object sender, EventArgs e) {
            toyota.Disconnect();
        }

        private void ToyotaStopButton_Click(object sender, EventArgs e) {
            toyota.TurnOff();
        }

        private void UploadButton_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "Image Files (*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    filePath = openFileDialog.FileName;

                    UploadPictureBox.Load(filePath);
                }
            }
        }


        private void AddCarButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(BrandTxtBox.Text) || string.IsNullOrEmpty(ModelTxtBox.Text)
                || string.IsNullOrEmpty(BatteryTxtBox.Text) || string.IsNullOrEmpty(MaxBatteryDistanceTxtBox.Text) || string.IsNullOrEmpty(filePath)) {

                MessageBox.Show("Bütün boşlukları doldurun!\t", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Regex.IsMatch(BatteryTxtBox.Text, @"^[a-zA-z]") || Regex.IsMatch(MaxBatteryDistanceTxtBox.Text, @"^[a-zA-z]")) {
                MessageBox.Show("Batarya ve Mesafe girdileri rakamlardan oluşmalıdır!\t", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (KeyValuePair<string, Tabs> keyValue in tabs) {
                if (keyValue.Value.ElectricVehicleSimulator.Model == ModelTxtBox.Text)
                    MessageBox.Show("Belirtilen model araç sistemde bulumakta!\t", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Dictionary<string, string> names = new Dictionary<string, string> {
                ["brand"] = BrandTxtBox.Text,
                ["model"] = ModelTxtBox.Text,
                ["battery"] = BatteryTxtBox.Text,
                ["maxBatteryDistance"] = MaxBatteryDistanceTxtBox.Text,
                ["filepath"] = filePath,
            };

            List<ChargeStationSimulator> chargeStationSimulators = new List<ChargeStationSimulator> {
                chargeStation1,
                chargeStation2,
            };


            Tabs newTab = new Tabs(names, chargeStationSimulators, Tabs);


            tabs[ModelTxtBox.Text] = newTab;

            Tabs.TabPages.Add(newTab.TabPage);



            filePath = null;
            UploadPictureBox.Image = null;
        }

    }
}
