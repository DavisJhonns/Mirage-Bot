
namespace Mirage_Bot
{
    partial class MirageBotUI_form
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
            this.components = new System.ComponentModel.Container();
            this.Hp_btn = new System.Windows.Forms.Button();
            this.Mana_btn = new System.Windows.Forms.Button();
            this.Rune_btn = new System.Windows.Forms.Button();
            this.Time_lb = new System.Windows.Forms.Label();
            this.Operator_btn = new System.Windows.Forms.Button();
            this.Duration_timer = new System.Windows.Forms.Timer(this.components);
            this.MainMenu_ms = new System.Windows.Forms.MenuStrip();
            this.Help_mi = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_mi = new System.Windows.Forms.ToolStripMenuItem();
            this.Timers_mi = new System.Windows.Forms.ToolStripMenuItem();
            this.Skill1_btn = new System.Windows.Forms.Button();
            this.Skill2_btn = new System.Windows.Forms.Button();
            this.Skill3_btn = new System.Windows.Forms.Button();
            this.Food_btn = new System.Windows.Forms.Button();
            this.MainMenu_ms.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hp_btn
            // 
            this.Hp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hp_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.Hp_btn.Location = new System.Drawing.Point(7, 61);
            this.Hp_btn.Name = "Hp_btn";
            this.Hp_btn.Size = new System.Drawing.Size(85, 25);
            this.Hp_btn.TabIndex = 0;
            this.Hp_btn.Tag = "healthpotion";
            this.Hp_btn.Text = "HP";
            this.Hp_btn.UseVisualStyleBackColor = true;
            this.Hp_btn.Click += new System.EventHandler(this.Scrpit_Buttons_Click);
            // 
            // Mana_btn
            // 
            this.Mana_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mana_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.Mana_btn.Location = new System.Drawing.Point(95, 61);
            this.Mana_btn.Name = "Mana_btn";
            this.Mana_btn.Size = new System.Drawing.Size(85, 25);
            this.Mana_btn.TabIndex = 1;
            this.Mana_btn.Tag = "manapotion";
            this.Mana_btn.Text = "MANA";
            this.Mana_btn.UseVisualStyleBackColor = true;
            this.Mana_btn.Click += new System.EventHandler(this.Scrpit_Buttons_Click);
            // 
            // Rune_btn
            // 
            this.Rune_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rune_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.Rune_btn.Location = new System.Drawing.Point(7, 122);
            this.Rune_btn.Name = "Rune_btn";
            this.Rune_btn.Size = new System.Drawing.Size(85, 25);
            this.Rune_btn.TabIndex = 5;
            this.Rune_btn.Tag = "rune";
            this.Rune_btn.Text = "RUNE";
            this.Rune_btn.UseVisualStyleBackColor = true;
            this.Rune_btn.Click += new System.EventHandler(this.Scrpit_Buttons_Click);
            // 
            // Time_lb
            // 
            this.Time_lb.AutoSize = true;
            this.Time_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Time_lb.ForeColor = System.Drawing.Color.Gold;
            this.Time_lb.Location = new System.Drawing.Point(9, 28);
            this.Time_lb.Name = "Time_lb";
            this.Time_lb.Size = new System.Drawing.Size(90, 25);
            this.Time_lb.TabIndex = 3;
            this.Time_lb.Text = "00:00:00";
            // 
            // Operator_btn
            // 
            this.Operator_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Operator_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Operator_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.Operator_btn.Location = new System.Drawing.Point(105, 28);
            this.Operator_btn.Name = "Operator_btn";
            this.Operator_btn.Size = new System.Drawing.Size(75, 25);
            this.Operator_btn.TabIndex = 4;
            this.Operator_btn.Text = "Start";
            this.Operator_btn.UseVisualStyleBackColor = true;
            this.Operator_btn.Click += new System.EventHandler(this.Operator_btn_Click);
            // 
            // Duration_timer
            // 
            this.Duration_timer.Interval = 500;
            this.Duration_timer.Tick += new System.EventHandler(this.Duration_Timer_Tick);
            // 
            // MainMenu_ms
            // 
            this.MainMenu_ms.BackColor = System.Drawing.Color.Black;
            this.MainMenu_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help_mi,
            this.Settings_mi,
            this.Timers_mi});
            this.MainMenu_ms.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_ms.Name = "MainMenu_ms";
            this.MainMenu_ms.Size = new System.Drawing.Size(186, 24);
            this.MainMenu_ms.TabIndex = 5;
            this.MainMenu_ms.Text = "Menu";
            // 
            // Help_mi
            // 
            this.Help_mi.ForeColor = System.Drawing.Color.Gold;
            this.Help_mi.Name = "Help_mi";
            this.Help_mi.Size = new System.Drawing.Size(49, 20);
            this.Help_mi.Text = "Help?";
            // 
            // Settings_mi
            // 
            this.Settings_mi.ForeColor = System.Drawing.Color.Gold;
            this.Settings_mi.Name = "Settings_mi";
            this.Settings_mi.Size = new System.Drawing.Size(61, 20);
            this.Settings_mi.Text = "Settings";
            this.Settings_mi.Click += new System.EventHandler(this.Settings_mi_Click);
            // 
            // Timers_mi
            // 
            this.Timers_mi.ForeColor = System.Drawing.Color.Gold;
            this.Timers_mi.Name = "Timers_mi";
            this.Timers_mi.Size = new System.Drawing.Size(54, 20);
            this.Timers_mi.Text = "Timers";
            // 
            // Skill1_btn
            // 
            this.Skill1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skill1_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.Skill1_btn.Location = new System.Drawing.Point(7, 91);
            this.Skill1_btn.Name = "Skill1_btn";
            this.Skill1_btn.Size = new System.Drawing.Size(55, 25);
            this.Skill1_btn.TabIndex = 2;
            this.Skill1_btn.Tag = "skill1";
            this.Skill1_btn.Text = "SKILL 1";
            this.Skill1_btn.UseVisualStyleBackColor = true;
            this.Skill1_btn.Click += new System.EventHandler(this.Scrpit_Buttons_Click);
            // 
            // Skill2_btn
            // 
            this.Skill2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skill2_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.Skill2_btn.Location = new System.Drawing.Point(65, 91);
            this.Skill2_btn.Name = "Skill2_btn";
            this.Skill2_btn.Size = new System.Drawing.Size(57, 25);
            this.Skill2_btn.TabIndex = 3;
            this.Skill2_btn.Tag = "skill2";
            this.Skill2_btn.Text = "SKIL 2";
            this.Skill2_btn.UseVisualStyleBackColor = true;
            this.Skill2_btn.Click += new System.EventHandler(this.Scrpit_Buttons_Click);
            // 
            // Skill3_btn
            // 
            this.Skill3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skill3_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.Skill3_btn.Location = new System.Drawing.Point(125, 91);
            this.Skill3_btn.Name = "Skill3_btn";
            this.Skill3_btn.Size = new System.Drawing.Size(55, 25);
            this.Skill3_btn.TabIndex = 4;
            this.Skill3_btn.Tag = "skill3";
            this.Skill3_btn.Text = "SKILL 3";
            this.Skill3_btn.UseVisualStyleBackColor = true;
            this.Skill3_btn.Click += new System.EventHandler(this.Scrpit_Buttons_Click);
            // 
            // Food_btn
            // 
            this.Food_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Food_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.Food_btn.Location = new System.Drawing.Point(95, 122);
            this.Food_btn.Name = "Food_btn";
            this.Food_btn.Size = new System.Drawing.Size(85, 25);
            this.Food_btn.TabIndex = 6;
            this.Food_btn.Tag = "food";
            this.Food_btn.Text = "FOOD";
            this.Food_btn.UseVisualStyleBackColor = true;
            this.Food_btn.Click += new System.EventHandler(this.Scrpit_Buttons_Click);
            // 
            // MirageBotUI_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(186, 153);
            this.Controls.Add(this.Food_btn);
            this.Controls.Add(this.Skill3_btn);
            this.Controls.Add(this.Skill2_btn);
            this.Controls.Add(this.Skill1_btn);
            this.Controls.Add(this.Operator_btn);
            this.Controls.Add(this.Time_lb);
            this.Controls.Add(this.Rune_btn);
            this.Controls.Add(this.Mana_btn);
            this.Controls.Add(this.Hp_btn);
            this.Controls.Add(this.MainMenu_ms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.MainMenu_ms;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MirageBotUI_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mirage Bot";
            this.Load += new System.EventHandler(this.MirageBotUI_form_Load);
            this.MainMenu_ms.ResumeLayout(false);
            this.MainMenu_ms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hp_btn;
        private System.Windows.Forms.Button Mana_btn;
        private System.Windows.Forms.Button Rune_btn;
        private System.Windows.Forms.Label Time_lb;
        private System.Windows.Forms.Button Operator_btn;
        private System.Windows.Forms.Timer Duration_timer;
        private System.Windows.Forms.MenuStrip MainMenu_ms;
        private System.Windows.Forms.ToolStripMenuItem Help_mi;
        private System.Windows.Forms.ToolStripMenuItem Settings_mi;
        private System.Windows.Forms.ToolStripMenuItem Timers_mi;
        private System.Windows.Forms.Button Skill1_btn;
        private System.Windows.Forms.Button Skill2_btn;
        private System.Windows.Forms.Button Skill3_btn;
        private System.Windows.Forms.Button Food_btn;
    }
}

