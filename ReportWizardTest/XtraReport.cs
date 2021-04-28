using DevExpress.DataAccess.Json;
using DevExpress.XtraReports.UI;

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ReportWizardTest
{
    public partial class XtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport()
        {
            InitializeComponent();
        }
        public XtraReport(string repxPath, string jsonPath)
        {
            InitializeComponent();
            this.LoadLayout(repxPath);
            var jsonDataSource = new JsonDataSource();
            // Specify the JSON file name.
            Uri fileUri = new Uri(jsonPath, UriKind.RelativeOrAbsolute);
            jsonDataSource.JsonSource = new UriJsonSource(fileUri);
            // Populate the data source with data.
            jsonDataSource.Fill();

            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            jsonDataSource});
            this.DataSource = jsonDataSource;
        }

    }
}
