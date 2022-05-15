using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Sale_Car
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Load();
        }

       

        
        public void Load()
        {
            OleDbConnection dbCmd = new OleDbConnection();
            dbCmd.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#\School\Proekt_2022\CarDataBase\Database4.mdb;Persist Security Info=True";
            dbCmd.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = dbCmd;

            com.CommandText = "select * from Car";
            var dr = com.ExecuteReader();
            dataGridViewAva.Rows.Clear();
            while (dr.Read())
            {
                dataGridViewAva.Rows.Add(dr[0],dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], dr[10]);
            }
            dbCmd.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewSold.Rows.Clear();
            foreach(DataGridViewRow item in dataGridViewAva.Rows)
            {
                if ((bool)item.Cells[11].Value == true) 
                {
                    int n = dataGridViewSold.Rows.Add();
                    dataGridViewSold.Rows[n].Cells[0].Value = item.Cells[0].Value.ToString();
                    dataGridViewSold.Rows[n].Cells[1].Value = item.Cells[1].Value.ToString();
                    dataGridViewSold.Rows[n].Cells[2].Value = item.Cells[2].Value.ToString();
                    dataGridViewSold.Rows[n].Cells[3].Value = item.Cells[3].Value.ToString();
                    dataGridViewSold.Rows[n].Cells[4].Value = item.Cells[4].Value.ToString();
                    dataGridViewSold.Rows[n].Cells[5].Value = item.Cells[5].Value.ToString();
                    dataGridViewSold.Rows[n].Cells[6].Value = item.Cells[6].Value.ToString();
                    dataGridViewSold.Rows[n].Cells[7].Value = item.Cells[7].Value.ToString();
                    dataGridViewSold.Rows[n].Cells[8].Value = item.Cells[8].Value.ToString();
                    dataGridViewSold.Rows[n].Cells[9].Value = item.Cells[9].Value.ToString();
                    dataGridViewSold.Rows[n].Cells[10].Value = item.Cells[10].Value.ToString();
                }
            }

        }
    }
}
