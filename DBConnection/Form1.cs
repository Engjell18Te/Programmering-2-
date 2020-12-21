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

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
        }
       //databas länk
        public string conString = "Data Source=CND8263QR2\\SQL2018;Initial Catalog=Prg2;Integrated Security=True";
        private void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);   
           //öppna länken 
            con.Open();
           
            {
                //gör en string för att hitta inskriven information 
                string q = "Select * from Prg2.dbo.Persons";
                //skicka länken till en kommand object

                    SqlCommand cmd = new SqlCommand(q, con);
                //får svar
                cmd.ExecuteNonQuery();
                //om det är rätt så kommer detta poppa up.
                MessageBox.Show("Login made Successfuly..! ");
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
