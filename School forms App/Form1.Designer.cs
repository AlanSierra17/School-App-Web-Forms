namespace School_forms_App
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textDepartment = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textTwitter = new System.Windows.Forms.TextBox();
            this.btn_1_pushToTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del colegio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número de teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cuenta de Twitter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(240, 55);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 7;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(191, 99);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 20);
            this.textAddress.TabIndex = 8;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(191, 149);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 20);
            this.textCity.TabIndex = 9;
            // 
            // textDepartment
            // 
            this.textDepartment.Location = new System.Drawing.Point(216, 200);
            this.textDepartment.Name = "textDepartment";
            this.textDepartment.Size = new System.Drawing.Size(100, 20);
            this.textDepartment.TabIndex = 10;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(242, 243);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 11;
            // 
            // textTwitter
            // 
            this.textTwitter.Location = new System.Drawing.Point(240, 289);
            this.textTwitter.Name = "textTwitter";
            this.textTwitter.Size = new System.Drawing.Size(100, 20);
            this.textTwitter.TabIndex = 12;
            // 
            // btn_1_pushToTest
            // 
            this.btn_1_pushToTest.Location = new System.Drawing.Point(179, 345);
            this.btn_1_pushToTest.Name = "btn_1_pushToTest";
            this.btn_1_pushToTest.Size = new System.Drawing.Size(126, 23);
            this.btn_1_pushToTest.TabIndex = 13;
            this.btn_1_pushToTest.Text = "Presionar para probar";
            this.btn_1_pushToTest.UseVisualStyleBackColor = true;
            this.btn_1_pushToTest.Click += new System.EventHandler(this.btn_1_pushToTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btn_1_pushToTest);
            this.Controls.Add(this.textTwitter);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textDepartment);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textDepartment;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textTwitter;
        private System.Windows.Forms.Button btn_1_pushToTest;
    }
}

