using System.Windows.Forms;

namespace BDO_Proje_Bahar {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        ElectricVehicleSimulator ev = new ElectricVehicleSimulator();
        private void Form1_Load(object sender, System.EventArgs e) {
            TeslaPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            MercedesPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            ToyotaPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button1_Click(object sender, System.EventArgs e) {
            ev.Start();
        }

        private void button2_Click(object sender, System.EventArgs e) {
            ev.StartCharging();
        }

        private void button3_Click(object sender, System.EventArgs e) {
            ev.StopCharge();
        }

        private void button10_Click(object sender, System.EventArgs e) {
            ev.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            ev.KillThreads();
        }
    }
}
