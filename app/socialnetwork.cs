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

namespace SocialnetworkApp
{
    public partial class Socialnetwork : Form
    {
        private DB scDb;
        public Socialnetwork()
        {
            InitializeComponent();
            scDb = new DB("d:\\docs\\edu\\mivlgu\\5_sem\\database\\socialnetwork-local\\db-fb-25\\db.fdb");
            scDb.Connect();
            usersPageTable.Controls.Find("userNameText", false)[0].Text = "user first and last names";
        }

        private void UsersSearchButton_Click(object sender, EventArgs e)
        {
            string q = "select RDB$RELATION_NAME from RDB$RELATIONS";
            List<String> r = scDb.Query(q);
            foreach (String n in r)
            {
                //outText.Text += n + '\n';
            }
        }

        private void UserNameSettingsButton_Click(object sender, EventArgs e)
        {
            string u_name = userNameSettingsText.Text;
            List<String> usersAttributes = new List<String>
            {
                "U_ID",
                "U_NAME",
                "U_SURNAME",
                "U_MIDDLENAME",
                "U_SEX",
                "U_BIRTHDATE",
                "U_COUNTRY",
                "U_CITY",
                "U_PHONENUMBER",
                "U_AVATAR",
                "U_DESCRIPTION",
                "U_PASSWORD",
                "UD_SEX",
                "UD_BIRTHDATE",
                "UD_AVATAR",
                "UD_FRIENDS",
                "UD_GROUPS",
                "UD_NOTES",
                "UD_MESSAGES",
                "UN_NOTIFICATIONS",
                "UN_SOUNDS",
                "UN_CONTENT"
            };
            List<String> usersValues = new List<String>
            {
                "NULL",
                u_name,
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL",
                "NULL"
            };
            scDb.Insert("USERS", usersAttributes, usersValues);
        }
    }
}