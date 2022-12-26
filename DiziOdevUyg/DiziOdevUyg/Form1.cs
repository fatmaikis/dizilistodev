using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DiziOdevUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList dizi = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            dizi.Add("Adı :  " + isimekletxt.Text);
            foreach (var item in dizi)
            {
                
                listBox1.Items.Add(item);
                isimekletxt.Clear();
            }
        }

        private void indexeeklebtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            dizi.Insert(1,isimekletxt.Text);
            foreach (var item in dizi)
            {
                
                listBox1.Items.Add("Adı :  " + item);
                isimekletxt.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            dizi.Insert(3, isimekletxt.Text);
            foreach (var item in dizi)
            {

                listBox1.Items.Add("Adı :  " + item);
                isimekletxt.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ArrayList yeniDizi = new ArrayList() {isimekletxt.Text};
            dizi.InsertRange(2, yeniDizi);
            foreach (var item in dizi)
            {
                listBox1.Items.Add("Adı :  " + item);
                isimekletxt.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ArrayList dizi2 = new ArrayList();
            dizi2.InsertRange(0, dizi.GetRange(2,2));
            foreach (var item in dizi2)
            {
                listBox1.Items.Add("Adı : " + item);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            object[] dizi3 = dizi.GetRange(0,6).ToArray();
            foreach (var item in dizi3)
            {
                listBox1.Items.Add("Adı : " + item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (dizi.Contains(isimekletxt.Text))
            {
                MessageBox.Show("Boyle bir isim var");
                foreach (var item in dizi)
                {
                    listBox1.Items.Add("Adı : " + item);
                }
                isimekletxt.Clear();
                
                
            }
            else
            {
                MessageBox.Show("Boyle bir isim yok");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            object[] dizi4 = { isimekletxt.Text};
            dizi.SetRange(3, dizi4);
            foreach (var item in dizi)
            {
                listBox1.Items.Add("Adı :  " + item);
                isimekletxt.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            dizi.TrimToSize();
            foreach (var item in dizi)
            {
                listBox1.Items.Add("Adı : " + isimekletxt.Text);
            }
            
        }
        
    }
}

