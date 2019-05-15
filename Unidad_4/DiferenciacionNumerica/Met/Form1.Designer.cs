namespace Met
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
            this.fxTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xTxtBx = new System.Windows.Forms.TextBox();
            this.hTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoDeDifCmbBx = new System.Windows.Forms.ComboBox();
            this.DerivateCmbBx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrdErrCmbBx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CalcularBtt = new System.Windows.Forms.Button();
            this.BorrarBtt = new System.Windows.Forms.Button();
            this.ResultadoTxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "f(x)";
            // 
            // fxTxtBx
            // 
            this.fxTxtBx.Location = new System.Drawing.Point(68, 36);
            this.fxTxtBx.Name = "fxTxtBx";
            this.fxTxtBx.Size = new System.Drawing.Size(262, 20);
            this.fxTxtBx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "x : ";
            // 
            // xTxtBx
            // 
            this.xTxtBx.Location = new System.Drawing.Point(68, 81);
            this.xTxtBx.Name = "xTxtBx";
            this.xTxtBx.Size = new System.Drawing.Size(70, 20);
            this.xTxtBx.TabIndex = 3;
            this.xTxtBx.Text = "0";
            // 
            // hTxtBx
            // 
            this.hTxtBx.Location = new System.Drawing.Point(192, 81);
            this.hTxtBx.Name = "hTxtBx";
            this.hTxtBx.Size = new System.Drawing.Size(70, 20);
            this.hTxtBx.TabIndex = 5;
            this.hTxtBx.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "h : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de diferenciación :";
            // 
            // TipoDeDifCmbBx
            // 
            this.TipoDeDifCmbBx.FormattingEnabled = true;
            this.TipoDeDifCmbBx.Items.AddRange(new object[] {
            "Hacia adelante",
            "Hacia atras",
            "Centrada"});
            this.TipoDeDifCmbBx.Location = new System.Drawing.Point(209, 122);
            this.TipoDeDifCmbBx.Name = "TipoDeDifCmbBx";
            this.TipoDeDifCmbBx.Size = new System.Drawing.Size(121, 21);
            this.TipoDeDifCmbBx.TabIndex = 7;
            // 
            // DerivateCmbBx
            // 
            this.DerivateCmbBx.FormattingEnabled = true;
            this.DerivateCmbBx.Items.AddRange(new object[] {
            "Primera derivada",
            "Segunda derivada",
            "Tercera derivada",
            "Cuarta derivada"});
            this.DerivateCmbBx.Location = new System.Drawing.Point(123, 161);
            this.DerivateCmbBx.Name = "DerivateCmbBx";
            this.DerivateCmbBx.Size = new System.Drawing.Size(121, 21);
            this.DerivateCmbBx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Derivada :";
            // 
            // OrdErrCmbBx
            // 
            this.OrdErrCmbBx.FormattingEnabled = true;
            this.OrdErrCmbBx.Items.AddRange(new object[] {
            "O(h)",
            "O(h^2)",
            "O(h^4)"});
            this.OrdErrCmbBx.Location = new System.Drawing.Point(141, 202);
            this.OrdErrCmbBx.Name = "OrdErrCmbBx";
            this.OrdErrCmbBx.Size = new System.Drawing.Size(121, 21);
            this.OrdErrCmbBx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Orden error :";
            // 
            // CalcularBtt
            // 
            this.CalcularBtt.Location = new System.Drawing.Point(103, 294);
            this.CalcularBtt.Name = "CalcularBtt";
            this.CalcularBtt.Size = new System.Drawing.Size(75, 23);
            this.CalcularBtt.TabIndex = 12;
            this.CalcularBtt.Text = "Calcular";
            this.CalcularBtt.UseVisualStyleBackColor = true;
            this.CalcularBtt.Click += new System.EventHandler(this.CalcularBtt_Click);
            // 
            // BorrarBtt
            // 
            this.BorrarBtt.Location = new System.Drawing.Point(209, 294);
            this.BorrarBtt.Name = "BorrarBtt";
            this.BorrarBtt.Size = new System.Drawing.Size(75, 23);
            this.BorrarBtt.TabIndex = 14;
            this.BorrarBtt.Text = "Borrar";
            this.BorrarBtt.UseVisualStyleBackColor = true;
            this.BorrarBtt.Click += new System.EventHandler(this.BorrarBtt_Click);
            // 
            // ResultadoTxtBx
            // 
            this.ResultadoTxtBx.Location = new System.Drawing.Point(131, 238);
            this.ResultadoTxtBx.Name = "ResultadoTxtBx";
            this.ResultadoTxtBx.Size = new System.Drawing.Size(189, 20);
            this.ResultadoTxtBx.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Resultado : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 329);
            this.Controls.Add(this.ResultadoTxtBx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BorrarBtt);
            this.Controls.Add(this.CalcularBtt);
            this.Controls.Add(this.OrdErrCmbBx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DerivateCmbBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TipoDeDifCmbBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fxTxtBx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fxTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xTxtBx;
        private System.Windows.Forms.TextBox hTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TipoDeDifCmbBx;
        private System.Windows.Forms.ComboBox DerivateCmbBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OrdErrCmbBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CalcularBtt;
        private System.Windows.Forms.Button BorrarBtt;
        private System.Windows.Forms.TextBox ResultadoTxtBx;
        private System.Windows.Forms.Label label7;
    }
}

