using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        ChipherService chipherService;
        public Form1()
        {
            InitializeComponent();
            chipherService = new ChipherService();
        }

        private void showErrorMessage(string message)
        {
            MessageBox.Show(message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int key = ;

            if (this.StartText.Text.Trim().Length == 0 || this.Key.Text.Trim().Length == 0)
            {
                showErrorMessage("Ви ввели не повні дані!!!");
            }
            else if (Convert.ToInt32(this.Key.Text.Trim()) <= 0 || Convert.ToInt32(this.Key.Text.Trim()) >= 26)
            {
                showErrorMessage("Зсув поза діапазоном!!! Має бути від 1 до 25");
            }
            else
            {
                string text = this.StartText.Text.Trim();

                string result = chipherService.generateChipher(text, Convert.ToInt32(this.Key.Text.Trim()));

                this.Result.Text = result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.StartText.Clear();
            this.Key.Text = "3";
            this.Result.Clear();
        }
    }
}
