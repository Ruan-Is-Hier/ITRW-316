using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KeyBoardHook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GlobalKeyboardHook gHook;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            gHook = new GlobalKeyboardHook();                                  
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                     gHook.HookedKeys.Add(key);
        }
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text += ((char)e.KeyValue).ToString();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gHook.unhook();
        }
        private void btnHook_Click(object sender, EventArgs e)
        {
            gHook.hook();
        }
        private void btnUnhook_Click(object sender, EventArgs e)
        {
            gHook.unhook();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("Text.txt");
            File.Write(textBox1.Text);
            File.Close();
            MessageBox.Show("Saved");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control == true && e.KeyCode == Keys.S)
            {
                btnSave.PerformClick();
                MessageBox.Show("Saved");
            }
        }
    }
}
