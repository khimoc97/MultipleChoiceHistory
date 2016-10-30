using DbLinq.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidLearning
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        /*public static void GetData()
        {
            string ConStr = "Data Source=" +
          HttpContext.Current.Server.MapPath("App_Data\\PersonalExpenseDB.s3db") +
                            ";Version=3;";

            var connection = new SQLiteConnection(
                ConStr
                );

            connection.Open();

            var db = new Main(connection, new SqliteVendor());

            var users = db.User;

            var item = users.Take(10).ToList();
        }*/
    }
}
