
namespace Mirage_Bot.Settings_Form
{
    partial class Settings_form
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
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Name", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Hotkey", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Cooldown", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Position", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Color", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Health Potion");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Q");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("4000");
            this.SettingsMenu_mi = new System.Windows.Forms.MenuStrip();
            this.option1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingOptions_listbox = new System.Windows.Forms.ListBox();
            this.ItemPanel_pan = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UIPanel_pan = new System.Windows.Forms.Panel();
            this.UI_B_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.UI_G_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UI_Red_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UI_YPosition_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UI_XPosition_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UI_Name_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SettingsMenu_mi.SuspendLayout();
            this.ItemPanel_pan.SuspendLayout();
            this.UIPanel_pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsMenu_mi
            // 
            this.SettingsMenu_mi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SettingsMenu_mi.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsMenu_mi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option1ToolStripMenuItem,
            this.option2ToolStripMenuItem});
            this.SettingsMenu_mi.Location = new System.Drawing.Point(0, 0);
            this.SettingsMenu_mi.Name = "SettingsMenu_mi";
            this.SettingsMenu_mi.Size = new System.Drawing.Size(126, 459);
            this.SettingsMenu_mi.TabIndex = 5;
            this.SettingsMenu_mi.Text = "Menu";
            this.SettingsMenu_mi.Visible = false;
            // 
            // option1ToolStripMenuItem
            // 
            this.option1ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.option1ToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.option1ToolStripMenuItem.Name = "option1ToolStripMenuItem";
            this.option1ToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.option1ToolStripMenuItem.Text = "option1";
            // 
            // option2ToolStripMenuItem
            // 
            this.option2ToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.option2ToolStripMenuItem.Name = "option2ToolStripMenuItem";
            this.option2ToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.option2ToolStripMenuItem.Text = "option2";
            // 
            // SettingOptions_listbox
            // 
            this.SettingOptions_listbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SettingOptions_listbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingOptions_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SettingOptions_listbox.ForeColor = System.Drawing.Color.Gold;
            this.SettingOptions_listbox.FormattingEnabled = true;
            this.SettingOptions_listbox.ItemHeight = 16;
            this.SettingOptions_listbox.Items.AddRange(new object[] {
            "SKILL 1",
            "SKILL 2",
            "SKILL 3",
            "MANA POTION",
            "HP POTION",
            "FOOD",
            "RUNE",
            "HEALTHBAR",
            "MANABAR",
            "HUNGER",
            "asd",
            "asd",
            "asd",
            "asd",
            "asd",
            "asd"});
            this.SettingOptions_listbox.Location = new System.Drawing.Point(12, 12);
            this.SettingOptions_listbox.Name = "SettingOptions_listbox";
            this.SettingOptions_listbox.Size = new System.Drawing.Size(132, 160);
            this.SettingOptions_listbox.TabIndex = 6;
            this.SettingOptions_listbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ItemPanel_pan
            // 
            this.ItemPanel_pan.Controls.Add(this.textBox3);
            this.ItemPanel_pan.Controls.Add(this.label3);
            this.ItemPanel_pan.Controls.Add(this.textBox2);
            this.ItemPanel_pan.Controls.Add(this.label2);
            this.ItemPanel_pan.Controls.Add(this.textBox1);
            this.ItemPanel_pan.Controls.Add(this.label1);
            this.ItemPanel_pan.Location = new System.Drawing.Point(150, 129);
            this.ItemPanel_pan.Name = "ItemPanel_pan";
            this.ItemPanel_pan.Size = new System.Drawing.Size(268, 111);
            this.ItemPanel_pan.TabIndex = 7;
            this.ItemPanel_pan.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.ForeColor = System.Drawing.Color.Lime;
            this.textBox3.Location = new System.Drawing.Point(92, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 14);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "4000";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cooldown:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(92, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 14);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Q";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hotkey:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(92, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 14);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Mana Potion";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // UIPanel_pan
            // 
            this.UIPanel_pan.Controls.Add(this.UI_B_tb);
            this.UIPanel_pan.Controls.Add(this.label11);
            this.UIPanel_pan.Controls.Add(this.UI_G_tb);
            this.UIPanel_pan.Controls.Add(this.label10);
            this.UIPanel_pan.Controls.Add(this.UI_Red_tb);
            this.UIPanel_pan.Controls.Add(this.label9);
            this.UIPanel_pan.Controls.Add(this.label8);
            this.UIPanel_pan.Controls.Add(this.UI_YPosition_tb);
            this.UIPanel_pan.Controls.Add(this.label7);
            this.UIPanel_pan.Controls.Add(this.UI_XPosition_tb);
            this.UIPanel_pan.Controls.Add(this.label6);
            this.UIPanel_pan.Controls.Add(this.label5);
            this.UIPanel_pan.Controls.Add(this.UI_Name_tb);
            this.UIPanel_pan.Controls.Add(this.label4);
            this.UIPanel_pan.Location = new System.Drawing.Point(150, 12);
            this.UIPanel_pan.Name = "UIPanel_pan";
            this.UIPanel_pan.Size = new System.Drawing.Size(268, 111);
            this.UIPanel_pan.TabIndex = 9;
            this.UIPanel_pan.Visible = false;
            // 
            // UI_B_tb
            // 
            this.UI_B_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UI_B_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_B_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UI_B_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UI_B_tb.ForeColor = System.Drawing.Color.Lime;
            this.UI_B_tb.Location = new System.Drawing.Point(198, 83);
            this.UI_B_tb.Name = "UI_B_tb";
            this.UI_B_tb.Size = new System.Drawing.Size(37, 14);
            this.UI_B_tb.TabIndex = 17;
            this.UI_B_tb.Text = "255";
            this.UI_B_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.BlueViolet;
            this.label11.Location = new System.Drawing.Point(179, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "B:";
            // 
            // UI_G_tb
            // 
            this.UI_G_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UI_G_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_G_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UI_G_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UI_G_tb.ForeColor = System.Drawing.Color.Lime;
            this.UI_G_tb.Location = new System.Drawing.Point(137, 83);
            this.UI_G_tb.Name = "UI_G_tb";
            this.UI_G_tb.Size = new System.Drawing.Size(37, 14);
            this.UI_G_tb.TabIndex = 15;
            this.UI_G_tb.Text = "255";
            this.UI_G_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.BlueViolet;
            this.label10.Location = new System.Drawing.Point(118, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "G:";
            // 
            // UI_Red_tb
            // 
            this.UI_Red_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UI_Red_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_Red_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UI_Red_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UI_Red_tb.ForeColor = System.Drawing.Color.Lime;
            this.UI_Red_tb.Location = new System.Drawing.Point(82, 83);
            this.UI_Red_tb.Name = "UI_Red_tb";
            this.UI_Red_tb.Size = new System.Drawing.Size(37, 14);
            this.UI_Red_tb.TabIndex = 13;
            this.UI_Red_tb.Text = "255";
            this.UI_Red_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.BlueViolet;
            this.label9.Location = new System.Drawing.Point(63, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "R:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(19, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Color:";
            // 
            // UI_YPosition_tb
            // 
            this.UI_YPosition_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UI_YPosition_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_YPosition_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UI_YPosition_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UI_YPosition_tb.ForeColor = System.Drawing.Color.Lime;
            this.UI_YPosition_tb.Location = new System.Drawing.Point(183, 49);
            this.UI_YPosition_tb.Name = "UI_YPosition_tb";
            this.UI_YPosition_tb.Size = new System.Drawing.Size(47, 14);
            this.UI_YPosition_tb.TabIndex = 9;
            this.UI_YPosition_tb.Text = "1234";
            this.UI_YPosition_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(159, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Y:";
            // 
            // UI_XPosition_tb
            // 
            this.UI_XPosition_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UI_XPosition_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_XPosition_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UI_XPosition_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UI_XPosition_tb.ForeColor = System.Drawing.Color.Lime;
            this.UI_XPosition_tb.Location = new System.Drawing.Point(106, 49);
            this.UI_XPosition_tb.Name = "UI_XPosition_tb";
            this.UI_XPosition_tb.Size = new System.Drawing.Size(47, 14);
            this.UI_XPosition_tb.TabIndex = 7;
            this.UI_XPosition_tb.Text = "1234";
            this.UI_XPosition_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(82, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(19, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Position:";
            // 
            // UI_Name_tb
            // 
            this.UI_Name_tb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UI_Name_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UI_Name_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UI_Name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UI_Name_tb.ForeColor = System.Drawing.Color.Lime;
            this.UI_Name_tb.Location = new System.Drawing.Point(94, 18);
            this.UI_Name_tb.Name = "UI_Name_tb";
            this.UI_Name_tb.Size = new System.Drawing.Size(102, 14);
            this.UI_Name_tb.TabIndex = 3;
            this.UI_Name_tb.Text = "Healthbar";
            this.UI_Name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name:";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ForeColor = System.Drawing.Color.Lime;
            listViewGroup11.Header = "Name";
            listViewGroup11.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup11.Name = "Name_lwg";
            listViewGroup12.Header = "Hotkey";
            listViewGroup12.Name = "Hotkey_lwg";
            listViewGroup13.Header = "Cooldown";
            listViewGroup13.Name = "Cooldown_lwg";
            listViewGroup14.Header = "Position";
            listViewGroup14.Name = "Position_lwg";
            listViewGroup15.Header = "Color";
            listViewGroup15.Name = "Color_lwg";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            listViewItem7.Group = listViewGroup11;
            listViewItem8.Group = listViewGroup12;
            listViewItem9.Group = listViewGroup13;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(91, 272);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(149, 150);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // Settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(555, 459);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ItemPanel_pan);
            this.Controls.Add(this.UIPanel_pan);
            this.Controls.Add(this.SettingOptions_listbox);
            this.Controls.Add(this.SettingsMenu_mi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.SettingsMenu_mi;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings_form";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.SettingsMenu_mi.ResumeLayout(false);
            this.SettingsMenu_mi.PerformLayout();
            this.ItemPanel_pan.ResumeLayout(false);
            this.ItemPanel_pan.PerformLayout();
            this.UIPanel_pan.ResumeLayout(false);
            this.UIPanel_pan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip SettingsMenu_mi;
        private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option2ToolStripMenuItem;
        private System.Windows.Forms.ListBox SettingOptions_listbox;
        private System.Windows.Forms.Panel ItemPanel_pan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel UIPanel_pan;
        private System.Windows.Forms.TextBox UI_B_tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox UI_G_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UI_Red_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UI_YPosition_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UI_XPosition_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UI_Name_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
    }
}