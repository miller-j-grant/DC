namespace Dungeon_Crawler__
{
    partial class fCCSelection
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
            this.selectionListBox = new System.Windows.Forms.ListBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.descGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.descGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // selectionListBox
            // 
            this.selectionListBox.FormattingEnabled = true;
            this.selectionListBox.Location = new System.Drawing.Point(12, 38);
            this.selectionListBox.Name = "selectionListBox";
            this.selectionListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectionListBox.Size = new System.Drawing.Size(135, 329);
            this.selectionListBox.TabIndex = 0;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(12, 9);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(155, 13);
            this.selectLabel.TabIndex = 1;
            this.selectLabel.Text = "Make the following selection(s):";
            this.selectLabel.Click += new System.EventHandler(this.selectLabel_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(173, 9);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(16, 13);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "---";
            this.numberLabel.Click += new System.EventHandler(this.numberLabel_Click);
            // 
            // descGrid
            // 
            this.descGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.descGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.descGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.descGrid.Location = new System.Drawing.Point(176, 38);
            this.descGrid.Name = "descGrid";
            this.descGrid.Size = new System.Drawing.Size(356, 329);
            this.descGrid.TabIndex = 3;
            // 
            // fCCSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 375);
            this.Controls.Add(this.descGrid);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.selectionListBox);
            this.Name = "fCCSelection";
            this.Text = "fCCSelection";
            this.Load += new System.EventHandler(this.fCCSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.descGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox selectionListBox;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.DataGridView descGrid;
    }
}