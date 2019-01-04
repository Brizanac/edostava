using System;
using System.IO; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sluzba_dostave
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           this.Close(); 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var sw = new System.IO.StreamWriter("C:\\" + textBox1.Text + "\\login.ID");
                sw.Write(textBox1.Text + "\n" + textBox2.Text);
                sw.Close();

            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                System.IO.Directory.CreateDirectory("C:\\" + textBox1.Text);
                var sw = new System.IO.StreamWriter("C:\\" + textBox1.Text + "\\login.ID");
                sw.Write(textBox1.Text + "\n" + textBox2.Text);
                sw.Close();
            }

            MessageBox.Show("Korisnik spremljen!", "Uspješno!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
