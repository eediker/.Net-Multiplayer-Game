﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LAB1
{
    public partial class MainGame : Form
    {
        public MainGame()
        {
            InitializeComponent();

            if(SettingsSave.Default.Username != "admin")
            {
                AdminPanelButton.Visible = false;
            }
            else
            {
                ShowUserProfile.Visible = false;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var Settings = new Settings();
            Settings.ShowDialog();
        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            var AdminPanel = new AdminPanel();
            AdminPanel.ShowDialog();
        }
    }
}
