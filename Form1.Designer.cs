
namespace Contact_Tracing_Viewer
{
    partial class ContactTracingViewer
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
            this.components = new System.ComponentModel.Container();
            this.ReadFileBttn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.DateBtn = new System.Windows.Forms.Button();
            this.RecordsBox = new System.Windows.Forms.ListBox();
            this.FilterLbl = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.ReadFileBttn.Click += new System.EventHandler(this.ReadFileBttn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(750, 363);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // DateBtn
            // 
            this.DateBtn.Location = new System.Drawing.Point(557, 12);
            this.DateBtn.Name = "DateBtn";
            this.DateBtn.Size = new System.Drawing.Size(75, 23);
            this.DateBtn.TabIndex = 2;
            this.DateBtn.Text = "Date";
            this.DateBtn.UseVisualStyleBackColor = true;
            // 
            // RecordsBox
            // 
            this.RecordsBox.FormattingEnabled = true;
            this.RecordsBox.Location = new System.Drawing.Point(13, 54);
            this.RecordsBox.Name = "RecordsBox";
            this.RecordsBox.Size = new System.Drawing.Size(812, 290);
            this.RecordsBox.TabIndex = 3;
            // 
            // FilterLbl
            // 
            this.FilterLbl.AutoSize = true;
            this.FilterLbl.Location = new System.Drawing.Point(501, 18);
            this.FilterLbl.Name = "FilterLbl";
            this.FilterLbl.Size = new System.Drawing.Size(50, 13);
            this.FilterLbl.TabIndex = 4;
            this.FilterLbl.Text = "Filter By:";
            // 
            // ContactTracingViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 397);
            this.Controls.Add(this.FilterLbl);
            this.Controls.Add(this.RecordsBox);
            this.Controls.Add(this.DateBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ReadFileBttn);
            this.Name = "ContactTracingViewer";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFileBttn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button DateBtn;
        private System.Windows.Forms.ListBox RecordsBox;
        private System.Windows.Forms.Label FilterLbl;
        private System.Windows.Forms.Button NameBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

