using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=VIVEK-DELL;Initial Catalog=db1;Integrated Security=true");


            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into  tbl_users(Name,EmailID,DOB,Salary) Values(@name, @emailid,@dob,@salary)", Con);

                cmd.Parameters.AddWithValue("@name",txtusername.Text);
    

                cmd.Parameters.AddWithValue("@emailid",txtemailid.Text);
             // cmd.Parameters.AddWithValue("@password,txtpwd.Text);

                cmd.Parameters.AddWithValue("@dob",dateTimePickerdob.Text);
    

                cmd.Parameters.AddWithValue("@salary",txtsalary.Text);
    

               int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {

                    MessageBox.Show("Row Inserted");
                }
                else
                {
                    MessageBox.Show("Something is wrong");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }

        }
    }
}
