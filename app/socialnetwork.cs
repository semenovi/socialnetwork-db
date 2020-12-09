using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace socialnetwork_app
{
    public partial class socialnetwork : Form
    {
        private db scDb;
        public socialnetwork()
        {
            InitializeComponent();
            scDb = new db("d:\\docs\\edu\\mivlgu\\5_sem\\database\\socialnetwork-local\\db-fb-25\\db.fdb");
            scDb.connect();
        }
        private void connect_Click(object sender, EventArgs e)
        {
            scDb = new db("d:\\docs\\edu\\mivlgu\\5_sem\\database\\socialnetwork-local\\db-fb-25\\db.fdb");
            scDb.connect();
        }

        private void get_columns_Click(object sender, EventArgs e)
        {
            string q = "select RDB$RELATION_NAME from RDB$RELATIONS";
            List<String> r = scDb.query(q);
            foreach(String n in r)
            {
                //outText.Text += n + '\n';
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            
        }

        private void usersSearchButton_Click(object sender, EventArgs e)
        {
            string q = "select RDB$RELATION_NAME from RDB$RELATIONS";
            List<String> r = scDb.query(q);
            foreach (String n in r)
            {
                //outText.Text += n + '\n';
            }
        }

        private void userNameSettingsButton_Click(object sender, EventArgs e)
        {
            string u_name = userNameSettingsText.Text;
            List<String> usersAttributes = new List<String>();
            usersAttributes.Add("U_ID");
            usersAttributes.Add("U_NAME");
            usersAttributes.Add("U_SURNAME");
            usersAttributes.Add("U_MIDDLENAME");
            usersAttributes.Add("U_SEX");
            usersAttributes.Add("U_BIRTHDATE");
            usersAttributes.Add("U_COUNTRY");
            usersAttributes.Add("U_CITY");
            usersAttributes.Add("U_PHONENUMBER");
            usersAttributes.Add("U_AVATAR");
            usersAttributes.Add("U_DESCRIPTION");
            usersAttributes.Add("U_PASSWORD");
            usersAttributes.Add("UD_SEX");
            usersAttributes.Add("UD_BIRTHDATE");
            usersAttributes.Add("UD_AVATAR");
            usersAttributes.Add("UD_FRIENDS");
            usersAttributes.Add("UD_GROUPS");
            usersAttributes.Add("UD_NOTES");
            usersAttributes.Add("UD_MESSAGES");
            usersAttributes.Add("UN_NOTIFICATIONS");
            usersAttributes.Add("UN_SOUNDS");
            usersAttributes.Add("UN_CONTENT");
            List<String> usersValues = new List<String>();
            usersValues.Add("NULL");
            usersValues.Add(u_name);
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            usersValues.Add("NULL");
            scDb.insert("USERS", usersAttributes, usersValues);
        }
    }
}