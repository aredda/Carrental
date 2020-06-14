namespace Car_Rental
{
    partial class FormCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mileage = new System.Windows.Forms.TextBox();
            this.txt_mark = new System.Windows.Forms.TextBox();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_cars = new System.Windows.Forms.DataGridView();
            this.cmb_model = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addModel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cars)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "Gérer les voitures";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cmb_model);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_submit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_mileage);
            this.panel2.Controls.Add(this.txt_mark);
            this.panel2.Controls.Add(this.txt_matricule);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgv_cars);
            // 
            // button2
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Tomato;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(719, 287);
            this.btn_delete.Name = "button2";
            this.btn_delete.Size = new System.Drawing.Size(137, 48);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Supprimer";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.btn_submit.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(123, 143);
            this.btn_submit.Name = "button1";
            this.btn_submit.Size = new System.Drawing.Size(137, 48);
            this.btn_submit.TabIndex = 28;
            this.btn_submit.Text = "Ajouter";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Marque";
            // 
            // textBox3
            // 
            this.txt_mileage.Location = new System.Drawing.Point(123, 87);
            this.txt_mileage.Name = "textBox3";
            this.txt_mileage.Size = new System.Drawing.Size(137, 21);
            this.txt_mileage.TabIndex = 19;
            // 
            // textBox2
            // 
            this.txt_mark.Location = new System.Drawing.Point(123, 60);
            this.txt_mark.Name = "textBox2";
            this.txt_mark.Size = new System.Drawing.Size(137, 21);
            this.txt_mark.TabIndex = 18;
            // 
            // textBox1
            // 
            this.txt_matricule.Location = new System.Drawing.Point(123, 33);
            this.txt_matricule.Name = "textBox1";
            this.txt_matricule.Size = new System.Drawing.Size(137, 21);
            this.txt_matricule.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Matricule";
            // 
            // dataGridView1
            // 
            this.dgv_cars.AllowUserToAddRows = false;
            this.dgv_cars.AllowUserToDeleteRows = false;
            this.dgv_cars.AllowUserToResizeColumns = false;
            this.dgv_cars.AllowUserToResizeRows = false;
            this.dgv_cars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cars.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_cars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cars.EnableHeadersVisualStyles = false;
            this.dgv_cars.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgv_cars.Location = new System.Drawing.Point(266, 33);
            this.dgv_cars.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cars.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_cars.RowHeadersVisible = false;
            this.dgv_cars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_cars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cars.Size = new System.Drawing.Size(590, 248);
            this.dgv_cars.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.Location = new System.Drawing.Point(123, 114);
            this.cmb_model.Name = "comboBox1";
            this.cmb_model.Size = new System.Drawing.Size(137, 23);
            this.cmb_model.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addModel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Location = new System.Drawing.Point(36, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(224, 138);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les models";
            // 
            // button3
            // 
            this.btn_addModel.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_addModel.FlatAppearance.BorderSize = 0;
            this.btn_addModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addModel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addModel.ForeColor = System.Drawing.Color.White;
            this.btn_addModel.Location = new System.Drawing.Point(87, 86);
            this.btn_addModel.Name = "button3";
            this.btn_addModel.Size = new System.Drawing.Size(114, 32);
            this.btn_addModel.TabIndex = 29;
            this.btn_addModel.Text = "Ajouter";
            this.btn_addModel.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nom";
            // 
            // textBox4
            // 
            this.txt_nom.Location = new System.Drawing.Point(87, 59);
            this.txt_nom.Name = "textBox4";
            this.txt_nom.Size = new System.Drawing.Size(114, 21);
            this.txt_nom.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(87, 32);
            this.dtp_date.Name = "dateTimePicker1";
            this.dtp_date.Size = new System.Drawing.Size(114, 21);
            this.dtp_date.TabIndex = 0;
            // 
            // FormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 483);
            this.Name = "FormCar";
            this.Text = "FormCar";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cars)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mileage;
        private System.Windows.Forms.TextBox txt_mark;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_cars;
        private System.Windows.Forms.ComboBox cmb_model;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_addModel;
    }
}