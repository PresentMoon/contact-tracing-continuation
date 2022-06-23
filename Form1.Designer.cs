
namespace Contact_Tracing_Viewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadFileBttn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.DateBtn = new System.Windows.Forms.Button();
            this.RecordsBox = new System.Windows.Forms.ListBox();
            this.FilterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadFileBttn
            // 
            this.ReadFileBttn.Location = new System.Drawing.Point(13, 13);
            this.ReadFileBttn.Name = "ReadFileBttn";
            this.ReadFileBttn.Size = new System.Drawing.Size(75, 23);
            this.ReadFileBttn.TabIndex = 0;
            this.ReadFileBttn.Text = "Read File";
            this.ReadFileBttn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(713, 415);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // DateBtn
            // 
            this.DateBtn.Location = new System.Drawing.Point(366, 13);
            this.DateBtn.Name = "DateBtn";
            this.DateBtn.Size = new System.Drawing.Size(75, 23);
            this.DateBtn.TabIndex = 2;
            this.DateBtn.Text = "Date";
            this.DateBtn.UseVisualStyleBackColor = true;
            // 
            // RecordsBox
            // 
            this.RecordsBox.FormattingEnabled = true;
            this.RecordsBox.Location = new System.Drawing.Point(13, 67);
            this.RecordsBox.Name = "RecordsBox";
            this.RecordsBox.Size = new System.Drawing.Size(775, 329);
            this.RecordsBox.TabIndex = 3;
            // 
            // FilterLbl
            // 
            this.FilterLbl.AutoSize = true;
            this.FilterLbl.Location = new System.Drawing.Point(310, 18);
            this.FilterLbl.Name = "FilterLbl";
            this.FilterLbl.Size = new System.Drawing.Size(50, 13);
            this.FilterLbl.TabIndex = 4;
            this.FilterLbl.Text = "Filter By:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilterLbl);
            this.Controls.Add(this.RecordsBox);
            this.Controls.Add(this.DateBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ReadFileBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFileBttn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button DateBtn;
        private System.Windows.Forms.ListBox RecordsBox;
        private System.Windows.Forms.Label FilterLbl;
    }
}

