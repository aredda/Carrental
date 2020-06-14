namespace Car_Rental
{
    partial class FormServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.btn_validate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please, provide us with the name of your SQL Server Service";
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(33, 56);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(296, 20);
            this.txt_server.TabIndex = 1;
            // 
            // btn_validate
            // 
            this.btn_validate.Location = new System.Drawing.Point(253, 104);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(75, 29);
            this.btn_validate.TabIndex = 2;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 166);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.label1);
            this.Name = "FormServer";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "Initial Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.Button btn_validate;
    }
}