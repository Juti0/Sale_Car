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
    public partial class Form3 : Form
    {
        public Form3()
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

                com.CommandText = "INSERT INTO Car(coupe,mark,mode,fuel,gearBox,price,years,color,power,extras) Values('" + coupe.Text + "', " +
                    "'" + mark.Text + "'," +
                    "'" + model.Text + "'," +
                    "'" + fuel.Text + "'," +
                    "'" + gearbox.Text + "'," +
                    "'" + price.Text + "'," +
                    "'" + year.Text + "'," +
                    "'" + color.Text + "'," +
                    "'" + power.Text + "'," +
                    "'" + extras.Text + "')";
                com.ExecuteNonQuery();
                MessageBox.Show("Your Data is inserted successfully");
                
           

            dbCmd.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            id.Clear();
            coupe.Clear();
            mark.Clear();
            model.Clear();
            fuel.Clear();
            gearbox.Clear();
            price.Clear();
            year.Clear();
            color.Clear();
            power.Clear();
            extras.Clear();
            id.Focus();
        }

        public void Load()
        {
            OleDbConnection dbCmd = new OleDbConnection();
            dbCmd.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#\School\Proekt_2022\CarDataBase\Database4.mdb;Persist Security Info=True";
            dbCmd.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = dbCmd;

            com.CommandText = "select * from Car";
            var dr=com.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9],dr[10]);
            }
            dbCmd.Close();
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            this.Hide();
            m.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
                if (e.ColumnIndex==11)
                {
                    id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    coupe.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    mark.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    model.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    fuel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    gearbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    price.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    year.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    color.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    power.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    extras.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                }
            if (e.ColumnIndex == 12)
            {
                OleDbConnection dbCmd = new OleDbConnection();
                dbCmd.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#\School\Proekt_2022\CarDataBase\Database4.mdb;Persist Security Info=True";
                dbCmd.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = dbCmd;

                com.CommandText = "UPDATE Car SET coupe='" + coupe.Text + "',mark='" + mark.Text + "',mode='" + model.Text + "',fuel='" + fuel.Text + "',gearBox='" + gearbox.Text + "',price='" + price.Text + "',years='" + year.Text + "',color='" + color.Text + "',power='" + power.Text + "',extras='" + extras.Text + "'WHERE Id=" + id.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Your Data is updated successfully");
                id.Text = "";
                coupe.Text = "";
                mark.Text = "";
                model.Text = "";
                fuel.Text = "";
                gearbox.Text = "";
                price.Text = "";
                year.Text = "";
                color.Text = "";
                power.Text = "";
                extras.Text = "";

            }
            if (e.ColumnIndex == 13)
            {
                OleDbConnection dbCmd = new OleDbConnection();
                dbCmd.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#\School\Proekt_2022\CarDataBase\Database4.mdb;Persist Security Info=True";
                dbCmd.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = dbCmd;

                com.CommandText = "DELETE FROM Car WHERE Id=" + id.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("Your Data is deleted successfully");
                id.Text = "";
                coupe.Text = "";
                mark.Text = "";
                model.Text = "";
                fuel.Text = "";
                gearbox.Text = "";
                price.Text = "";
                year.Text = "";
                color.Text = "";
                power.Text = "";
                extras.Text = "";
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            OleDbConnection dbCmd = new OleDbConnection();
            dbCmd.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\C#\School\Proekt_2022\CarDataBase\Database4.mdb;Persist Security Info=True";
            dbCmd.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = dbCmd;

            com.CommandText = "select * from Car";
            var dr = com.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4],dr[5],dr[6],dr[7],dr[8],dr[9],dr[10]);
            }
            dbCmd.Close();
        }
    }
}
