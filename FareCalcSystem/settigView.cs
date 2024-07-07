using FareCalcSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareCalcSystem
{
    public partial class settigView : Form
    {
        private settingManager _instance = settingManager.Instance;
        public settigView()
        {
            InitializeComponent();
        }

        private void UpdateGridView()
        {
            settingGV.Rows.Clear();
            foreach(var setting in _instance.SettingList)
            {
                int rowIndex = settingGV.Rows.Add(_instance.GetSettingItems(setting));
                settingGV.Rows[rowIndex].Tag = setting;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addView = new addView();
            if(addView.ShowDialog() == DialogResult.OK)
            {
                _instance.AddSettings();
                UpdateGridView();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var addView = new addView(settingGV.SelectedRows[0].Tag as Settings);
            if(addView.ShowDialog() == DialogResult.OK )
            {
                _instance.EditSettings(settingGV.SelectedRows[0].Tag as Settings);
                UpdateGridView();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _instance.RemoveSettings(settingGV.SelectedRows[0].Tag as Settings);
            UpdateGridView();
        }

        private void displayCustomerBtn_Click(object sender, EventArgs e)
        {
            var customer = new CustomerView();
            customer.ShowDialog();
        }
    }
}
