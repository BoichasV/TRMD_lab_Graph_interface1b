using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        TextBox txtBox;
        TextBox txtBox1;
        TextBox txtBox2;
        TextBox txtBoxName;
        TextBox txtBoxAge;
        Label lbl;
        Button btnlog;
        Button btnConf;
        Button btnreg;
        DataGridView data;
        public string[,] mass = { { "adm", "adm", "Admin", "21" }, { "kik", "parol", "Kick", "22" }, { "varax", "rur", "Varax", "12" }, { "jojo", "top", "Joeseph", "16" }, { "kick", "butovski", "Slava", "13" } };
        public string[,] mass1 = { {"","", "", ""} };
        public int rows;
        public int colums;
        public bool q = true;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void вхідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            txtBox = new TextBox();
            txtBox.Location = new Point(300, 50);
            txtBox.Visible = true;
            panel1.Controls.Add(txtBox);
            txtBox1 = new TextBox();
            txtBox1.Location = new Point(300, 100);
            txtBox1.Visible = true;
            panel1.Controls.Add(txtBox1);
            lbl = new Label();
            lbl.Location = new Point(100, 50);
            lbl.Visible = true;
            lbl.Text = "Login";
            panel1.Controls.Add(lbl);
            lbl = new Label();
            lbl.Location = new Point(100, 100);
            lbl.Visible = true;
            lbl.Text = "Password";
            panel1.Controls.Add(lbl);
            btnlog = new Button();
            btnlog.Location = new Point(150, 150);
            btnlog.Visible = true;
            btnlog.Text = "Log in";
            panel1.Controls.Add(btnlog);
            btnlog.Click += new EventHandler(btnlog_Click);
        }
        private void реєстраціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            txtBox = new TextBox();
            txtBox.Location = new Point(300, 50);
            txtBox.Visible = true;
            panel1.Controls.Add(txtBox);
            txtBox1 = new TextBox();
            txtBox1.Location = new Point(300, 100);
            txtBox1.Visible = true;
            panel1.Controls.Add(txtBox1);
            txtBox2 = new TextBox();
            txtBox2.Location = new Point(300, 150);
            txtBox2.Visible = true;
            panel1.Controls.Add(txtBox2);
            lbl = new Label();
            lbl.Location = new Point(100, 50);
            lbl.Visible = true;
            lbl.Text = "Login";
            panel1.Controls.Add(lbl);
            lbl = new Label();
            lbl.Location = new Point(100, 100);
            lbl.Visible = true;
            lbl.Text = "Password";
            panel1.Controls.Add(lbl);
            lbl = new Label();
            lbl.Width = 2000;
            lbl.Location = new Point(100, 150);
            lbl.Visible = true;
            lbl.Text = "Confirm password";
            panel1.Controls.Add(lbl);
            btnreg = new Button();
            btnreg.Location = new Point(200, 200);
            btnreg.Visible = true;
            btnreg.Text = "Sign up";
            panel1.Controls.Add(btnreg);
            btnreg.Click += new EventHandler(btnreg_Click);
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            bool a = true;
            rows = mass.GetUpperBound(0) + 1;
            for (int i = 0; i < rows; i++)
            {
                
                if (txtBox.Text != mass[i, 0] && txtBox1.Text == txtBox2.Text)
                {
                    q = false;
                    a = false;
                    mass1[0, 0] = txtBox.Text;
                    mass1[0, 1] = txtBox1.Text;
                   
                }
                
            }
            if (a)
            {
                MessageBox.Show("Error");
            }
            else
            {
                panel1.Controls.Clear();
                lbl = new Label();
                lbl.Location = new Point(100, 50);
                lbl.Visible = true;
                lbl.Text = "Enter ur name";
                panel1.Controls.Add(lbl);
                lbl = new Label();
                lbl.Location = new Point(100, 100);
                lbl.Visible = true;
                lbl.Text = "Enter ur age";
                panel1.Controls.Add(lbl);
                txtBoxName = new TextBox();
                txtBoxName.Location = new Point(300, 50);
                txtBoxName.Visible = true;
                panel1.Controls.Add(txtBoxName);
                txtBoxAge = new TextBox();
                txtBoxAge.Location = new Point(300, 100);
                txtBoxAge.Visible = true;
                panel1.Controls.Add(txtBoxAge);
                btnConf = new Button();
                btnConf.Location = new Point(200, 200);
                btnConf.Visible = true;
                btnConf.Text = "Sign up";
                panel1.Controls.Add(btnConf);
                btnConf.Click += new EventHandler(btnConf_Click);
            
            }
        }
        private void btnConf_Click(object sender, EventArgs e)
        {
            mass1[0, 2] = txtBoxName.Text;
            mass1[0, 3] = txtBoxAge.Text;
            отриманняДанихToolStripMenuItem_Click(null, null);
        }
        private void btnlog_Click(object sender, EventArgs e)
        {
            bool a = true;
            rows = mass.GetUpperBound(0) + 1;

            for (int i = 0; i < rows; i++)
            {
                

                    if (txtBox.Text == mass[i, 0] && txtBox1.Text == mass[i, 1])
                    {
                        a = false;
                        отриманняДанихToolStripMenuItem_Click(null, null);
                        break;
                    }


                
            }
            if (a)
            {
                MessageBox.Show("Incorrect login/password. Try again!");
            }
        }
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void отриманняДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            data = new DataGridView();
            data.Location = new Point(100, 50);
            data.Visible = true;
            data.Width = 500;
            data.Height = 300;
            data.Columns.Add("Index", "Index");
            data.Columns.Add("Value", "Users");
            data.Columns.Add("Value1", "Name");
            data.Columns.Add("Value2", "Age");
            int n = 0;
            for (int i = 0; i < rows; i++)
            {
                n = i + 2;
                data.Rows.Add(new object[] { i + 1, mass[i,0], mass[i, 2], mass[i,  3]});   
            }
            if (q == false)
            {
                data.Rows.Add(new object[] { n, mass1[0, 0], mass1[0, 2], mass1[0, 3] });
            }
            panel1.Controls.Add(data);
        }

        private void проДодатокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            lbl = new Label();
            lbl.Width = 2000;
            lbl.Location = new Point(100, 150);
            lbl.Visible = true;
            lbl.Text = "App created by.... just created";
            panel1.Controls.Add(lbl);
        }
    }
}

