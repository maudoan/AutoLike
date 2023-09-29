using AutoLike.Controller;
using AutoLike.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
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

            _form1Controller.loadGeneralSetting(selectPathProfileChromeTextBox, generalSetingUserProxyComboBox, apiKeyTextBox);

            keyApiList = _form1Controller.listKeyShopLike(apiKeyTextBox);
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
            else if (keyApiList.Count <= 0)
            {
                MessageBox.Show("Vui lòng nhập Key Proxy!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string path = _form1Controller.selectFile();

            if(path != "")
            {
                selectPathNamePageTextBox.Text = path;
            }
        }

        private void startRegPageButton_Click(object sender, EventArgs e)
        {
            if (selectPathProfileChromeTextBox.Text == string.Empty || generalSetingUserProxyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui chọn đủ cài đặt cơ bản!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (keyApiList.Count <= 0)  
            {
                MessageBox.Show("Vui lòng lưu lại cấu hình mới nhất!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            } 
            
            //else
            //{
            //    foreach (string line in apiLine)
            //    {
            //        keyApiList.Add(line);
            //    }
            //}

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"AutoLike\GeneralSetting.txt");

            if (File.Exists(filePath))
            {
                // Xóa nội dung bên trong tệp
                File.WriteAllText(filePath, string.Empty);
                Console.WriteLine("Đã xóa nội dung tệp GeneralSetting.txt.");
            }
            else
            {
                // Tạo tệp nếu nó không tồn tại
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.Create(filePath).Close();
                Console.WriteLine("Tạo tệp GeneralSetting.txt.");
            }
            string dt = generalSetingUserProxyComboBox.SelectedItem.ToString() + "|" + selectPathProfileChromeTextBox.Text + "|" + apiKeyTextBox.Text;
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AutoLike\GeneralSetting.txt", dt.ToString());
            MessageBox.Show("Lưu cấu hình thành công !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void generalSetingUserProxyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (generalSetingUserProxyComboBox.SelectedItem.ToString() == "Use Proxy")
            {
                apiKeyTextBox.Enabled = true;
            }
            else
            {
                apiKeyTextBox.Enabled = false;
            }
        }

        private void getAccessTokenEAAGButton_Click(object sender, EventArgs e)
        {
            _form1Controller.getAccessTokenEAAG(detailListAccountsDataGridView);
        }

        private void getInfoAccountToken_Click(object sender, EventArgs e)
        {
            _form1Controller.getInfoAccounts(detailListAccountsDataGridView);
        }

        private void checkStatusCookieButton_Click(object sender, EventArgs e)
        {
            _form1Controller.checkStatusCookie(detailListAccountsDataGridView);
        }


        private void startWithSeedingWithPageButton_Click(object sender, EventArgs e)
        {
            if (selectPathProfileChromeTextBox.Text == string.Empty || generalSetingUserProxyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui chọn đủ cài đặt cơ bản!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (keyApiList.Count <= 0)
            {
                MessageBox.Show("Vui lòng nhập Key Proxy!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _form1Controller.setStopLikePageFalse();
                _form1Controller.likePost(selectPathProfileChromeTextBox.Text, detailListAccountsDataGridView, generalSettingflowNumberNumericUpDown, generalSetingUserProxyComboBox, keyApiList, sType2SeedingPageCheckbox, keyGetUidSeedingPageTextBox,timeGetNumBerNumericUpDown);
                tabControl.SelectTab(doashBoardTabPage);
            }   
        }

        private void changePageToUidButton_Click(object sender, EventArgs e)
        {
            if (selectPathProfileChromeTextBox.Text == string.Empty || generalSetingUserProxyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui chọn đủ cài đặt cơ bản!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (keyApiList.Count <= 0)
            {
                MessageBox.Show("Vui lòng nhập Key Proxy!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _form1Controller.movePageToUid(selectPathProfileChromeTextBox.Text, detailListAccountsDataGridView, generalSettingflowNumberNumericUpDown, generalSetingUserProxyComboBox, keyApiList);
            }
        }

        private void selectPathProfileChromeButton_Click(object sender, EventArgs e)
        {
            string path = _form1Controller.selectFolder();

            if (path != "")
            {
                selectPathProfileChromeTextBox.Text = path;
            }
        }

        private void readAllFileButton_Click(object sender, EventArgs e)
        {
            _form1Controller.getListAccount("ALL", detailListAccountsDataGridView);
        }

        private void saveFileNameButton_Click(object sender, EventArgs e)
        {
            _form1Controller.saveCategory(listFileDataGridView, importFileTextBox);
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _form1Controller.deleteAllByCateloge(deleteFileToolStripMenuItem, listFileDataGridView);
        }

        private void importDataFileToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Boolean checkImportFile;

            checkImportFile = _form1Controller.SelectFile(listFileDataGridView);

            if (checkImportFile)
            {
                listFileDataGridView.Rows.Clear();
                _form1Controller.LoadFileAccount(listFileDataGridView);

            }
        }

        private void stopLikePostButton_Click(object sender, EventArgs e)
        {
            _form1Controller.setStopLikePageTrue();
        }
    }
}
