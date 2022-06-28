using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace firstproject
{
    public partial class regi3d : Form
    {
        string[] arr = new string[5];
        string brme = "";
        public regi3d()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || richTextBox1.Text == "" || richTextBox2.Text == "" || richTextBox3.Text == "" || richTextBox4.Text == "")
            {
                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
                {
                    arr[0] = checkBox1.Text;
                    arr[1] = checkBox2.Text;
                    arr[2] = checkBox3.Text;
                    arr[3] = checkBox4.Text;
                    arr[4] = checkBox5.Text;
                    foreach (string s in arr)
                    {
                        brme += s + " , ";
                    }
                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == false)
                {
                    arr[0] = checkBox1.Text;
                    arr[1] = checkBox2.Text;
                    arr[2] = checkBox3.Text;
                    arr[3] = checkBox4.Text;
                    arr[4] = checkBox5.Text;
                    foreach (string s in arr)
                    {
                        brme += s + " , ";
                    }
                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false && checkBox5.Checked == false)
                {
                    arr[0] = checkBox1.Text;
                    arr[1] = checkBox2.Text;
                    arr[2] = checkBox3.Text;
                    arr[3] = checkBox4.Text;
                    arr[4] = checkBox5.Text;
                    foreach (string s in arr)
                    {
                        brme += s + " , ";
                    }
                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
                {
                    arr[0] = checkBox1.Text;
                    arr[1] = checkBox2.Text;
                    arr[2] = checkBox3.Text;
                    arr[3] = checkBox4.Text;
                    arr[4] = checkBox5.Text;
                    foreach (string s in arr)
                    {
                        brme += s + " , ";
                    }
                }
                else if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
                {
                    arr[0] = checkBox1.Text;
                    arr[1] = checkBox2.Text;
                    arr[2] = checkBox3.Text;
                    arr[3] = checkBox4.Text;
                    arr[4] = checkBox5.Text;
                    foreach (string s in arr)
                    {
                        brme += s + " , ";
                    }
                }
                else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
                {
                    arr[0] = checkBox1.Text;
                    arr[1] = checkBox2.Text;
                    arr[2] = checkBox3.Text;
                    arr[3] = checkBox4.Text;
                    arr[4] = checkBox5.Text;
                    foreach (string s in arr)
                    {
                        brme += s + " , ";
                    }
                }

                MessageBox.Show("please fill the all details !!!");
            }
            else
            {
                MessageBox.Show("^-^");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();  
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";  
            if (opnfd.ShowDialog()== DialogResult.OK)  
            {  
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }  
        }
    }
}
