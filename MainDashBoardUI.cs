/* Problem You update the database today from the website. However if you
 * update the database the data gets inserted at the bottom of the data 
 * sequence. Solutions
 *  1.  Validate the data before it's inserted into the database
 *  2.  OrderBy the list before it's inserted into the database
 */
 using HtmlAgilityPack;
using HtmlScrapeDataToSqlTable.DataAccess;
using HtmlScrapeDataToSqlTable.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HtmlScrapeDataToSqlTable
{
    public partial class MainDashboardUI : Form
    {
        List<DohlcModel> dohlcValues = new List<DohlcModel>();

        public MainDashboardUI()
        {
            InitializeComponent();

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async void btnAsyncUpdateTable_Click(object sender, EventArgs e)
        {
            var result = await AsyncTest.CallingAsync();

            dohlcValues = AsyncTest.ConvertDatesToDohlcModel(dohlcValues, result);

            dgvDohlcValues.DataSource = dohlcValues;

            SqlConnector.InsertDohlcValuesToSql(dohlcValues);
        }



    }// class Form1
}// namespace
