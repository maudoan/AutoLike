using AutoLike.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void selectAllAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int totalAccountSelected = 0;
            for (int i = 0; i < detailListAccountsDataGridView.Rows.Count; i++)
            {
                detailListAccountsDataGridView.Rows[i].Cells["checkboxItemAccount"].Value = true;
                totalAccountSelected += 1;
            }
            totalAccountSelectedValueLabel.Text = totalAccountSelected.ToString();
        }

        private void selectLiveAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int totalAccountSelected = 0;
            for (int i = 0; i < detailListAccountsDataGridView.Rows.Count; i++)
            {
                if (detailListAccountsDataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString() == "Live")
                {
                    detailListAccountsDataGridView.Rows[i].Cells["checkboxItemAccount"].Value = true;
                }
                else
                {
                    detailListAccountsDataGridView.Rows[i].Cells["checkboxItemAccount"].Value = false;
                }

            }
            
            for (int i = 0; i < detailListAccountsDataGridView.Rows.Count; i++)
            {
                if (detailListAccountsDataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString() == "Live")
                {
                    totalAccountSelected += 1;
                }
            }
            totalAccountSelectedValueLabel.Text = totalAccountSelected.ToString();

        }

        private void selectDieAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int totalAccountSelected = 0;
            for (int i = 0; i < detailListAccountsDataGridView.Rows.Count; i++)
            {
                if (detailListAccountsDataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString() == "Die")
                {
                    detailListAccountsDataGridView.Rows[i].Cells["checkboxItemAccount"].Value = true;
                }
                else
                {
                    detailListAccountsDataGridView.Rows[i].Cells["checkboxItemAccount"].Value = false;
                }

            }
            
            for (int i = 0; i < detailListAccountsDataGridView.Rows.Count; i++)
            {
                if (detailListAccountsDataGridView.Rows[i].Cells["tinhtrangAccount"].Value.ToString() == "Die")
                {
                    totalAccountSelected += 1;
                }
            }
            totalAccountSelectedValueLabel.Text = totalAccountSelected.ToString();

        }

        private void unSelectAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int totalAccountSelected = 0;
            foreach (DataGridViewRow row in detailListAccountsDataGridView.SelectedRows)
            {
                detailListAccountsDataGridView.Rows[row.Index].Cells["checkboxItemAccount"].Value = false;

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

        private void unSelectAllAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < detailListAccountsDataGridView.Rows.Count; i++)
            {
                detailListAccountsDataGridView.Rows[i].Cells["checkboxItemAccount"].Value = false;
            }
            totalAccountSelectedValueLabel.Text = "0";
        }


        private void flowLoginCookieTOkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectPathProfileChromeTextBox.Text == string.Empty || generalSetingUserProxyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui chọn đủ cài đặt cơ bản!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _form1Controller.LoginChromeWithCookieToken(selectPathProfileChromeTextBox.Text, detailListAccountsDataGridView, generalSettingflowNumberNumericUpDown, generalSetingUserProxyComboBox, keyApiList);
            }
        }

        private void regAndSeedingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(regAndSeedingTabPage);
        }

        private void selectPathNamePageButton_Click(object sender, EventArgs e)
        {
            string path = _form1Controller.selectFileNamePage();

            if(path != "")
            {
                selectPathNamePageTextBox.Text = path;
            }
        }

        private void startRegPageButton_Click(object sender, EventArgs e)
        {
            if(selectPathProfileChromeTextBox.Text == string.Empty || generalSetingUserProxyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui chọn đủ cài đặt cơ bản!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                _form1Controller.regPage(selectPathProfileChromeTextBox.Text, detailListAccountsDataGridView, generalSettingflowNumberNumericUpDown, generalSetingUserProxyComboBox, keyApiList);
            }
            
            tabControl.SelectTab(doashBoardTabPage);
        }


        /*
         * General Setting
         */
      
        List<string> keyApiList = new List<string>();
        private void savegeneralSettingButton_Click(object sender, EventArgs e)
        {

            if (selectPathProfileChromeTextBox.Text ==  string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đường dẫn Chrome !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (generalSetingUserProxyComboBox.SelectedItem != null)
            {
                
            } else
            {
                MessageBox.Show("Vui lòng chọn Proxy !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       
            string[]apiLine = apiKeyTextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (apiLine.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn nhập Key !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                foreach (string line in apiLine)
                {
                    keyApiList.Add(line);
                }
            }
            
        }

        private void generalSetingUserProxyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra giá trị đã chọn trong ComboBox
            if (generalSetingUserProxyComboBox.SelectedItem.ToString() == "Use Proxy")
            {
                // Nếu giá trị đã chọn là "Giá trị cụ thể", enable TextBox
                apiKeyTextBox.Enabled = true;
            }
            else
            {
                // Nếu không, vô hiệu hóa TextBox
                apiKeyTextBox.Enabled = false;
            }
        }
        private void getAccessTokenEAAG_Click(object sender, EventArgs e)
        {
            _form1Controller.getAccessTokenEAAG(detailListAccountsDataGridView);
        }
        private void getInfoAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _form1Controller.getInfoAccounts(detailListAccountsDataGridView);
        }
    }
}
