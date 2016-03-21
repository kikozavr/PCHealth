using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;

namespace PCHealth
{
    public partial class PCHealth : Form
    {
        //dddddddddddddddddddddddd

        List<DriveInfo> _DriveInfo;

        public PCHealth()
        {
            InitializeComponent();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void PCHealth_Load(object sender, EventArgs e)
        {
            DisplayFixedDrives();
        }

        private void checkedListBox_Drives_SelectedIndexChanged(object sender, EventArgs e)
        {            
            DisplayDriveInfo();
        }

        private void DisplayDriveInfo()
        {
            listBox_DriveInfo.Items.Clear();
            if (checkedListBox_Drives.SelectedIndex >= 0)
            {
                DriveInfo inf = new DriveInfo(checkedListBox_Drives.SelectedItem.ToString());
                if (inf.IsReady)
                {
                    listBox_DriveInfo.Items.Add("Метка тома: " + inf.VolumeLabel);
                    listBox_DriveInfo.Items.Add("Тип тома: " + inf.DriveType);
                    listBox_DriveInfo.Items.Add("Формат тома: " + inf.DriveFormat);
                    listBox_DriveInfo.Items.Add("Полный объем тома: " + Drives.GetTotalSpace_GB(inf, 1) + " GB");
                    listBox_DriveInfo.Items.Add("Свободное пространство: " + Drives.GetFreeSpace_GB(inf, 3) + " GB");
                }
                else
                {
                    listBox_DriveInfo.Items.Add("Устройство не готово!");
                }
            }
            else
            {
                listBox_DriveInfo.Items.Add("Выберите устройство.");
            }
        }

        private void DisplayFixedDrives()
        {
            checkedListBox_Drives.Items.Clear();
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (DriveInfo i in drivers)
            {
                if (i.DriveType==DriveType.Fixed)
                {
                    checkedListBox_Drives.Items.Add(i.Name);
                }
                
            }
        }

        private void button_getDrives_Click(object sender, EventArgs e)
        {
            DisplayFixedDrives();
            DisplayDriveInfo();
        }

        private void checkBox_askDrives_CheckedChanged(object sender, EventArgs e)
        {
            label_State.Text = "";
            if (checkBox_askDrives.Checked)
            {
                if (checkedListBox_Drives.SelectedIndex >= 0)
                {
                    button_getDrives.Enabled = false;
                    checkedListBox_Drives.Enabled = false;
                    _DriveInfo = new List<DriveInfo>();
                    DriveInfo[] d = new DriveInfo[checkedListBox_Drives.CheckedItems.Count];
                    for (int i = 0; i < d.Length; i++)
                    {
                        d[i] = new DriveInfo(checkedListBox_Drives.CheckedItems[i].ToString());
                    }
                    Thread t = new Thread(new ParameterizedThreadStart(askCheckedDrivesPeriodic));
                    t.IsBackground = true;
                    t.Start(d);
                }
                else
                {
                    checkBox_askDrives.Checked = false;
                    MessageBox.Show("Не выбраны диски!");
                }
            }
            else
            {
                button_getDrives.Enabled = true;
                checkedListBox_Drives.Enabled = true;
                //stopAsk();
            }
        }

        private void AddDriveinfoIntoList(DriveInfo[] askedDrives)
        {
            for (int i = 0; i < askedDrives.Length; i++)
            {
                _DriveInfo.Add(askedDrives[i]);
            }
        }

        private void askCheckedDrivesPeriodic(object drives)
        {
            DriveInfo[] d = (DriveInfo[])drives;
            while (checkBox_askDrives.Checked && checkedListBox_Drives.CheckedItems.Count>0)
            {
                AddDriveinfoIntoList(d);
                label_State.Text = "Зафиксировано " + _DriveInfo.Count.ToString() + " состояний.";
                Thread.Sleep((int)numericUpDown_wait.Value);
            }
            
        }
    }
}
