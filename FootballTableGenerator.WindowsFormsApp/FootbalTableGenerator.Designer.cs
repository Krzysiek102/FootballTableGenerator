namespace FootballTableGenerator.WindowsFormsApp
{
    partial class FootbalTableGenerator
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
            this.tbInputResult = new System.Windows.Forms.TextBox();
            this.uxRegisterResult = new System.Windows.Forms.Button();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxInputResult
            // 
            this.tbInputResult.Location = new System.Drawing.Point(13, 13);
            this.tbInputResult.Name = "uxInputResult";
            this.tbInputResult.Size = new System.Drawing.Size(415, 20);
            this.tbInputResult.TabIndex = 0;
            // 
            // uxRegisterResult
            // 
            this.uxRegisterResult.Location = new System.Drawing.Point(13, 47);
            this.uxRegisterResult.Name = "uxRegisterResult";
            this.uxRegisterResult.Size = new System.Drawing.Size(75, 23);
            this.uxRegisterResult.TabIndex = 1;
            this.uxRegisterResult.Text = "Register Result";
            this.uxRegisterResult.UseVisualStyleBackColor = true;
            this.uxRegisterResult.Click += new System.EventHandler(this.uxRegisterResult_Click);
            // 
            // uxTable
            // 
            this.tbTable.Location = new System.Drawing.Point(16, 91);
            this.tbTable.Multiline = true;
            this.tbTable.Name = "uxTable";
            this.tbTable.Size = new System.Drawing.Size(567, 326);
            this.tbTable.TabIndex = 2;
            // 
            // FootbalTableGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 429);
            this.Controls.Add(this.tbTable);
            this.Controls.Add(this.uxRegisterResult);
            this.Controls.Add(this.tbInputResult);
            this.Name = "FootbalTableGenerator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputResult;
        private System.Windows.Forms.Button uxRegisterResult;
        private System.Windows.Forms.TextBox tbTable;
    }
}

