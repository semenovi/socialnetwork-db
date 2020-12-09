﻿namespace socialnetwork_app
{
    partial class socialnetwork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.TabControl();
            this.userPage = new System.Windows.Forms.TabPage();
            this.testButton = new System.Windows.Forms.Button();
            this.friendsPage = new System.Windows.Forms.TabPage();
            this.groupsPage = new System.Windows.Forms.TabPage();
            this.searchPage = new System.Windows.Forms.TabPage();
            this.searchTabs = new System.Windows.Forms.TabControl();
            this.usersSearchPage = new System.Windows.Forms.TabPage();
            this.usersSearchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupsSearchPage = new System.Windows.Forms.TabPage();
            this.groupsSearchButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.docsSearchPage = new System.Windows.Forms.TabPage();
            this.docsSearchButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.docsPage = new System.Windows.Forms.TabPage();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.docsSearchList = new System.Windows.Forms.ListView();
            this.groupsSearchList = new System.Windows.Forms.ListView();
            this.usersSearchList = new System.Windows.Forms.ListView();
            this.userNameSettingsText = new System.Windows.Forms.TextBox();
            this.userNameSettingsButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabs.SuspendLayout();
            this.userPage.SuspendLayout();
            this.searchPage.SuspendLayout();
            this.searchTabs.SuspendLayout();
            this.usersSearchPage.SuspendLayout();
            this.groupsSearchPage.SuspendLayout();
            this.docsSearchPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.userPage);
            this.tabs.Controls.Add(this.friendsPage);
            this.tabs.Controls.Add(this.groupsPage);
            this.tabs.Controls.Add(this.searchPage);
            this.tabs.Controls.Add(this.docsPage);
            this.tabs.Controls.Add(this.settingsPage);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(0);
            this.tabs.Name = "tabs";
            this.tabs.Padding = new System.Drawing.Point(0, 0);
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(352, 306);
            this.tabs.TabIndex = 1;
            // 
            // userPage
            // 
            this.userPage.Controls.Add(this.richTextBox1);
            this.userPage.Controls.Add(this.testButton);
            this.userPage.Location = new System.Drawing.Point(4, 22);
            this.userPage.Name = "userPage";
            this.userPage.Size = new System.Drawing.Size(344, 280);
            this.userPage.TabIndex = 0;
            this.userPage.Text = "page";
            this.userPage.UseVisualStyleBackColor = true;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(8, 12);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "аааааааааааа";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // friendsPage
            // 
            this.friendsPage.Location = new System.Drawing.Point(4, 22);
            this.friendsPage.Name = "friendsPage";
            this.friendsPage.Size = new System.Drawing.Size(344, 280);
            this.friendsPage.TabIndex = 1;
            this.friendsPage.Text = "friends";
            this.friendsPage.UseVisualStyleBackColor = true;
            // 
            // groupsPage
            // 
            this.groupsPage.Location = new System.Drawing.Point(4, 22);
            this.groupsPage.Name = "groupsPage";
            this.groupsPage.Size = new System.Drawing.Size(344, 280);
            this.groupsPage.TabIndex = 2;
            this.groupsPage.Text = "groups";
            this.groupsPage.UseVisualStyleBackColor = true;
            // 
            // searchPage
            // 
            this.searchPage.Controls.Add(this.searchTabs);
            this.searchPage.Location = new System.Drawing.Point(4, 22);
            this.searchPage.Name = "searchPage";
            this.searchPage.Size = new System.Drawing.Size(344, 280);
            this.searchPage.TabIndex = 3;
            this.searchPage.Text = "search";
            this.searchPage.UseVisualStyleBackColor = true;
            // 
            // searchTabs
            // 
            this.searchTabs.Controls.Add(this.usersSearchPage);
            this.searchTabs.Controls.Add(this.groupsSearchPage);
            this.searchTabs.Controls.Add(this.docsSearchPage);
            this.searchTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTabs.Location = new System.Drawing.Point(0, 0);
            this.searchTabs.Name = "searchTabs";
            this.searchTabs.SelectedIndex = 0;
            this.searchTabs.Size = new System.Drawing.Size(344, 280);
            this.searchTabs.TabIndex = 0;
            // 
            // usersSearchPage
            // 
            this.usersSearchPage.Controls.Add(this.usersSearchList);
            this.usersSearchPage.Controls.Add(this.usersSearchButton);
            this.usersSearchPage.Controls.Add(this.textBox1);
            this.usersSearchPage.Location = new System.Drawing.Point(4, 22);
            this.usersSearchPage.Name = "usersSearchPage";
            this.usersSearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersSearchPage.Size = new System.Drawing.Size(336, 254);
            this.usersSearchPage.TabIndex = 0;
            this.usersSearchPage.Text = "users";
            this.usersSearchPage.UseVisualStyleBackColor = true;
            // 
            // usersSearchButton
            // 
            this.usersSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersSearchButton.Location = new System.Drawing.Point(3, 23);
            this.usersSearchButton.Name = "usersSearchButton";
            this.usersSearchButton.Size = new System.Drawing.Size(330, 23);
            this.usersSearchButton.TabIndex = 1;
            this.usersSearchButton.Text = "search";
            this.usersSearchButton.UseVisualStyleBackColor = true;
            this.usersSearchButton.Click += new System.EventHandler(this.usersSearchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupsSearchPage
            // 
            this.groupsSearchPage.Controls.Add(this.groupsSearchList);
            this.groupsSearchPage.Controls.Add(this.groupsSearchButton);
            this.groupsSearchPage.Controls.Add(this.textBox2);
            this.groupsSearchPage.Location = new System.Drawing.Point(4, 22);
            this.groupsSearchPage.Name = "groupsSearchPage";
            this.groupsSearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupsSearchPage.Size = new System.Drawing.Size(336, 254);
            this.groupsSearchPage.TabIndex = 1;
            this.groupsSearchPage.Text = "groups";
            this.groupsSearchPage.UseVisualStyleBackColor = true;
            // 
            // groupsSearchButton
            // 
            this.groupsSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupsSearchButton.Location = new System.Drawing.Point(3, 23);
            this.groupsSearchButton.Name = "groupsSearchButton";
            this.groupsSearchButton.Size = new System.Drawing.Size(330, 23);
            this.groupsSearchButton.TabIndex = 1;
            this.groupsSearchButton.Text = "search";
            this.groupsSearchButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 20);
            this.textBox2.TabIndex = 0;
            // 
            // docsSearchPage
            // 
            this.docsSearchPage.Controls.Add(this.docsSearchList);
            this.docsSearchPage.Controls.Add(this.docsSearchButton);
            this.docsSearchPage.Controls.Add(this.textBox3);
            this.docsSearchPage.Location = new System.Drawing.Point(4, 22);
            this.docsSearchPage.Name = "docsSearchPage";
            this.docsSearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.docsSearchPage.Size = new System.Drawing.Size(336, 254);
            this.docsSearchPage.TabIndex = 2;
            this.docsSearchPage.Text = "docs";
            this.docsSearchPage.UseVisualStyleBackColor = true;
            // 
            // docsSearchButton
            // 
            this.docsSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.docsSearchButton.Location = new System.Drawing.Point(3, 23);
            this.docsSearchButton.Name = "docsSearchButton";
            this.docsSearchButton.Size = new System.Drawing.Size(330, 23);
            this.docsSearchButton.TabIndex = 1;
            this.docsSearchButton.Text = "search";
            this.docsSearchButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(330, 20);
            this.textBox3.TabIndex = 0;
            // 
            // docsPage
            // 
            this.docsPage.Location = new System.Drawing.Point(4, 22);
            this.docsPage.Name = "docsPage";
            this.docsPage.Size = new System.Drawing.Size(344, 280);
            this.docsPage.TabIndex = 4;
            this.docsPage.Text = "docs";
            this.docsPage.UseVisualStyleBackColor = true;
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.userNameSettingsButton);
            this.settingsPage.Controls.Add(this.userNameSettingsText);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(344, 280);
            this.settingsPage.TabIndex = 5;
            this.settingsPage.Text = "settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // docsSearchList
            // 
            this.docsSearchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docsSearchList.Location = new System.Drawing.Point(3, 46);
            this.docsSearchList.Name = "docsSearchList";
            this.docsSearchList.Size = new System.Drawing.Size(330, 205);
            this.docsSearchList.TabIndex = 2;
            this.docsSearchList.UseCompatibleStateImageBehavior = false;
            // 
            // groupsSearchList
            // 
            this.groupsSearchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsSearchList.Location = new System.Drawing.Point(3, 46);
            this.groupsSearchList.Name = "groupsSearchList";
            this.groupsSearchList.Size = new System.Drawing.Size(330, 205);
            this.groupsSearchList.TabIndex = 2;
            this.groupsSearchList.UseCompatibleStateImageBehavior = false;
            // 
            // usersSearchList
            // 
            this.usersSearchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersSearchList.Location = new System.Drawing.Point(3, 46);
            this.usersSearchList.Name = "usersSearchList";
            this.usersSearchList.Size = new System.Drawing.Size(330, 205);
            this.usersSearchList.TabIndex = 2;
            this.usersSearchList.UseCompatibleStateImageBehavior = false;
            // 
            // userNameSettingsText
            // 
            this.userNameSettingsText.Dock = System.Windows.Forms.DockStyle.Top;
            this.userNameSettingsText.Location = new System.Drawing.Point(0, 0);
            this.userNameSettingsText.Name = "userNameSettingsText";
            this.userNameSettingsText.Size = new System.Drawing.Size(344, 20);
            this.userNameSettingsText.TabIndex = 0;
            // 
            // userNameSettingsButton
            // 
            this.userNameSettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userNameSettingsButton.Location = new System.Drawing.Point(0, 20);
            this.userNameSettingsButton.Name = "userNameSettingsButton";
            this.userNameSettingsButton.Size = new System.Drawing.Size(344, 23);
            this.userNameSettingsButton.TabIndex = 1;
            this.userNameSettingsButton.Text = "change";
            this.userNameSettingsButton.UseVisualStyleBackColor = true;
            this.userNameSettingsButton.Click += new System.EventHandler(this.userNameSettingsButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 206);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // socialnetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 306);
            this.Controls.Add(this.tabs);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(282, 345);
            this.Name = "socialnetwork";
            this.Text = "socialnetwork";
            this.tabs.ResumeLayout(false);
            this.userPage.ResumeLayout(false);
            this.searchPage.ResumeLayout(false);
            this.searchTabs.ResumeLayout(false);
            this.usersSearchPage.ResumeLayout(false);
            this.usersSearchPage.PerformLayout();
            this.groupsSearchPage.ResumeLayout(false);
            this.groupsSearchPage.PerformLayout();
            this.docsSearchPage.ResumeLayout(false);
            this.docsSearchPage.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage userPage;
        private System.Windows.Forms.TabPage friendsPage;
        private System.Windows.Forms.TabPage groupsPage;
        private System.Windows.Forms.TabPage searchPage;
        private System.Windows.Forms.TabPage docsPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TabControl searchTabs;
        private System.Windows.Forms.TabPage usersSearchPage;
        private System.Windows.Forms.TabPage groupsSearchPage;
        private System.Windows.Forms.TabPage docsSearchPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button groupsSearchButton;
        private System.Windows.Forms.Button docsSearchButton;
        private System.Windows.Forms.Button usersSearchButton;
        private System.Windows.Forms.ListView docsSearchList;
        private System.Windows.Forms.ListView usersSearchList;
        private System.Windows.Forms.ListView groupsSearchList;
        private System.Windows.Forms.Button userNameSettingsButton;
        private System.Windows.Forms.TextBox userNameSettingsText;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

