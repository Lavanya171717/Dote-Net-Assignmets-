using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using EFAssignment2.Models;

namespace EFAssignment2
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=Training;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            TrainingContext db = new TrainingContext();
            string Username = txtUserName.Text;
            string password = txtPassword.Text;

            Userdatum user = db.Userdata.SingleOrDefault(e => e.Username == Username && e.Password == password);
            if (user != null)
            {
                lblMsg.Text = "Valid user";
            }
            else
            {
                lblMsg.Text = "Invalid user";
            }
        }
    }
}
