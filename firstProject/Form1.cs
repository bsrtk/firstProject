using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string istenilenMail = "bsrtk@gmail.com"; 
            string mail=mailTextbox.Text;

            if(istenilenMail == mail)
            {
                sonucLabel.Text = "giriş başarılı";
            }
            else
            {
                sonucLabel.Text = "giriş başarılı değil tekrar deneyin";
            }
        }
    }
}
