using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        string p = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }
        public void pound(string Menu, string Baht)
        {
            string[] pon = { Menu, Baht };
            var po = new ListViewItem(pon);
            listView1.Items.Add(po);
            ListPrice();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pound("Esspresso(Hot)", "35");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pound("Esspresso(Ice)", "45");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pound("Esspresso(Frappe)", "50");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pound("Amerlcano(Hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pound("Amerlcano(Ice)", "45");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pound("Lalte(Hot)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pound("Lalte(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pound("Lalte(Frappe)", "50");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pound("Mocha(Hot)", "35");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pound("Mocha(Ice)", "45");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pound("Mocha(Frappe)", "50");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pound("Cappuccino(Hot)", "35");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pound("Cappuccino(Ice)", "45");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pound("Cappuccino(Frappe)", "50");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pound("Green Tea(Hot)", "20");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pound("Green Tea(Ice)", "25");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pound("Green Tea(Frappe)", "30");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pound("Thai tea(Hot)", "20");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pound("Thai tea(Ice)", "25");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pound("Thai tea(Frappe)", "20");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            pound("Cocoa(Hot)", "20");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pound("Cocoa(Ice)", "25");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pound("Cocoa(Frappe)", "30");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pound("Milk(Hot)", "20");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            pound("Milk(Ice)", "25");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            pound("Milk(Frappe)", "30");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            pound("Milk Tea(Ice)", "25");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            pound("Milk Tea(Frappe)", "30");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            pound("Lemon Tea(Ice)", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            pound("Lemon Tea(Frappe)", "30");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            pound("Milo(Hot)", "20");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            pound("Milo(Ice)", "25");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            pound("Milo(Frappe)", "30");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            pound("Nescafe(Hot)", "20");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            pound("Nescafe(Ice)", "25");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            pound("Nescafe(Frappe)", "30");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            pound("Nestea Tea(Hot)", "20");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            pound("Nestea Tea(Ice)", "25");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            pound("Nestea Tea(Frappe)", "30");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            pound("Italian Soda(Ice)", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            pound("Red Lime Soda(Ice)", "25");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            pound("Honey Lime Soda(Ice)", "25");
        }
        double pon;
        public string[] ListPrice()
        {
            pon = 0;
            string[] k = new string[listView1.Items.Count];
            int u = listView1.Items.Count;
            for (int i = 0; i < u; i++)
            {
                pon += double.Parse(listView1.Items[i].SubItems[1].Text);
                k[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            label31.Text = pon.ToString();
            return k;
        }
        public string[] inListPrice()
        {
            string[] r = new string[listView1.Items.Count];
            int pon = listView1.Items.Count;
            for (int i =0; i< pon; i++)
            {
                r[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return r;
        }
        public void sef()
        {
            string[] h = ListPrice();
            string[] w = inListPrice();
            string hw = "Kikky Coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string bill = "Coffee_Pos";
            bill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd/mm/yyyy") + "\r\n" + "\r\n";
            for (int i=0; i < listView1.Items.Count; i++)
            {
                bill += h[i] + new String(' ', 20) + w[i] + "Bath" + "\r\n";
            }
            bill += "\r\n";
            bill += "Total Price :" + label31.Text;
            System.IO.File.WriteAllText(p + @"\" + hw + ".txt", bill);
            lb1.Text = bill + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + p + @"\" + hw + ".txt";
        }
        bool ob = false;

        private void button44_Click(object sender, EventArgs e)
        {
            lb1.Text = "";
            if (ob == false)
            {
                tabControl1.TabPages.Insert(1, Payment);
                ob = true;
                tabControl1.SelectedTab = Payment;
            }
            else tabControl1.SelectedTab = Payment;

            if (listView1.Items.Count > 0)
                sef();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ob = false;
            tabControl1.Controls.Remove(Payment);
            label31.Text = "";
            lb1.Text = "";
        }
    }
}
