using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //logics on btn clk
            SqlConnection con = new SqlConnection("Data Source=VIVEK-DELL;Initial Catalog=DB1;Integrated Security=true");

            try
            {
                con.Open();
                //Reading Data from DB 
                SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_users",con);


                //  dataGridView1.DataSource = da;//we cannot send da object to datagridview directly 
                //store data in client machine first and then send it to grid view
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show("Data Fetched " );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
