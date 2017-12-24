namespace ExcelPic
{
    partial class FrmMain
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
            this.BtnDoIt = new System.Windows.Forms.Button();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.BtnFilePicker = new System.Windows.Forms.Button();
            this.TxtFilePicked = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtColSpan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCellUnitHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClearMem = new System.Windows.Forms.Button();
            this.ChkRandomize = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnDoIt
            // 
            this.BtnDoIt.Location = new System.Drawing.Point(12, 135);
            this.BtnDoIt.Name = "BtnDoIt";
            this.BtnDoIt.Size = new System.Drawing.Size(70, 23);
            this.BtnDoIt.TabIndex = 0;
            this.BtnDoIt.Text = "Draw";
            this.BtnDoIt.UseVisualStyleBackColor = true;
            this.BtnDoIt.Click += new System.EventHandler(this.BtnDoIt_Click);
            // 
            // BtnFilePicker
            // 
            this.BtnFilePicker.BackColor = System.Drawing.Color.Snow;
            this.BtnFilePicker.Location = new System.Drawing.Point(12, 109);
            this.BtnFilePicker.Name = "BtnFilePicker";
            this.BtnFilePicker.Size = new System.Drawing.Size(75, 20);
            this.BtnFilePicker.TabIndex = 1;
            this.BtnFilePicker.Text = "Browse...";
            this.BtnFilePicker.UseVisualStyleBackColor = false;
            this.BtnFilePicker.Click += new System.EventHandler(this.BtnFilePicker_Click);
            // 
            // TxtFilePicked
            // 
            this.TxtFilePicked.BackColor = System.Drawing.SystemColors.Control;
            this.TxtFilePicked.Enabled = false;
            this.TxtFilePicked.Location = new System.Drawing.Point(105, 109);
            this.TxtFilePicked.Name = "TxtFilePicked";
            this.TxtFilePicked.Size = new System.Drawing.Size(484, 20);
            this.TxtFilePicked.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Columns Count:";
            // 
            // TxtColSpan
            // 
            this.TxtColSpan.Location = new System.Drawing.Point(129, 7);
            this.TxtColSpan.Name = "TxtColSpan";
            this.TxtColSpan.Size = new System.Drawing.Size(39, 20);
            this.TxtColSpan.TabIndex = 5;
            this.TxtColSpan.Text = "80";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Default 80 From 10 to 500./From 10 to 500, default 80";
            // 
            // TxtCellUnitHeight
            // 
            this.TxtCellUnitHeight.Location = new System.Drawing.Point(129, 42);
            this.TxtCellUnitHeight.Name = "TxtCellUnitHeight";
            this.TxtCellUnitHeight.Size = new System.Drawing.Size(39, 20);
            this.TxtCellUnitHeight.TabIndex = 8;
            this.TxtCellUnitHeight.Text = "15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Point count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Default 15. From 10 to 20";
            // 
            // BtnClearMem
            // 
            this.BtnClearMem.Location = new System.Drawing.Point(104, 135);
            this.BtnClearMem.Name = "BtnClearMem";
            this.BtnClearMem.Size = new System.Drawing.Size(166, 23);
            this.BtnClearMem.TabIndex = 10;
            this.BtnClearMem.Text = "Clear is Excel";
            this.BtnClearMem.UseVisualStyleBackColor = true;
            this.BtnClearMem.Click += new System.EventHandler(this.BtnClearMem_Click);
            // 
            // ChkRandomize
            // 
            this.ChkRandomize.AutoSize = true;
            this.ChkRandomize.Checked = true;
            this.ChkRandomize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRandomize.Location = new System.Drawing.Point(129, 71);
            this.ChkRandomize.Name = "ChkRandomize";
            this.ChkRandomize.Size = new System.Drawing.Size(192, 17);
            this.ChkRandomize.TabIndex = 11;
            this.ChkRandomize.Text = "Mark The Pixxells for randomization";
            this.ChkRandomize.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(624, 191);
            this.Controls.Add(this.ChkRandomize);
            this.Controls.Add(this.BtnClearMem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCellUnitHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtColSpan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFilePicked);
            this.Controls.Add(this.BtnFilePicker);
            this.Controls.Add(this.BtnDoIt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 230);
            this.Name = "FrmMain";
            this.Text = "ExcelPic (Excel Pixelating Image Creator)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDoIt;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.Button BtnFilePicker;
        private System.Windows.Forms.TextBox TxtFilePicked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtColSpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCellUnitHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClearMem;
        private System.Windows.Forms.CheckBox ChkRandomize;
    }
}

