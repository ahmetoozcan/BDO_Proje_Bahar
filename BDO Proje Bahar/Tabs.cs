using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BDO_Proje_Bahar {
    internal class Tabs {

        private string model;

        private TabPage tabPage;
        private ElectricVehicleSimulator electricVehicle;
        private Button buttonOn;
        private Button buttonOff;
        private Button buttonConnect;
        private Button buttonDisconnect;
        private PictureBox pictureBox;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private GroupBox groupBox;
        private RadioButton radioButtonA;
        private RadioButton radioButtonB;
        private Label label;
        private List<ChargeStationSimulator> chargeStations;

        public Tabs(Dictionary<string, string> names, List<ChargeStationSimulator> chargeStationSimulators, TabControl tabControl) {

            tabPage = new TabPage(names["brand"] + " " + names["model"]);

            electricVehicle = new ElectricVehicleSimulator(names["brand"], names["model"],
                Int32.Parse(names["battery"]) / 10, Int32.Parse(names["maxBatteryDistance"]));

            chargeStations = chargeStationSimulators;

            model = names["model"];

            buttonOn = new Button();
            buttonOff = new Button();
            buttonConnect = new Button();
            buttonDisconnect = new Button();
            pictureBox = new PictureBox();
            circularProgressBar = new CircularProgressBar.CircularProgressBar();
            groupBox = new GroupBox();
            radioButtonA = new RadioButton();
            radioButtonB = new RadioButton();
            label = new Label();


            tabPage.Controls.Add(buttonOn);
            tabPage.Controls.Add(buttonOff);
            tabPage.Controls.Add(buttonConnect);
            tabPage.Controls.Add(buttonDisconnect);
            tabPage.Controls.Add(pictureBox);
            tabPage.Controls.Add(circularProgressBar);
            tabPage.Controls.Add(groupBox);
            tabPage.Controls.Add(label);


            buttonOn.Location = new System.Drawing.Point(19, 215);
            buttonOn.Size = new System.Drawing.Size(152, 78);
            buttonOn.Text = "Simülasyonu Çalıştır";
            buttonOn.UseVisualStyleBackColor = true;


            buttonConnect.Text = "Şarj Cihazını Bağla";
            buttonConnect.Location = new System.Drawing.Point(282, 215);
            buttonConnect.Size = new System.Drawing.Size(152, 78);
            buttonConnect.UseVisualStyleBackColor = true;


            buttonDisconnect.Text = "Şarj Cihazını Çıkar";
            buttonDisconnect.Location = new System.Drawing.Point(545, 215);
            buttonDisconnect.Size = new System.Drawing.Size(152, 78);
            buttonDisconnect.UseVisualStyleBackColor = true;


            buttonOff.Text = "Simülasyonu Kapat";
            buttonOff.Location = new System.Drawing.Point(808, 215);
            buttonOff.Size = new System.Drawing.Size(152, 78);
            buttonOff.UseVisualStyleBackColor = true;



            pictureBox.InitialImage = null;
            pictureBox.Location = new System.Drawing.Point(347, 6);
            pictureBox.Size = new System.Drawing.Size(270, 150);
            pictureBox.TabStop = false;
            pictureBox.WaitOnLoad = true;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Load(names["filepath"]);



            circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            circularProgressBar.AnimationSpeed = 500;
            circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            circularProgressBar.InnerColor = System.Drawing.Color.White;
            circularProgressBar.InnerMargin = 2;
            circularProgressBar.InnerWidth = -1;
            circularProgressBar.Location = new System.Drawing.Point(727, 346);
            circularProgressBar.MarqueeAnimationSpeed = 2000;
            circularProgressBar.OuterColor = System.Drawing.Color.Gray;
            circularProgressBar.OuterMargin = -25;
            circularProgressBar.OuterWidth = 26;
            circularProgressBar.ProgressColor = System.Drawing.Color.Green;
            circularProgressBar.ProgressWidth = 25;
            circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            circularProgressBar.Size = new System.Drawing.Size(150, 150);
            circularProgressBar.StartAngle = 270;
            circularProgressBar.SubscriptColor = System.Drawing.Color.White;
            circularProgressBar.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar.SubscriptText = "";
            circularProgressBar.SuperscriptColor = System.Drawing.Color.White;
            circularProgressBar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar.SuperscriptText = "";
            circularProgressBar.Text = "%67";
            circularProgressBar.TextMargin = new Padding(5);
            circularProgressBar.Value = 68;
            circularProgressBar.Name = names["model"] + "CircularProgressBar";




            groupBox.Controls.Add(radioButtonA);
            groupBox.Controls.Add(radioButtonB);


            groupBox.Location = new System.Drawing.Point(104, 374);
            groupBox.Size = new System.Drawing.Size(111, 73);
            groupBox.TabStop = false;
            groupBox.Text = "Şarj İstasyonları";



            radioButtonA.AutoSize = true;
            radioButtonA.Location = new System.Drawing.Point(6, 19);
            radioButtonA.Size = new System.Drawing.Size(101, 17);
            radioButtonA.TabStop = true;
            radioButtonA.Text = "Şarj İstasyonu A";
            radioButtonA.UseVisualStyleBackColor = true;


            radioButtonB.AutoSize = true;
            radioButtonB.Location = new System.Drawing.Point(6, 42);
            radioButtonB.Name = "ToyotaChargeStationBRadio";
            radioButtonB.Size = new System.Drawing.Size(101, 17);
            radioButtonB.TabStop = true;
            radioButtonB.Text = "Şarj İstasyonu B";
            radioButtonB.UseVisualStyleBackColor = true;



            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label.Location = new System.Drawing.Point(341, 327);
            label.Size = new System.Drawing.Size(318, 178);
            label.Text = "Car Status";
            label.Name = names["model"] + "StatusLabel";



            buttonOn.Click += ButtonOn_Click;
            buttonOff.Click += ButtonOff_Click;
            buttonConnect.Click += ButtonConnect_Click;
            buttonDisconnect.Click += ButtonDisconnect_Click;

        }

        private void ButtonOn_Click(object sender, EventArgs e) {
            electricVehicle.TurnOn();
        }
        private void ButtonOff_Click(object sender, EventArgs e) {
            electricVehicle.TurnOff();
        }
        private void ButtonConnect_Click(object sender, EventArgs e) {
            if (radioButtonA.Checked && electricVehicle.IsTurnedOn) {
                electricVehicle.Connect(chargeStations[0]);
            }
            else if (radioButtonB.Checked && electricVehicle.IsTurnedOn) {
                electricVehicle.Connect(chargeStations[1]);
            }
            else {
                MessageBox.Show("Lütfen bir şarj aleti seçin ya da simülasyonu başlatın!\t", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ButtonDisconnect_Click(object sender, EventArgs e) {
            electricVehicle.Disconnect();
        }

        public TabPage TabPage { get { return tabPage; } }
        public CircularProgressBar.CircularProgressBar CircularProgressBar { get { return circularProgressBar; } }
        public Label Label { get { return label; } }
        public string Model { get { return model; } }
        public ElectricVehicleSimulator ElectricVehicleSimulator { get { return electricVehicle; } }


    }
}
