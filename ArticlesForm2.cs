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
using System.Configuration;
using System.Data.Entity.Infrastructure;

using System.IO;

using System.Data.Entity;
namespace WindowsFormsApp1
{
    public partial class ArticlesForm2 : Form
    {
        User userdata = new User();
        Article arts = new Article();
        public ArticlesForm2( string username)
        {

            userdata.Username = username;

                InitializeComponent();
            Author.Text = username;
            Author.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ViewArticles_Form3 f3 = new ViewArticles_Form3();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            arts.Title = Title.Text;
            arts.description = Description.Text;


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\JournalAppDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
             SqlCommand cmd0 = con.CreateCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select UserId from Users where Username ='" + userdata.Username + "'";//"insert into Articles values( "+UserID+",'" + Title.Text+"','"+Description.Text+"',"+0+")";
            
            object result = cmd0.ExecuteScalar();

            //string Userid = result.ToString();
            int User_Id = (int)result;
            arts.User_id = User_Id;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Articles(User_id,Title,description) VALUES(" + User_Id + ",'" + Title.Text + "','" + Description.Text + "')";//"insert into Articles values( "+UserID+",'" + Title.Text+"','"+Description.Text+"',"+0+")";
            cmd.ExecuteNonQuery();
            con.Close();

            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Myconnectionstring"].ConnectionString;

            //conn.Open();
            //    conn.


            //var UserID = 1;

            //SqlCommand cmd0 = con.CreateCommand();
            //cmd0.CommandType = CommandType.Text;
            //cmd0.CommandText = "select NumOfArticles from Users where UserId ="+ UserID + "";//"insert into Articles values( "+UserID+",'" + Title.Text+"','"+Description.Text+"',"+0+")";
            //cmd0.ExecuteNonQuery();

            //string NumOfArticles = cmd0.CommandText.ToString();
            //SqlCommand cmd1 = con.CreateCommand();
            //cmd1.CommandType = CommandType.Text;
            //cmd1.CommandText = "Update Users set NumOfArticles =" + "";//"insert into Articles values( "+UserID+",'" + Title.Text+"','"+Description.Text+"',"+0+")";
            //cmd1.ExecuteNonQuery();
            //con.Close();
            MessageBox.Show("Article posted successfully.");
            this.Hide();
            string username = "";
            ArticlesForm2 f2 = new ArticlesForm2(username);
            f2.ShowDialog();
        }

        private void Author_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
