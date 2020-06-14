namespace Car_Rental
{
    partial class FormReservation
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
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_debut = new System.Windows.Forms.DateTimePicker();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_rentals = new System.Windows.Forms.DataGridView();
            this.cmb_client = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_voiture = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rentals)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "Gérer les reservations";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_submit);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmb_voiture);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmb_client);
            this.panel2.Controls.Add(this.dgv_rentals);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nud_price);
            this.panel2.Controls.Add(this.dtp_debut);
            this.panel2.Controls.Add(this.dtp_end);
            // 
            // dateTimePicker1
            // 
            this.dtp_end.Location = new System.Drawing.Point(124, 33);
            this.dtp_end.Name = "dateTimePicker1";
            this.dtp_end.Size = new System.Drawing.Size(125, 21);
            this.dtp_end.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dtp_debut.Location = new System.Drawing.Point(124, 60);
            this.dtp_debut.Name = "dateTimePicker2";
            this.dtp_debut.Size = new System.Drawing.Size(125, 21);
            this.dtp_debut.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.nud_price.Location = new System.Drawing.Point(124, 87);
            this.nud_price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_price.Name = "numericUpDown1";
            this.nud_price.Size = new System.Drawing.Size(125, 21);
            this.nud_price.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Debut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prix";
            // 
            // dataGridView1
            // 
            this.dgv_rentals.AllowUserToAddRows = false;
            this.dgv_rentals.AllowUserToDeleteRows = false;
            this.dgv_rentals.AllowUserToResizeColumns = false;
            this.dgv_rentals.AllowUserToResizeRows = false;
            this.dgv_rentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rentals.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_rentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_rentals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rentals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_rentals.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_rentals.EnableHeadersVisualStyles = false;
            this.dgv_rentals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgv_rentals.Location = new System.Drawing.Point(255, 33);
            this.dgv_rentals.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rentals.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_rentals.RowHeadersVisible = false;
            this.dgv_rentals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_rentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rentals.Size = new System.Drawing.Size(601, 248);
            this.dgv_rentals.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.cmb_client.FormattingEnabled = true;
            this.cmb_client.Location = new System.Drawing.Point(124, 114);
            this.cmb_client.Name = "comboBox1";
            this.cmb_client.Size = new System.Drawing.Size(125, 23);
            this.cmb_client.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Client";
            // 
            // comboBox2
            // 
            this.cmb_voiture.FormattingEnabled = true;
            this.cmb_voiture.Location = new System.Drawing.Point(124, 143);
            this.cmb_voiture.Name = "comboBox2";
            this.cmb_voiture.Size = new System.Drawing.Size(125, 23);
            this.cmb_voiture.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Voiture";
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
            this.btn_delete.TabIndex = 30;
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
            this.btn_submit.Location = new System.Drawing.Point(124, 172);
            this.btn_submit.Name = "button1";
            this.btn_submit.Size = new System.Drawing.Size(125, 48);
            this.btn_submit.TabIndex = 31;
            this.btn_submit.Text = "Ajouter";
            this.btn_submit.UseVisualStyleBackColor = false;
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 483);
            this.Name = "FormReservation";
            this.Text = "FormReservation";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_price;
        private System.Windows.Forms.DateTimePicker dtp_debut;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_rentals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_voiture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_client;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_submit;
    }
}