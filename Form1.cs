namespace Random_Pin_Generator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.FlatAppearance.BorderSize = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e) {

            Random random = new Random();

            string numbers = "0123456789";
            string pinNumber = "";

            for(int i = 0; i < 4; i++) {
                pinNumber += random.Next(numbers.Length);
            }

            lblPinNo.Text = $"Your Pin Number: {pinNumber}";

        }
    }
}
