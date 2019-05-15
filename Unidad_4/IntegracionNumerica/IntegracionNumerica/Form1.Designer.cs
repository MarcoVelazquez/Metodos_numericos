namespace IntegracionNumerica
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
            this.label1 = new System.Windows.Forms.Label();
            this.FxTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MethCmbBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nTxtBox = new System.Windows.Forms.TextBox();
            this.aTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bTxtBox = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultadoTxtBox = new System.Windows.Forms.TextBox();
            this.CalcularBtt = new System.Windows.Forms.Button();
            this.BorrarBtt = new System.Windows.Forms.Button();
            this.ErrortxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "f(x):";
            // 
            // FxTxtBox
            // 
            this.FxTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FxTxtBox.Location = new System.Drawing.Point(53, 30);
            this.FxTxtBox.Name = "FxTxtBox";
            this.FxTxtBox.Size = new System.Drawing.Size(253, 20);
            this.FxTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Método:";
            // 
            // MethCmbBox
            // 
            this.MethCmbBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MethCmbBox.FormattingEnabled = true;
            this.MethCmbBox.Items.AddRange(new object[] {
            "Regla del trapecio",
            "Regla del trapecio de aplicación multiple",
            "Regla de Simpson 1/3",
            "Regla de Simpson 1/3 de aplicación multiple",
            "Regla de Simpson 3/8"});
            this.MethCmbBox.Location = new System.Drawing.Point(83, 80);
            this.MethCmbBox.Name = "MethCmbBox";
            this.MethCmbBox.Size = new System.Drawing.Size(198, 21);
            this.MethCmbBox.TabIndex = 5;
            this.MethCmbBox.SelectedIndexChanged += new System.EventHandler(this.MethCmbBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "n:";
            // 
            // nTxtBox
            // 
            this.nTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nTxtBox.Location = new System.Drawing.Point(38, 130);
            this.nTxtBox.Name = "nTxtBox";
            this.nTxtBox.Size = new System.Drawing.Size(39, 20);
            this.nTxtBox.TabIndex = 7;
            // 
            // aTxtBox
            // 
            this.aTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.aTxtBox.Location = new System.Drawing.Point(146, 130);
            this.aTxtBox.Name = "aTxtBox";
            this.aTxtBox.Size = new System.Drawing.Size(39, 20);
            this.aTxtBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "a:";
            // 
            // bTxtBox
            // 
            this.bTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bTxtBox.Location = new System.Drawing.Point(254, 130);
            this.bTxtBox.Name = "bTxtBox";
            this.bTxtBox.Size = new System.Drawing.Size(39, 20);
            this.bTxtBox.TabIndex = 11;
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.Location = new System.Drawing.Point(226, 130);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(22, 20);
            this.bLabel.TabIndex = 10;
            this.bLabel.Text = "b:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor de la aproximación:";
            // 
            // ResultadoTxtBox
            // 
            this.ResultadoTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResultadoTxtBox.Location = new System.Drawing.Point(201, 180);
            this.ResultadoTxtBox.Name = "ResultadoTxtBox";
            this.ResultadoTxtBox.Size = new System.Drawing.Size(119, 20);
            this.ResultadoTxtBox.TabIndex = 13;
            // 
            // CalcularBtt
            // 
            this.CalcularBtt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CalcularBtt.Location = new System.Drawing.Point(58, 280);
            this.CalcularBtt.Name = "CalcularBtt";
            this.CalcularBtt.Size = new System.Drawing.Size(80, 25);
            this.CalcularBtt.TabIndex = 14;
            this.CalcularBtt.Text = "Calcular";
            this.CalcularBtt.UseVisualStyleBackColor = false;
            this.CalcularBtt.Click += new System.EventHandler(this.CalcularBtt_Click);
            // 
            // BorrarBtt
            // 
            this.BorrarBtt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorrarBtt.Location = new System.Drawing.Point(174, 280);
            this.BorrarBtt.Name = "BorrarBtt";
            this.BorrarBtt.Size = new System.Drawing.Size(80, 25);
            this.BorrarBtt.TabIndex = 15;
            this.BorrarBtt.Text = "Borrar";
            this.BorrarBtt.UseVisualStyleBackColor = false;
            this.BorrarBtt.Click += new System.EventHandler(this.BorrarBtt_Click_1);
            // 
            // ErrortxtBox
            // 
            this.ErrortxtBox.Location = new System.Drawing.Point(80, 221);
            this.ErrortxtBox.Name = "ErrortxtBox";
            this.ErrortxtBox.Size = new System.Drawing.Size(100, 20);
            this.ErrortxtBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Error:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(332, 329);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ErrortxtBox);
            this.Controls.Add(this.BorrarBtt);
            this.Controls.Add(this.CalcularBtt);
            this.Controls.Add(this.ResultadoTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bTxtBox);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MethCmbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FxTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Integración numérica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FxTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MethCmbBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nTxtBox;
        private System.Windows.Forms.TextBox aTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bTxtBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ResultadoTxtBox;
        private System.Windows.Forms.Button CalcularBtt;
        private System.Windows.Forms.Button BorrarBtt;
        private System.Windows.Forms.TextBox ErrortxtBox;
        private System.Windows.Forms.Label label5;
    }
}

