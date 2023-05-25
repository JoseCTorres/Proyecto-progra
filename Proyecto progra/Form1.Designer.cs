namespace Proyecto_progra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCODIGO = new System.Windows.Forms.TextBox();
            this.textBoxTITULO = new System.Windows.Forms.TextBox();
            this.textBoxAUTOR = new System.Windows.Forms.TextBox();
            this.textBoxCANTIDAD = new System.Windows.Forms.TextBox();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(113, 233);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(734, 244);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(325, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F);
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "AUTHOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "TITLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F);
            this.label4.Location = new System.Drawing.Point(295, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "CODE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F);
            this.label5.Location = new System.Drawing.Point(19, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "GENDER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 14.25F);
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "AMOUNT";
            // 
            // textBoxCODIGO
            // 
            this.textBoxCODIGO.Location = new System.Drawing.Point(368, 86);
            this.textBoxCODIGO.Name = "textBoxCODIGO";
            this.textBoxCODIGO.Size = new System.Drawing.Size(125, 20);
            this.textBoxCODIGO.TabIndex = 7;
            // 
            // textBoxTITULO
            // 
            this.textBoxTITULO.Location = new System.Drawing.Point(103, 76);
            this.textBoxTITULO.Name = "textBoxTITULO";
            this.textBoxTITULO.Size = new System.Drawing.Size(125, 20);
            this.textBoxTITULO.TabIndex = 8;
            // 
            // textBoxAUTOR
            // 
            this.textBoxAUTOR.Location = new System.Drawing.Point(103, 115);
            this.textBoxAUTOR.Name = "textBoxAUTOR";
            this.textBoxAUTOR.Size = new System.Drawing.Size(125, 20);
            this.textBoxAUTOR.TabIndex = 9;
            // 
            // textBoxCANTIDAD
            // 
            this.textBoxCANTIDAD.Location = new System.Drawing.Point(103, 207);
            this.textBoxCANTIDAD.Name = "textBoxCANTIDAD";
            this.textBoxCANTIDAD.Size = new System.Drawing.Size(125, 20);
            this.textBoxCANTIDAD.TabIndex = 11;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Location = new System.Drawing.Point(569, 84);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.BTNGUARDAR.TabIndex = 12;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fiction",
            "Terror",
            "Comedy",
            "Action",
            "History",
            "Drama",
            "Childish",
            "Science"});
            this.comboBox1.Location = new System.Drawing.Point(103, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 502);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.textBoxCANTIDAD);
            this.Controls.Add(this.textBoxAUTOR);
            this.Controls.Add(this.textBoxTITULO);
            this.Controls.Add(this.textBoxCODIGO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCODIGO;
        private System.Windows.Forms.TextBox textBoxTITULO;
        private System.Windows.Forms.TextBox textBoxAUTOR;
        private System.Windows.Forms.TextBox textBoxCANTIDAD;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

