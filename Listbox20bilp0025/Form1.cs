using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox20bilp0025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] isimler = { "Burak", "Öner", "Erdoğan", "Ahmetcan" };
            listBox1.Items.AddRange(isimler);
            string[] isimler2 = { "Ayşe", "Ali", "Veli", "Osman" };
            listBox2.Items.AddRange(isimler2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                listBox1.Items.Add(textBox1.Text);
            else if (radioButton2.Checked)
                listBox2.Items.Add(textBox1.Text);
            else
                MessageBox.Show("Lütfen Vardiya Seçiniz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kayıt Silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (onay==DialogResult.Yes)
            {
                try
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
                catch
                {
                    MessageBox.Show("Lürfen Seçim Yapınız!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                object secili = listBox1.SelectedItem;
                listBox2.Items.Add(secili);
                listBox1.Items.Remove(secili);
            }
            catch
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                object secili = listBox2.SelectedItem;
                listBox1.Items.Add(secili);
                listBox2.Items.Remove(secili);
            }
            catch
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
        }   
    }
}
