using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;

namespace Bankify
{
    public partial class Form_ExtrasCont : Form
    {
        string iban;
        DataTable contentTable = new DataTable();
        public Form_ExtrasCont(string iban)
        {
            InitializeComponent();
            CenterToScreen();
            this.iban = iban;
        }

        private void Form_ExtrasCont_Load(object sender, EventArgs e)
        {
            contentTable = GetData().Tables[0];          
            dataGridView_ExtrasCont.DataSource = contentTable;
            dataGridView_ExtrasCont.Columns[0].HeaderText = "From IBAN";
            dataGridView_ExtrasCont.Columns[1].HeaderText = "To IBAN";
            dataGridView_ExtrasCont.Columns[2].HeaderText = "Amount";
            dataGridView_ExtrasCont.Columns[3].HeaderText = "Currency";
            dataGridView_ExtrasCont.Columns[4].HeaderText = "Transaction Date";
        }

        public DataSet GetData()
        {
            DataSet ds = new DataSet();
            using (var db = new Bank_dbEntities())
            {
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT from_iban,to_iban,amount,currency,transaction_date FROM Tranzaction " +
                                                              "WHERE from_iban=@iban OR to_iban=@iban", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.SelectCommand.Parameters.AddWithValue("@iban", iban);
                    adapter.Fill(ds);
                    con.Close();
                }
            }
            return ds;
        }

        private void button_fromIban_Click(object sender, EventArgs e)
        {
            DataTable dt = GetData().Tables[0];
            List<DataRow> rowList = new List<DataRow>();
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString() != iban)
                {
                    rowList.Add(row);
                }
            }

            foreach(DataRow row in rowList)
            {
                dt.Rows.Remove(row);
            }
            contentTable = dt;
            dataGridView_ExtrasCont.DataSource = contentTable;
        }

        private void button_toIban_Click(object sender, EventArgs e)
        {
            DataTable dt = GetData().Tables[0];
            List<DataRow> rowList = new List<DataRow>();
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[1].ToString() != iban)
                {
                    rowList.Add(row);
                }
            }

            foreach (DataRow row in rowList)
            {
                dt.Rows.Remove(row);
            }
            contentTable = dt;
            
            dataGridView_ExtrasCont.DataSource = contentTable;
        }

        private void button_viewAll_Click(object sender, EventArgs e)
        {
            dataGridView_ExtrasCont.DataSource = GetData().Tables[0];
            contentTable = GetData().Tables[0];
        }

        private void button_ExportExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = contentTable;
            Excel.Application xlAppToUpload = new Excel.Application();
            xlAppToUpload.Workbooks.Add();
            Excel.Worksheet xlWorkSheetToUpload = default(Excel.Worksheet);
            xlWorkSheetToUpload = xlAppToUpload.Sheets["Sheet1"];
            xlAppToUpload.Visible = true;

            if (dt.Rows.Count > 0)
            {
                int iRowCnt = 4;
                xlWorkSheetToUpload.Cells[1, 1].value = "Extras de cont";
                xlWorkSheetToUpload.Cells[1, 1].Font.Name = "Calibri";
                xlWorkSheetToUpload.Cells[1, 1].Font.Bold = true;
                xlWorkSheetToUpload.Cells[1, 1].Font.Size = 20;
                xlWorkSheetToUpload.Range["A1:E1"].MergeCells = true;

                xlWorkSheetToUpload.Cells[iRowCnt - 1, 1].value = "From Iban";
                xlWorkSheetToUpload.Cells[iRowCnt - 1, 2].value = "To Iban";
                xlWorkSheetToUpload.Cells[iRowCnt - 1, 3].value = "Amount";
                xlWorkSheetToUpload.Cells[iRowCnt - 1, 4].value = "Currency";
                xlWorkSheetToUpload.Cells[iRowCnt - 1, 5].value = "Transaction Date";

                for (var i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    xlWorkSheetToUpload.Cells[iRowCnt, 1].value = dt.Rows[i]["from_iban"];
                    xlWorkSheetToUpload.Cells[iRowCnt, 2].value = dt.Rows[i]["to_iban"];
                    xlWorkSheetToUpload.Cells[iRowCnt, 3].value = dt.Rows[i]["amount"];
                    xlWorkSheetToUpload.Cells[iRowCnt, 4].value = dt.Rows[i]["currency"];
                    xlWorkSheetToUpload.Cells[iRowCnt, 5].value = dt.Rows[i]["transaction_date"];

                    iRowCnt = iRowCnt + 1;
                }
                xlAppToUpload.ActiveCell.Worksheet.Cells[4, 1].AutoFormat(ExcelAutoFormat.xlRangeAutoFormatList2);
                xlAppToUpload = null;

            }
        }
    }
    
}
