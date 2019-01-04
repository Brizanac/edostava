using System;
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
    public partial class Form1 : Form
    {
        public string username, password;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sr = new System.IO.StreamReader("C:\\" + textBox1.Text + "\\login.ID");
                username = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();

                if (username == textBox1.Text && password == textBox2.Text)
                    MessageBox.Show("Uspješno ste se prijavili!", "Uspješna prijava!");
                else
                    MessageBox.Show("Pogrešno ste unijeli korisničko ime ili lozinku!", "Pogreška!");

            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show("Korisnik ne postoji!", "Pogreška!");

            }
        }
    }
}
