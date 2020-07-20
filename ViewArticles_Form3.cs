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
using WindowsServiceSchedularApp;

namespace WindowsFormsApp1
{
    public partial class ViewArticles_Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\JournalAppDB.mdf;Integrated Security=True;Connect Timeout=30");
        public ViewArticles_Form3()
        {
            InitializeComponent();
        }

        private void ViewArticles_Form3_Load(object sender, EventArgs e)
        {
            disp_data();

        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Articles where  IsDeleted = 0 ";//"insert into Articles values( "+UserID+",'" + Title.Text+"','"+Description.Text+"',"+0+")";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            con.Close();






        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
           
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                if (dataGridView1.SelectedRows.Count == 0) { MessageBox.Show("Please select a row."); }
                if (item != null)
                    {
                        

                      
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "Delete from Articles where Articles_Id ='" + id + "'";



                    cmd.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(item.Index);

                    con.Close();



                    
                      
                            MessageBox.Show("Article Deleted successfully.");
                    }
                
            }

            }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                if (dataGridView1.SelectedRows.Count == 0) { MessageBox.Show("Please select a row."); }
                if (item != null)
                {



                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "update  Articles set IsApproved =" + 1 + "where Articles_Id ='" + id + "'";



                    cmd.ExecuteNonQuery();
                   

                    con.Close();





                    MessageBox.Show("Article approved successfully.");
                }

            }
        }
    }
}
