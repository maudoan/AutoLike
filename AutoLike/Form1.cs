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

            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\DATA\\CHROME_PROFILE"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\DATA\\CHROME_PROFILE");
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            _form1Controller.LoadFileAccount(listFileDataGridView);


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

        private void doashBoardHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int x = 0;
            int vl = doashBoardHScrollBar.Value;
            if (vl == 0)
            {
                tabControl.Location = new Point(x - vl, tabControl.Location.Y);
            }
            else
            {
                tabControl.Location = new Point((x - vl) * 2, tabControl.Location.Y);
            }

        }

        private void importFileTextBox_DoubleClick(object sender, EventArgs e)
        {
            Boolean checkImportFile;
          
            checkImportFile = _form1Controller.SelectFile();
            
            importFileTextBox.Text = _form1Controller.GetSelectedFileName();

            if (checkImportFile)
            {
                listFileDataGridView.Rows.Clear();
                _form1Controller.LoadFileAccount(listFileDataGridView);
                
            }
          
        }
        private void listFileDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            detailListAccountsDataGridView.Rows.Clear();
            int index = listFileDataGridView.CurrentCell.RowIndex;
            string fileName = listFileDataGridView.Rows[index].Cells[0].Value.ToString();
            _form1Controller.getListAccount(fileName, detailListAccountsDataGridView);
            for (int i = 0; i < detailListAccountsDataGridView.Rows.Count; i++)
            {
                string ac = "";
                for (int j = 2; j < detailListAccountsDataGridView.Rows[i].Cells.Count; j++)
                {
                    if (j == 2)
                    {
                        ac = detailListAccountsDataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        ac = ac + "|" + detailListAccountsDataGridView.Rows[i].Cells[j].Value.ToString();
                    }

                }
            }
        }


        private void selectAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int totalAccountSelected = 0;
            foreach (DataGridViewRow row in detailListAccountsDataGridView.SelectedRows)
            {
                detailListAccountsDataGridView.Rows[row.Index].Cells["checkboxItemAccount"].Value = true;

            }
            for (int i = 0; i < detailListAccountsDataGridView.Rows.Count; i++)
            {
                if (detailListAccountsDataGridView.Rows[i].Cells["checkboxItemAccount"].Value.ToString() == "True")
                {
                    totalAccountSelected += 1;
                }
            }
            totalAccountSelectedValueLabel.Text = totalAccountSelected.ToString();

        }

        private void selectAccountNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int totalAccountSelected = 0;
            foreach (DataGridViewRow row in detailListAccountsDataGridView.Rows)
            {
                detailListAccountsDataGridView.Rows[row.Index].Cells["checkboxItemAccount"].Value = false;

            }
            foreach (DataGridViewRow row in detailListAccountsDataGridView.SelectedRows)
            {
                detailListAccountsDataGridView.Rows[row.Index].Cells["checkboxItemAccount"].Value = true;

            }
            for (int i = 0; i < detailListAccountsDataGridView.Rows.Count; i++)
            {
                if (detailListAccountsDataGridView.Rows[i].Cells["checkboxItemAccount"].Value.ToString() == "True")
                {
                    totalAccountSelected += 1;
                }
            }
            totalAccountSelectedValueLabel.Text = totalAccountSelected.ToString();
        }
    }
}
