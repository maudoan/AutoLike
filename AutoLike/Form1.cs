using AutoLike.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoLike
{
    public partial class Form1 : Form
    {
        private Form1Controller _form1Controller;
        public Form1()
        {
            InitializeComponent();
            _form1Controller = new Form1Controller();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void importFileTextBox_DoubleClick(object sender, EventArgs e)
        {
            Boolean checkImportFile;
            List<string> Categorys = new List<string>();
            checkImportFile = _form1Controller.SelectFile();
            
            importFileTextBox.Text = _form1Controller.GetSelectedFileName();


            Categorys = _form1Controller.LoadFileAccount();
            for (int i = 0; i < Categorys.Count; i++)
            {
                this.Invoke(new Action(() =>
                {

                    listFileDataGridView.Rows.Add(Categorys[i]);
                }));

            }
        }
    }
}
