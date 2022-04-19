using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perspico
{
    public partial class Form1 : Form
    {
        Button[] b = new Button[16];
        int i;
        int[] m = new int[16];
        public Form1()
        {
            InitializeComponent();
        }

        private void B_Click(object sender, EventArgs e)
        {
            int q = (int)((Button)(sender)).Tag;
            if (q == 15)
                if (m[q - 1] == 0)
                {
                    m[q - 1] = 1;
                    m[q] = 0;
                    button2.Text = b[q].Text;
                    b[q - 1].Text = b[q].Text;
                    b[q].Text = " ";
                }
                else
                    if (m[q - 4] == 0)
                    {
                        m[q - 4] = 1;
                        m[q] = 0;
                        button2.Text = b[q].Text;
                        b[q - 4].Text = b[q].Text;
                        b[q].Text = " ";
                    }

            if (q == 0)
                if (m[q + 1] == 0)
                {
                    m[q + 1] = 1;
                    m[q] = 0;
                    button2.Text = b[q].Text;
                    b[q + 1].Text = b[q].Text;
                    b[q].Text = " ";
                }
                else
                    
                    if (m[q + 4] == 0)
                    {
                        m[q + 4] = 1;
                        m[q] = 0;
                        button2.Text = b[q].Text;
                        b[q + 4].Text = b[q].Text;
                        b[q].Text = " ";
                    }

             if (q == 12)
                if (m[q + 1] == 0)
                {
                    m[q + 1] = 1;
                    m[q] = 0;
                    button2.Text = b[q].Text;
                    b[q + 1].Text = b[q].Text;
                    b[q].Text = " ";
                }
                else
                    if (m[q - 4] == 0)
                    {
                        m[q - 4] = 1;
                        m[q] = 0;
                        button2.Text = b[q].Text;
                        b[q - 4].Text = b[q].Text;
                        b[q].Text = " ";
                    }

             if (q == 3)
                if (m[q - 1] == 0)
                {
                    m[q - 1] = 1;
                    m[q] = 0;
                    button2.Text = b[q].Text;
                    b[q - 1].Text = b[q].Text;
                    b[q].Text = " ";
                }
                else
                    if (m[q + 4] == 0)
                    {
                        m[q + 4] = 1;
                        m[q] = 0;
                        button2.Text = b[q].Text;
                        b[q + 4].Text = b[q].Text;
                        b[q].Text = " ";
                    }

            if (q == 14 || q == 13)
                if (m[q + 1] == 0)
                {
                    m[q + 1] = 1;
                    m[q] = 0;
                    button2.Text = b[q].Text;
                    b[q + 1].Text = b[q].Text;
                    b[q].Text = " ";
                }
                else
                    if (m[q - 1] == 0)
                    {
                        m[q - 1] = 1;
                        m[q] = 0;
                        button2.Text = b[q].Text;
                        b[q - 1].Text = b[q].Text;
                        b[q].Text = " ";
                    }
                    else
                        if (m[q - 4] == 0)
                        {
                            m[q - 4] = 1;
                            m[q] = 0;
                            button2.Text = b[q].Text;
                            b[q - 4].Text = b[q].Text;
                            b[q].Text = " ";
                        }

            if (q == 4 || q == 8)
                    if (m[q + 1] == 0)
                    {
                        m[q + 1] = 1;
                        m[q] = 0;
                        button2.Text = b[q].Text;
                        b[q + 1].Text = b[q].Text;
                        b[q].Text = " ";
                    }
                    else
                        if (m[q + 4] == 0)
                        {
                            m[q + 4] = 1;
                            m[q] = 0;
                            button2.Text = b[q].Text;
                            b[q + 4].Text = b[q].Text;
                            b[q].Text = " ";
                        }
                        else
                            if (m[q - 4] == 0)
                            {
                                m[q - 4] = 1;
                                m[q] = 0;
                                button2.Text = b[q].Text;
                                b[q - 4].Text = b[q].Text;
                                b[q].Text = " ";
                            }

            if (q == 7 || q == 11)
                    if (m[q - 1] == 0)
                    {
                        m[q - 1] = 1;
                        m[q] = 0;
                        button2.Text = b[q].Text;
                        b[q - 1].Text = b[q].Text;
                        b[q].Text = " ";
                    }
                    else
                        if (m[q + 4] == 0)
                        {
                            m[q + 4] = 1;
                            m[q] = 0;
                            button2.Text = b[q].Text;
                            b[q + 4].Text = b[q].Text;
                            b[q].Text = " ";
                        }
                    else
                        if (m[q - 4] == 0)
                        {
                            m[q - 4] = 1;
                            m[q] = 0;
                            button2.Text = b[q].Text;
                            b[q - 4].Text = b[q].Text;
                            b[q].Text = " ";
                        }

            if (q == 1 || q == 2)
                if (m[q + 1] == 0)
                {
                    m[q + 1] = 1;
                    m[q] = 0;
                    button2.Text = b[q].Text;
                    b[q + 1].Text = b[q].Text;
                    b[q].Text = " ";
                }
                else
                    if (m[q - 1] == 0)
                    {
                        m[q - 1] = 1;
                        m[q] = 0;
                        button2.Text = b[q].Text;
                        b[q - 1].Text = b[q].Text;
                        b[q].Text = " ";
                    }
                    else
                        if (m[q + 4] == 0)
                        {
                            m[q + 4] = 1;
                            m[q] = 0;
                            button2.Text = b[q].Text;
                            b[q + 4].Text = b[q].Text;
                            b[q].Text = " ";
                        }    

            if (q == 5 || q==6 || q==9 || q==10 )
            {
                if (m[q + 1] == 0)
                {
                    m[q + 1] = 1;
                    m[q] = 0;
                    button2.Text = b[q].Text;
                    b[q + 1].Text = b[q].Text;
                    b[q].Text = " ";
                }
                else
                    if (m[q - 1] == 0)
                {
                    m[q - 1] = 1;
                    m[q] = 0;
                    button2.Text = b[q].Text;
                    b[q - 1].Text = b[q].Text;
                    b[q].Text = " ";
                }
                else
                        if (m[q + 4] == 0)
                {
                    m[q + 4] = 1;
                    m[q] = 0;
                    button2.Text = b[q].Text;
                    b[q + 4].Text = b[q].Text;
                    b[q].Text = " ";
                }
                else
                    if (m[q - 4] == 0)
                    {
                        m[q - 4] = 1;
                        m[q] = 0;
                        button2.Text = b[q].Text;
                        b[q - 4].Text = b[q].Text;
                        b[q].Text = " ";
                    }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            for (i = 0; i < 16; i++)
            {
                b[i] = new Button();
                b[i].Height = 106;
                b[i].Width = 106;
                b[i].Top = 100 + i / 4 * 100;
                b[i].Left = 100 + i % 4 * 100;
                this.Controls.Add(b[i]);
                b[i].FlatStyle = buttong.FlatStyle;
                b[i].BackColor = buttong.BackColor;
                b[i].Font = buttong.Font;
                m[i] = 0;
                b[i].Tag = i;
                b[i].Click += new EventHandler(B_Click);
            }
            b[0].Text = "7";
            b[1].Text = "1";
            b[2].Text = "6";
            b[3].Text = "14";
            b[4].Text = "2";
            b[5].Text = "11";
            b[6].Text = "12";
            b[7].Text = "3";
            b[8].Text = "5";
            b[9].Text = "10";
            b[10].Text = "13";
            b[11].Text = "15";
            b[12].Text = "8";
            b[13].Text = "9";
            b[14].Text = "4";
            for (i = 0; i < 15; i++)
                m[i] = 1;
            m[15] = 0;
            nIVEL1ToolStripMenuItem1.Enabled = false;
            nIVEL2ToolStripMenuItem.Enabled = false;
            nIVEL3ToolStripMenuItem.Enabled = false;
            nIVEL4ToolStripMenuItem.Enabled = false;
            nIVEL5ToolStripMenuItem.Enabled = false;
            nIVEL7ToolStripMenuItem.Enabled = false;
            nIVEL7ToolStripMenuItem1.Enabled = false;
            nIVEL8ToolStripMenuItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (b[0].Text == "1" && b[1].Text == "2" && b[2].Text == "3" && b[3].Text == "4" && b[4].Text == "5" && b[5].Text == "6" && b[6].Text == "7" && b[7].Text == "8" && b[8].Text == "9" && b[9].Text == "10" && b[10].Text == "11" && b[11].Text == "12" && b[12].Text == "13" && b[13].Text == "14" && b[14].Text == "15")
            {
                for (i = 0; i < 16; i++)
                    b[i].Enabled = false;
                button1.Visible = false;
                label1.Visible = true;
                if (button1.Visible == false)
                    if (nIVEL1ToolStripMenuItem.BackColor == Color.Red)
                    {
                        nIVEL1ToolStripMenuItem.BackColor = Color.Green;
                        nIVEL1ToolStripMenuItem.Enabled = false;
                        nIVEL1ToolStripMenuItem1.Enabled = true;
                    }
                    else
                        if (nIVEL1ToolStripMenuItem1.BackColor == Color.Red)
                        {
                            nIVEL1ToolStripMenuItem1.BackColor = Color.Green;
                            nIVEL1ToolStripMenuItem1.Enabled = false;
                            nIVEL2ToolStripMenuItem.Enabled = true;
                        }
                        else
                            if (nIVEL2ToolStripMenuItem.BackColor == Color.Red)
                            {
                                nIVEL2ToolStripMenuItem.BackColor = Color.Green;
                                nIVEL2ToolStripMenuItem.Enabled = false;
                                nIVEL3ToolStripMenuItem.Enabled = true;
                            }
                            else
                                   if (nIVEL3ToolStripMenuItem.BackColor == Color.Red)
                                   {
                                    nIVEL3ToolStripMenuItem.BackColor = Color.Green;
                                    nIVEL3ToolStripMenuItem.Enabled = false;
                                    nIVEL4ToolStripMenuItem.Enabled = true;
                                   }
                                   else
                                        if (nIVEL4ToolStripMenuItem.BackColor == Color.Red)
                                        {
                                            nIVEL4ToolStripMenuItem.BackColor = Color.Green;
                                            nIVEL4ToolStripMenuItem.Enabled = false;
                                            nIVEL5ToolStripMenuItem.Enabled = true;
                                       }
                                        else
                                            if (nIVEL5ToolStripMenuItem.BackColor == Color.Red)
                                            {
                                                nIVEL5ToolStripMenuItem.BackColor = Color.Green;
                                                nIVEL5ToolStripMenuItem.Enabled = false;
                                                nIVEL7ToolStripMenuItem.Enabled = true;
                                            }
                                            else
                                                if (nIVEL7ToolStripMenuItem.BackColor == Color.Red)
                                                {
                                                    nIVEL7ToolStripMenuItem.BackColor = Color.Green;
                                                    nIVEL7ToolStripMenuItem.Enabled = false;
                                                    nIVEL7ToolStripMenuItem1.Enabled = true;
                                                }
                                                else
                                                    if (nIVEL7ToolStripMenuItem1.BackColor == Color.Red)
                                                    {
                                                        nIVEL7ToolStripMenuItem1.BackColor = Color.Green;
                                                        nIVEL7ToolStripMenuItem1.Enabled = false;
                                                        nIVEL8ToolStripMenuItem.Enabled = true;
                                                    }
                                                    else
                                                        if (nIVEL8ToolStripMenuItem.BackColor == Color.Red)
                                                        { 
                                                            nIVEL8ToolStripMenuItem.BackColor = Color.Green;
                                                            nIVEL8ToolStripMenuItem.Enabled = false;
                                                        }

                if (nIVEL1ToolStripMenuItem1.BackColor == Color.Green && nIVEL1ToolStripMenuItem.BackColor == Color.Green && nIVEL2ToolStripMenuItem.BackColor == Color.Green && nIVEL3ToolStripMenuItem.BackColor == Color.Green && nIVEL4ToolStripMenuItem.BackColor == Color.Green && nIVEL5ToolStripMenuItem.BackColor == Color.Green && nIVEL7ToolStripMenuItem1.BackColor == Color.Green && nIVEL7ToolStripMenuItem1.BackColor == Color.Green && nIVEL8ToolStripMenuItem.BackColor == Color.Green)
                {
                    MessageBox.Show("Excelent! Ai terminat Jocul! ");
                    label1.Visible = false;
                }

            }
        }

        private void jOCNOUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void iESIREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sEATREFUNDALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog ClrDlg = new ColorDialog();
            ClrDlg.AllowFullOpen = true;
            if (ClrDlg.ShowDialog() == DialogResult.OK)
            {
                BackColor = ClrDlg.Color;
                menuStrip1.BackColor = ClrDlg.Color;
            }
        }

        private void nIVEL1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = true;
            for (i = 0; i < 15; i++)
                if (b[i].Enabled == false)
                    b[i].Enabled = true; 
            b[0].Text = "7";
            b[1].Text = "1";
            b[2].Text = "6";
            b[3].Text = "14";
            b[4].Text = "2";
            b[5].Text = "11";
            b[6].Text = "12";
            b[7].Text = "3";
            b[8].Text = "5";
            b[9].Text = "10";
            b[10].Text = "13";
            b[11].Text = "15";
            b[12].Text = "8";
            b[13].Text = "9";
            b[14].Text = "4";
            b[15].Text = " ";
            for (i = 0; i < 15; i++)
                m[i] = 1;
            m[15] = 0;
        }

        private void nIVEL1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = true;
            for (i = 0; i < 16; i++)
                if (b[i].Enabled == false)
                    b[i].Enabled = true;
            b[0].Text = "4";
            b[1].Text = "11";
            b[2].Text = "5";
            b[3].Text = "8";
            b[4].Text = "10";
            b[5].Text = "3";
            b[6].Text = "9";
            b[7].Text = "15";
            b[8].Text = "12";
            b[9].Text = "7";
            b[10].Text = "13";
            b[11].Text = "1";
            b[12].Text = "6";
            b[13].Text = "2";
            b[14].Text = "14";
            b[15].Text = " ";
            for (i = 0; i < 15; i++)
                m[i] = 1;
            m[15] = 0;
        }

        private void nIVEL2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = true;
            for (i = 0; i < 16; i++)
                if (b[i].Enabled == false)
                    b[i].Enabled = true;
            b[0].Text = "8";
            b[1].Text = "14";
            b[2].Text = "7";
            b[3].Text = "11";
            b[4].Text = "10";
            b[5].Text = "2";
            b[6].Text = "5";
            b[7].Text = "6";
            b[8].Text = "1";
            b[9].Text = "9";
            b[10].Text = "12";
            b[11].Text = "4";
            b[12].Text = "15";
            b[13].Text = "3";
            b[14].Text = "13";
            b[15].Text = " ";
            for (i = 0; i < 15; i++)
                m[i] = 1;
            m[15] = 0;
        }

        private void nIVEL3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = true;
            for (i = 0; i < 16; i++)
                if (b[i].Enabled == false)
                    b[i].Enabled = true;
            b[0].Text = "12";
            b[1].Text = "3";
            b[2].Text = "9";
            b[3].Text = "11";
            b[4].Text = "4";
            b[5].Text = "14";
            b[6].Text = "5";
            b[7].Text = "1";
            b[8].Text = "15";
            b[9].Text = "13";
            b[10].Text = "2";
            b[11].Text = " ";
            b[12].Text = "10";
            b[13].Text = "6";
            b[14].Text = "8";
            b[15].Text = "7";
            for (i = 0; i < 16; i++)
                m[i] = 1;
            m[11] = 0;
        }

        private void nIVEL4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = true;
            for (i = 0; i < 16; i++)
                if (b[i].Enabled == false)
                    b[i].Enabled = true;
            b[0].Text = "11";
            b[1].Text = "13";
            b[2].Text = "14";
            b[3].Text = "1";
            b[4].Text = "5";
            b[5].Text = "7";
            b[6].Text = "15";
            b[7].Text = "4";
            b[8].Text = "3";
            b[9].Text = "6";
            b[10].Text = "12";
            b[11].Text = "10";
            b[12].Text = "8";
            b[13].Text = "9";
            b[14].Text = "2";
            b[15].Text = " ";
            for (i = 0; i < 15; i++)
                m[i] = 1;
            m[15] = 0;
        }

        private void nIVEL5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = true;
            for (i = 0; i < 16; i++)
                if (b[i].Enabled == false)
                    b[i].Enabled = true;
            b[0].Text = "11";
            b[1].Text = "7";
            b[2].Text = "2";
            b[3].Text = "9";
            b[4].Text = "1";
            b[5].Text = "4";
            b[6].Text = "14";
            b[7].Text = "10";
            b[8].Text = "12";
            b[9].Text = "6";
            b[10].Text = "5";
            b[11].Text = "15";
            b[12].Text = "3";
            b[13].Text = "13";
            b[14].Text = "8";
            b[15].Text = " ";
            for (i = 0; i < 15; i++)
                m[i] = 1;
            m[15] = 0;
        }

        private void nIVEL7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = true;
            for (i = 0; i < 16; i++)
                if (b[i].Enabled == false)
                    b[i].Enabled = true;
            b[0].Text = "6";
            b[1].Text = "11";
            b[2].Text = "3";
            b[3].Text = "10";
            b[4].Text = "1";
            b[5].Text = "8";
            b[6].Text = "9";
            b[7].Text = " ";
            b[8].Text = "14";
            b[9].Text = "2";
            b[10].Text = "5";
            b[11].Text = "7";
            b[12].Text = "12";
            b[13].Text = "4";
            b[14].Text = "13";
            b[15].Text = "15";
            for (i = 0; i < 16; i++)
                m[i] = 1;
            m[7] = 0;
        }

        private void nIVEL7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = true;
            for (i = 0; i < 16; i++)
                if (b[i].Enabled == false)
                    b[i].Enabled = true;
            b[0].Text = "10";
            b[1].Text = "1";
            b[2].Text = "2";
            b[3].Text = "7";
            b[4].Text = "12";
            b[5].Text = "4";
            b[6].Text = "15";
            b[7].Text = "13";
            b[8].Text = "3";
            b[9].Text = "11";
            b[10].Text = "5";
            b[11].Text = "9";
            b[12].Text = "14";
            b[13].Text = "8";
            b[14].Text = "6";
            b[15].Text = " ";
            for (i = 0; i< 15; i++)
                m[i] = 1;
            m[15] = 0;
        }

        private void nIVEL8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = true;
            for (i = 0; i < 16; i++)
                if (b[i].Enabled == false)
                    b[i].Enabled = true;
            b[0].Text = "6";
            b[1].Text = "1";
            b[2].Text = "5";
            b[3].Text = "14";
            b[4].Text = "12";
            b[5].Text = "11";
            b[6].Text = "2";
            b[7].Text = "8";
            b[8].Text = "3";
            b[9].Text = "10";
            b[10].Text = "4";
            b[11].Text = "7";
            b[12].Text = "15";
            b[13].Text = "13";
            b[14].Text = "9";
            b[15].Text = " ";
            for (i = 0; i < 15; i++)
                m[i] = 1;
            m[15] = 0;
        }

        private void rEGULIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 settingsForm = new Form3();
            settingsForm.Show();
        }

        private void cREDITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 settingsForm = new Form4();
            settingsForm.Show();
        }
    
    }
}
