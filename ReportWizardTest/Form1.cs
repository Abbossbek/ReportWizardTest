using DevExpress.XtraReports.UI;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportWizardTest
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private string jsonPath;
        private string repxPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(repxPath))
            {
                MessageBox.Show("Choose REPX file");
                return;
            }
            if(string.IsNullOrWhiteSpace(jsonPath))
            {
                MessageBox.Show("Choose JSON file");
                return;
            }
            XtraReport xtraReport = new XtraReport(repxPath, jsonPath);
            //ReportDesignTool reportDesignTool = new ReportDesignTool(xtraReport);
            //reportDesignTool.ShowRibbonDesignerDialog();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PRNX files|*.prnx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                xtraReport.SaveDocument(saveFileDialog.FileName);
                MessageBox.Show("Saved");
            }
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "REPX files|*.repx";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                repxPath = openFileDialog.FileName;
                buttonEdit1.Text = openFileDialog.FileName;
            }
        }

        private void resourcesComboBoxControl1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files|*.json;*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                jsonPath = openFileDialog.FileName;
                resourcesComboBoxControl1.Text = openFileDialog.FileName;
            }
        }
    }
}
