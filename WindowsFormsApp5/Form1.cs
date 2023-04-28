using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;


namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        private void sendWhatsApp(string  number, string message)

        {

            try

            {
                

                if (number == "")

                {

                    MessageBox.Show("No number added");

                }

                if (number.Length <= 11)
                {
                   
                    number= "2" + number;

                }

                number = number.Replace(" ", "");

                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + number + "&text=" + message);

            }

            catch (Exception ex)
            {

            }
            i++;
        }


        private void button1_Click(object sender, EventArgs e)
        {

          
         
                sendWhatsApp("01203463144", "test");
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



