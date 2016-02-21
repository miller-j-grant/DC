namespace Dungeon_Crawler__
{
    partial class Splash
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
            this.splashMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnD5ECharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encounterCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCharBox = new System.Windows.Forms.ListBox();
            this.loadCharLabel = new System.Windows.Forms.Label();
            this.splashMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashMenuStrip
            // 
            this.splashMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.splashMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.splashMenuStrip.Name = "splashMenuStrip";
            this.splashMenuStrip.Size = new System.Drawing.Size(1062, 24);
            this.splashMenuStrip.TabIndex = 0;
            this.splashMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dnD5ECharacterToolStripMenuItem,
            this.creatureToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // dnD5ECharacterToolStripMenuItem
            // 
            this.dnD5ECharacterToolStripMenuItem.Name = "dnD5ECharacterToolStripMenuItem";
            this.dnD5ECharacterToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dnD5ECharacterToolStripMenuItem.Text = "DnD5E Character";
            // 
            // creatureToolStripMenuItem
            // 
            this.creatureToolStripMenuItem.Name = "creatureToolStripMenuItem";
            this.creatureToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.creatureToolStripMenuItem.Text = "Creature";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encounterCalculatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // encounterCalculatorToolStripMenuItem
            // 
            this.encounterCalculatorToolStripMenuItem.Name = "encounterCalculatorToolStripMenuItem";
            this.encounterCalculatorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.encounterCalculatorToolStripMenuItem.Text = "Encounter Calculator";
            // 
            // loadCharBox
            // 
            this.loadCharBox.FormattingEnabled = true;
            this.loadCharBox.Location = new System.Drawing.Point(24, 68);
            this.loadCharBox.Name = "loadCharBox";
            this.loadCharBox.Size = new System.Drawing.Size(202, 290);
            this.loadCharBox.TabIndex = 1;
            // 
            // loadCharLabel
            // 
            this.loadCharLabel.AutoSize = true;
            this.loadCharLabel.Location = new System.Drawing.Point(33, 52);
            this.loadCharLabel.Name = "loadCharLabel";
            this.loadCharLabel.Size = new System.Drawing.Size(97, 13);
            this.loadCharLabel.TabIndex = 2;
            this.loadCharLabel.Text = "Loaded Characters";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 686);
            this.Controls.Add(this.loadCharLabel);
            this.Controls.Add(this.loadCharBox);
            this.Controls.Add(this.splashMenuStrip);
            this.MainMenuStrip = this.splashMenuStrip;
            this.Name = "Splash";
            this.Text = "Dungeon Crawler +";
            this.splashMenuStrip.ResumeLayout(false);
            this.splashMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip splashMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnD5ECharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encounterCalculatorToolStripMenuItem;
        private System.Windows.Forms.ListBox loadCharBox;
        private System.Windows.Forms.Label loadCharLabel;
    }
}