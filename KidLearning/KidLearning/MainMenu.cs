using DbLinq.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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
            Console.WriteLine(Directory.GetCurrentDirectory());
            string ConStr = "Data Source=" + Directory.GetCurrentDirectory() +
                            "\\dbHistory.dat;Version=3;";

            var connection = new SQLiteConnection(
                ConStr
                );

            connection.Open();

            var db = new Main(connection, new SqliteVendor());

            var subjects = db.Subjects;
            Console.WriteLine(subjects.Count());
            foreach (Subjects s in subjects.Take(10).ToList())
            {
                Button b = new Button();
                b.Width = 300;
                b.Height = 300;
                b.Margin = new Padding(20);
                b.Text = s.Name;
                flGrSubject.Controls.Add(b);
            }
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
