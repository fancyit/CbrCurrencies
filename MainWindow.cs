using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace CBRCurrs
{
    public partial class MainWindow : Form
    {
        private XmlNode data { get; set; }       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, System.EventArgs e)
        {
           
        }

        private void GetCurrencies_Click(object sender, System.EventArgs e)
        {
            values_grid.Rows.Clear();
            values_grid.Columns.Clear();
            values_grid.Refresh();            
            var soapClient = new CBRSoapService.DailyInfoSoapClient();           
            data = soapClient.GetCursOnDateXML(dateTimePicker.Value);
            values_grid.Columns.Add("code", "Код");
            values_grid.Columns.Add("name", "Имя");
            values_grid.Columns.Add("rate", "Курс");            
            foreach (XmlNode node in data.SelectNodes("ValuteCursOnDate"))
            {
                values_grid.Rows.Add
                    (
                        node["VchCode"].InnerText,
                        node["Vname"].InnerText,
                        (Convert.ToDouble(node["Vcurs"].InnerText, NumberFormatInfo.InvariantInfo) 
                        / Convert.ToDouble(node["Vnom"].InnerText, NumberFormatInfo.InvariantInfo))
                    );
            }
            values_grid.AutoResizeColumns();

        }

        private void SaveTo_Click(object sender, System.EventArgs e)
        {
            string fName = DateTime.Now.ToString("MM_dd_yyyy.txt");
            string tempPath = Path.GetTempPath();
            string tempFile = tempPath + fName;
            if (data != null)
            {
                using (StreamWriter sw = File.CreateText(tempFile))
                {
                    foreach (XmlNode node in data.SelectNodes("ValuteCursOnDate"))
                    {
                        sw.Write(node["VchCode"].InnerText + "; ");
                        sw.Write(node["Vname"].InnerText + "; ");
                        sw.Write((Convert.ToDouble(node["Vcurs"].InnerText, NumberFormatInfo.InvariantInfo)
                        / Convert.ToDouble(node["Vnom"].InnerText, NumberFormatInfo.InvariantInfo)) + System.Environment.NewLine);
                    }
                    sw.Close();
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt|CSV file (*.csv)|*.csv";
            saveFileDialog.InitialDirectory = tempPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = saveFileDialog.FileName;
                FileInfo fi = new FileInfo(tempFile);
                if (fi.Exists)
                {
                    fi.MoveTo(fName);
                    MessageBox.Show("File {fName} has been saved", "Save results");
                }
            }
        }
    }
}
