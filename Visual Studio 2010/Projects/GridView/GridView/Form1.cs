using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=Items; user ID=sa; Password=Password@123";
            string querystring = "Select * from items";

            SqlDataAdapter adapter = new SqlDataAdapter(querystring, ConString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Items");
            dataGridView1.DataSource = ds.Tables["items"]; ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'itemsDataSet.Items' table. You can move, or remove it, as needed.
            //this.itemsTableAdapter.Fill(this.itemsDataSet.Items);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=Items; user ID=sa; Password=Password@123";
            string querystring = "Select * from items";

            SqlDataAdapter adapter = new SqlDataAdapter(querystring, ConString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Items");

            ds.Tables["Items"].Rows[1]["name"] = "shub";

            dataGridView1.DataSource = ds.Tables["Items"];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=Items; user ID=sa; Password=Password@123";
            string querystring = "Select * from items";

            SqlDataAdapter adapter = new SqlDataAdapter(querystring, ConString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Items");

            DataRow row = ds.Tables["Items"].NewRow();
            row["Name"]="vinu";
            row["address"]="Hubli";
                ds.Tables["Items"].Rows.Add(row);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds.Tables["Items"]);

                MessageBox.Show("Dataset saved");

                dataGridView1.DataSource=ds.Tables["Items"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source=DESKTOP-AC4AK63;Initial Catalog=Items; user ID=sa; Password=Password@123";
            string querystring = "Select * from items";

            SqlDataAdapter adapter = new SqlDataAdapter(querystring, ConString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Items");

            DataRow row = ds.Tables["Items"].NewRow();
            row["Name"] = "vinu";
            row["address"] = "Hubli";
            ds.Tables["Items"].Rows[1].Delete();

           
            dataGridView1.DataSource = ds.Tables["Items"];

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        }

        
    }

