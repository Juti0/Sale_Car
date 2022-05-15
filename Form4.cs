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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Load();
        }

        private void add_Click(object sender, EventArgs e)
        {
            OleDbConnection dbCmd = new OleDbConnection();
            dbCmd.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#\School\Proekt_2022\CarDataBase\Database4.mdb;Persist Security Info=True";
            dbCmd.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = dbCmd;

            com.CommandText = "INSERT INTO Customer(FirstName,LastName,Phone,Address) Values('" + nameFirst.Text + "', " +
                "'" + nameLast.Text + "'," +
                "'" + phoneCus.Text + "'," +
                "'" + adresCus.Text + "')";
            com.ExecuteNonQuery();
            MessageBox.Show("Your Data is inserted successfully");



            dbCmd.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            nameFirst.Clear();
            nameLast.Clear();
            phoneCus.Clear();
            adresCus.Clear();
            nameFirst.Focus();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            this.Hide();
            m.Show();
        }
        public void Load()
        {
            OleDbConnection dbCmd = new OleDbConnection();
            dbCmd.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#\School\Proekt_2022\CarDataBase\Database4.mdb;Persist Security Info=True";
            dbCmd.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = dbCmd;

            com.CommandText = "select * from Customer";
            var dr = com.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            dbCmd.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                CusId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                nameFirst.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                nameLast.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                phoneCus.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                adresCus.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
            }
            if (e.ColumnIndex == 6)
            {
                OleDbConnection dbCmd = new OleDbConnection();
                dbCmd.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#\School\Proekt_2022\CarDataBase\Database4.mdb;Persist Security Info=True";
                dbCmd.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = dbCmd;

                com.CommandText = "UPDATE Customer SET FirstName='" + nameFirst.Text + "',LastName='" + nameLast.Text + "',Phone='" + phoneCus.Text + "',Address='" + adresCus.Text + "'WHERE Id=" + CusId.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Your Data is updated successfully");
                CusId.Text = "";
                nameFirst.Text = "";
                nameLast.Text = "";
                phoneCus.Text = "";
                adresCus.Text = "";
            }
            if (e.ColumnIndex == 7)
            {
                OleDbConnection dbCmd = new OleDbConnection();
                dbCmd.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#\School\Proekt_2022\CarDataBase\Database4.mdb;Persist Security Info=True";
                dbCmd.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = dbCmd;

                com.CommandText = "DELETE FROM Car WHERE Id=" + CusId.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Your Data is deleted successfully");
                CusId.Text = "";
                nameFirst.Text = "";
                nameLast.Text = "";
                phoneCus.Text = "";
                adresCus.Text = "";
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            OleDbConnection dbCmd = new OleDbConnection();
            dbCmd.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#\School\Proekt_2022\CarDataBase\Database4.mdb;Persist Security Info=True";
            dbCmd.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = dbCmd;

            com.CommandText = "select * from Customer";
            var dr = com.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            dbCmd.Close();
        }
    }
}
