namespace SocialnetworkApp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using FirebirdSql.Data.FirebirdClient;

    public partial class Socialnetwork : Form
    {
        private readonly DB scDb;
        private string mode;
        private string userId;
        public Socialnetwork()
        {
            InitializeComponent();

            Icon = Properties.Resources.ico;

            scDb = new DB("d:\\docs\\edu\\mivlgu\\5_sem\\database\\socialnetwork-local\\db-fb-25\\db.fdb");
            scDb.Connect();
            userId = "";
            // usersPageTable.Controls.Find("userNameText", false)[0].Text = "user first and last names";

            _ = SetMode("login-register");
        }

        private int SetMode(string _mode)
        {
            switch(_mode)
            {
                case "login-register":
                    userButton.Enabled = false;
                    messagesButton.Enabled = false;
                    friendsButton.Enabled = false;
                    groupsButton.Enabled = false;
                    docsButton.Enabled = false;
                    searchButton.Enabled = false;
                    viewButton.Enabled = false;
                    settingsButton.Enabled = false;
                    userPanel.Visible = false;
                    messagesPanel.Visible = false;
                    friendsPanel.Visible = false;
                    groupsPanel.Visible = false;
                    docsPanel.Visible = false;
                    searchPanel.Visible = false;
                    viewPanel.Visible = false;
                    settingsPanel.Visible = true;
                    settingsLoginPanel.Visible = true;
                    settingsRegisterPanel.Visible = true;
                    settingsPrivacyPanel.Visible = false;
                    settingsBehaviorPanel.Visible = false;
                    currentHeaderLabel.Text = "войдите или зарегистируйтесь";
                    mode = _mode;
                    return 0;
                case "logged-in":
                    userButton.Enabled = true;
                    messagesButton.Enabled = true;
                    friendsButton.Enabled = true;
                    groupsButton.Enabled = true;
                    docsButton.Enabled = true;
                    searchButton.Enabled = true;
                    viewButton.Enabled = true;
                    settingsButton.Enabled = true;
                    userPanel.Visible = true;
                    messagesPanel.Visible = true;
                    friendsPanel.Visible = true;
                    groupsPanel.Visible = true;
                    docsPanel.Visible = true;
                    searchPanel.Visible = true;
                    viewPanel.Visible = true;
                    settingsPanel.Visible = true;
                    settingsLoginPanel.Visible = false;
                    settingsRegisterPanel.Visible = false;
                    settingsPrivacyPanel.Visible = true;
                    settingsBehaviorPanel.Visible = true;
                    if (userId == "")
                    {
                        currentHeaderLabel.Text = "добро пожаловать";
                    }
                    else
                    {
                        currentHeaderLabel.Text = "добро пожаловать, " + userId;
                    }
                    mode = _mode;
                    return 0;
                default:
                    return -1;
            }
        }

        private void UsersSearchButton_Click(object sender, EventArgs e)
        {
            string q = "select RDB$RELATION_NAME from RDB$RELATIONS";
            List<string> r = scDb.Query(q);
            foreach (string n in r)
            {
                //outText.Text += n + '\n';
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            userPanel.BringToFront();
            currentHeaderLabel.Text = "личная страница";
        }

        private void messagesButton_Click(object sender, EventArgs e)
        {
            messagesPanel.BringToFront();
            currentHeaderLabel.Text = "сообщения";
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            friendsPanel.BringToFront();
            currentHeaderLabel.Text = "друзья";
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            groupsPanel.BringToFront();
            currentHeaderLabel.Text = "группы";
        }

        private void docsButton_Click(object sender, EventArgs e)
        {
            docsPanel.BringToFront();
            currentHeaderLabel.Text = "файлы";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchPanel.BringToFront();
            currentHeaderLabel.Text = "поиск";
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            viewPanel.BringToFront();
            currentHeaderLabel.Text = "обзор страниц";
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsPanel.BringToFront();
            currentHeaderLabel.Text = "настройки";
        }

        private void settingsRegisterConfirmButton_Click(object sender, EventArgs e)
        {
            if (settingsRegisterNameText.Text.Trim() == "")
            {
                currentHeaderLabel.Text = "введите имя";
            }
            else
            {
                if (settingsRegisterPasswordText.Text.Trim() == "")
                {
                    currentHeaderLabel.Text = "введите пароль";
                }
                else
                {
                    byte[] bytes = new byte[4];
                    RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                    rng.GetBytes(bytes);
                    string newId = BitConverter.ToString(bytes).Replace("-", "").ToLower();

                    userId = newId;
                    settingsRegisterIdText.Text = userId;

                    List<string> classAtributes = new List<string> { "ID", "CLASS" };
                    List<string> classValues = new List<string> { newId, "u" };

                    string id = scDb.GetIdInsert("ID_CLASSES", classAtributes, classValues, "ID");
                    string s;
                    if (settingsRegisterSexCheck.Checked)
                    {
                        s = "m";
                    }
                    else
                    {
                        s = "f";
                    }
                    List<string> usersAttributes = new List<string>
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
                    List<string> usersValues = new List<string>
                    {
                        id,
                        settingsRegisterNameText.Text,
                        settingsRegisterSurnameText.Text,
                        settingsRegisterMiddlenameText.Text,
                        s,
                        settingsRegisterBirthdayPicker.Value.ToString("dd.MM.yyyy"),
                        settingsRegisterCountryText.Text,
                        settingsRegisterCityText.Text,
                        settingsRegisterPhoneText.Text,
                        openFileDialog.FileName,
                        settingsRegisterDescriptionText.Text,
                        settingsRegisterPasswordText.Text,
                        "n",
                        "n",
                        "n",
                        "n",
                        "n",
                        "n",
                        "n",
                        "n",
                        "n",
                        "n"
                    };
                    _ = scDb.Insert("USERS", usersAttributes, usersValues);
                    settingsRegisterIdText.ResetText();
                    settingsRegisterNameText.ResetText();
                    settingsRegisterSurnameText.ResetText();
                    settingsRegisterMiddlenameText.ResetText();
                    settingsRegisterBirthdayPicker.ResetText();
                    settingsRegisterCountryText.ResetText();
                    settingsRegisterCityText.ResetText();
                    settingsRegisterPhoneText.ResetText();
                    settingsRegisterDescriptionText.ResetText();
                    settingsRegisterPasswordText.ResetText();
                    openFileDialog.Reset();
                    _ = SetMode("logged-in");
                }
            }
        }

        private void settingsLoginButton_Click(object sender, EventArgs e)
        {
            string resultId = scDb.Query("SELECT u_id FROM users WHERE u_id='" + settingsLoginIdText.Text + "'")[0];
            string resultPassword = "";
            if (settingsLoginIdText.Text == resultId)
            {
                resultPassword = scDb.Query("SELECT u_password FROM users WHERE u_id='" + resultId + "'")[0];
                if (settingsLoginPasswordText.Text == resultPassword)
                {
                    settingsLoginPasswordText.Text = "";
                    settingsLoginIdText.Text = "";
                    _ = SetMode("logged-in");
                }
                else
                {
                    currentHeaderLabel.Text = "неверный пароль";
                    settingsLoginPasswordText.Text = "";
                }
            }
            else
            {
                currentHeaderLabel.Text = "пользователь не существует";
                settingsLoginIdText.Text = "";
            }
            
        }

        private void settingsPrivacyLogoutButton_Click(object sender, EventArgs e)
        {
            _ = SetMode("login-register");
        }

        private void settingsRegisterAvatarButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                settingsRegisterAvatarButton.Text = "загружен";
                string filename = openFileDialog.FileName;
                settingsRegisterAvatarPicture.Image = Image.FromFile(filename);
            }
        }
    }
}
