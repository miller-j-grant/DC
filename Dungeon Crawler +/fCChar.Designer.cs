namespace Dungeon_Crawler__
{
    partial class CChar
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
            this.CCharMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CCharTab = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RaceBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClassBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BackgroundBox = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.EquipmentBox = new System.Windows.Forms.ListBox();
            this.AbilityPic = new System.Windows.Forms.PictureBox();
            this.STRLabel = new System.Windows.Forms.Label();
            this.DEXLabel = new System.Windows.Forms.Label();
            this.CONLabel = new System.Windows.Forms.Label();
            this.INTLabel = new System.Windows.Forms.Label();
            this.CHALabel = new System.Windows.Forms.Label();
            this.WISLabel = new System.Windows.Forms.Label();
            this.CHAModLabel = new System.Windows.Forms.Label();
            this.WISModLabel = new System.Windows.Forms.Label();
            this.INTModLabel = new System.Windows.Forms.Label();
            this.CONModLabel = new System.Windows.Forms.Label();
            this.DEXModLabel = new System.Windows.Forms.Label();
            this.STRModLabel = new System.Windows.Forms.Label();
            this.CCharMenuStrip.SuspendLayout();
            this.CCharTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbilityPic)).BeginInit();
            this.SuspendLayout();
            // 
            // CCharMenuStrip
            // 
            this.CCharMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CCharMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CCharMenuStrip.Name = "CCharMenuStrip";
            this.CCharMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CCharMenuStrip.Size = new System.Drawing.Size(1076, 24);
            this.CCharMenuStrip.TabIndex = 0;
            this.CCharMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // CCharTab
            // 
            this.CCharTab.Controls.Add(this.tabPage5);
            this.CCharTab.Controls.Add(this.tabPage1);
            this.CCharTab.Controls.Add(this.tabPage2);
            this.CCharTab.Controls.Add(this.tabPage3);
            this.CCharTab.Controls.Add(this.tabPage4);
            this.CCharTab.Location = new System.Drawing.Point(108, 23);
            this.CCharTab.Name = "CCharTab";
            this.CCharTab.SelectedIndex = 0;
            this.CCharTab.Size = new System.Drawing.Size(968, 709);
            this.CCharTab.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(960, 683);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ability Score";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RaceBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 683);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Race";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // RaceBox
            // 
            this.RaceBox.FormattingEnabled = true;
            this.RaceBox.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Halfling",
            "Human",
            "Dragonborn",
            "Gnome",
            "Half-Elf",
            "Half-Orc",
            "Tiefling"});
            this.RaceBox.Location = new System.Drawing.Point(0, 0);
            this.RaceBox.Name = "RaceBox";
            this.RaceBox.Size = new System.Drawing.Size(233, 563);
            this.RaceBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClassBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 683);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Class";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.ClassBox.Location = new System.Drawing.Point(0, 0);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(233, 563);
            this.ClassBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BackgroundBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(960, 683);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Background";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.FormattingEnabled = true;
            this.BackgroundBox.Items.AddRange(new object[] {
            "Acolyte",
            "Charlatan",
            "Criminal",
            "Entertainer",
            "Folk Hero",
            "Guild Artisan",
            "Hermit",
            "Noble",
            "Outlander",
            "Sage",
            "Sailor",
            "Soldier",
            "Urchin"});
            this.BackgroundBox.Location = new System.Drawing.Point(0, 0);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(230, 563);
            this.BackgroundBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.EquipmentBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(960, 683);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Equipment";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // EquipmentBox
            // 
            this.EquipmentBox.FormattingEnabled = true;
            this.EquipmentBox.Location = new System.Drawing.Point(0, 0);
            this.EquipmentBox.Name = "EquipmentBox";
            this.EquipmentBox.Size = new System.Drawing.Size(230, 563);
            this.EquipmentBox.TabIndex = 0;
            // 
            // AbilityPic
            // 
            this.AbilityPic.Image = global::Dungeon_Crawler__.Properties.Resources.as2;
            this.AbilityPic.Location = new System.Drawing.Point(8, 27);
            this.AbilityPic.Name = "AbilityPic";
            this.AbilityPic.Size = new System.Drawing.Size(98, 705);
            this.AbilityPic.TabIndex = 3;
            this.AbilityPic.TabStop = false;
            this.AbilityPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // STRLabel
            // 
            this.STRLabel.AutoSize = true;
            this.STRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRLabel.Location = new System.Drawing.Point(25, 74);
            this.STRLabel.Name = "STRLabel";
            this.STRLabel.Size = new System.Drawing.Size(51, 37);
            this.STRLabel.TabIndex = 4;
            this.STRLabel.Text = "10";
            this.STRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DEXLabel
            // 
            this.DEXLabel.AutoSize = true;
            this.DEXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEXLabel.Location = new System.Drawing.Point(25, 185);
            this.DEXLabel.Name = "DEXLabel";
            this.DEXLabel.Size = new System.Drawing.Size(51, 37);
            this.DEXLabel.TabIndex = 5;
            this.DEXLabel.Text = "10";
            this.DEXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CONLabel
            // 
            this.CONLabel.AutoSize = true;
            this.CONLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONLabel.Location = new System.Drawing.Point(25, 294);
            this.CONLabel.Name = "CONLabel";
            this.CONLabel.Size = new System.Drawing.Size(51, 37);
            this.CONLabel.TabIndex = 6;
            this.CONLabel.Text = "10";
            this.CONLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INTLabel
            // 
            this.INTLabel.AutoSize = true;
            this.INTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTLabel.Location = new System.Drawing.Point(25, 407);
            this.INTLabel.Name = "INTLabel";
            this.INTLabel.Size = new System.Drawing.Size(51, 37);
            this.INTLabel.TabIndex = 7;
            this.INTLabel.Text = "10";
            this.INTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHALabel.Location = new System.Drawing.Point(25, 628);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(51, 37);
            this.CHALabel.TabIndex = 6;
            this.CHALabel.Text = "10";
            this.CHALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WISLabel
            // 
            this.WISLabel.AutoSize = true;
            this.WISLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WISLabel.Location = new System.Drawing.Point(25, 519);
            this.WISLabel.Name = "WISLabel";
            this.WISLabel.Size = new System.Drawing.Size(51, 37);
            this.WISLabel.TabIndex = 7;
            this.WISLabel.Text = "10";
            this.WISLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CHAModLabel
            // 
            this.CHAModLabel.AutoSize = true;
            this.CHAModLabel.Location = new System.Drawing.Point(48, 675);
            this.CHAModLabel.Name = "CHAModLabel";
            this.CHAModLabel.Size = new System.Drawing.Size(13, 13);
            this.CHAModLabel.TabIndex = 6;
            this.CHAModLabel.Text = "0";
            this.CHAModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WISModLabel
            // 
            this.WISModLabel.AutoSize = true;
            this.WISModLabel.Location = new System.Drawing.Point(48, 568);
            this.WISModLabel.Name = "WISModLabel";
            this.WISModLabel.Size = new System.Drawing.Size(13, 13);
            this.WISModLabel.TabIndex = 7;
            this.WISModLabel.Text = "0";
            this.WISModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INTModLabel
            // 
            this.INTModLabel.AutoSize = true;
            this.INTModLabel.Location = new System.Drawing.Point(48, 459);
            this.INTModLabel.Name = "INTModLabel";
            this.INTModLabel.Size = new System.Drawing.Size(13, 13);
            this.INTModLabel.TabIndex = 8;
            this.INTModLabel.Text = "0";
            this.INTModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CONModLabel
            // 
            this.CONModLabel.AutoSize = true;
            this.CONModLabel.Location = new System.Drawing.Point(48, 350);
            this.CONModLabel.Name = "CONModLabel";
            this.CONModLabel.Size = new System.Drawing.Size(13, 13);
            this.CONModLabel.TabIndex = 9;
            this.CONModLabel.Text = "0";
            this.CONModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DEXModLabel
            // 
            this.DEXModLabel.AutoSize = true;
            this.DEXModLabel.Location = new System.Drawing.Point(48, 236);
            this.DEXModLabel.Name = "DEXModLabel";
            this.DEXModLabel.Size = new System.Drawing.Size(13, 13);
            this.DEXModLabel.TabIndex = 10;
            this.DEXModLabel.Text = "0";
            this.DEXModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STRModLabel
            // 
            this.STRModLabel.AutoSize = true;
            this.STRModLabel.Location = new System.Drawing.Point(48, 125);
            this.STRModLabel.Name = "STRModLabel";
            this.STRModLabel.Size = new System.Drawing.Size(13, 13);
            this.STRModLabel.TabIndex = 11;
            this.STRModLabel.Text = "0";
            this.STRModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 775);
            this.Controls.Add(this.CHAModLabel);
            this.Controls.Add(this.WISModLabel);
            this.Controls.Add(this.INTModLabel);
            this.Controls.Add(this.CONModLabel);
            this.Controls.Add(this.DEXModLabel);
            this.Controls.Add(this.STRModLabel);
            this.Controls.Add(this.CHALabel);
            this.Controls.Add(this.WISLabel);
            this.Controls.Add(this.DEXLabel);
            this.Controls.Add(this.STRLabel);
            this.Controls.Add(this.INTLabel);
            this.Controls.Add(this.CONLabel);
            this.Controls.Add(this.AbilityPic);
            this.Controls.Add(this.CCharTab);
            this.Controls.Add(this.CCharMenuStrip);
            this.MainMenuStrip = this.CCharMenuStrip;
            this.Name = "CChar";
            this.Text = "Dungeon Crawler +";
            this.CCharMenuStrip.ResumeLayout(false);
            this.CCharMenuStrip.PerformLayout();
            this.CCharTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AbilityPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CCharMenuStrip;
        private System.Windows.Forms.TabControl CCharTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox AbilityPic;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox RaceBox;
        private System.Windows.Forms.ListBox ClassBox;
        private System.Windows.Forms.ListBox BackgroundBox;
        private System.Windows.Forms.ListBox EquipmentBox;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label STRLabel;
        private System.Windows.Forms.Label DEXLabel;
        private System.Windows.Forms.Label CONLabel;
        private System.Windows.Forms.Label INTLabel;
        private System.Windows.Forms.Label CHALabel;
        private System.Windows.Forms.Label WISLabel;
        private System.Windows.Forms.Label CHAModLabel;
        private System.Windows.Forms.Label WISModLabel;
        private System.Windows.Forms.Label INTModLabel;
        private System.Windows.Forms.Label CONModLabel;
        private System.Windows.Forms.Label DEXModLabel;
        private System.Windows.Forms.Label STRModLabel;
    }
}

