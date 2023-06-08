namespace CalculadoraPlanDepsiones.Presentation
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
            this.CalcularButton = new System.Windows.Forms.Button();
            this.InversionText = new System.Windows.Forms.TextBox();
            this.SalarioText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutonomoCheckbox = new System.Windows.Forms.CheckBox();
            this.EmpleadoCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(119, 205);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 0;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // InversionText
            // 
            this.InversionText.Location = new System.Drawing.Point(190, 80);
            this.InversionText.Name = "InversionText";
            this.InversionText.Size = new System.Drawing.Size(100, 22);
            this.InversionText.TabIndex = 1;
            // 
            // SalarioText
            // 
            this.SalarioText.Location = new System.Drawing.Point(33, 80);
            this.SalarioText.Name = "SalarioText";
            this.SalarioText.Size = new System.Drawing.Size(100, 22);
            this.SalarioText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salario Anual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inversión Deseada";
            // 
            // AutonomoCheckbox
            // 
            this.AutonomoCheckbox.AutoSize = true;
            this.AutonomoCheckbox.Location = new System.Drawing.Point(119, 135);
            this.AutonomoCheckbox.Name = "AutonomoCheckbox";
            this.AutonomoCheckbox.Size = new System.Drawing.Size(90, 20);
            this.AutonomoCheckbox.TabIndex = 6;
            this.AutonomoCheckbox.Text = "Autonomo";
            this.AutonomoCheckbox.UseVisualStyleBackColor = true;
            // 
            // EmpleadoCheckbox
            // 
            this.EmpleadoCheckbox.AutoSize = true;
            this.EmpleadoCheckbox.Location = new System.Drawing.Point(119, 162);
            this.EmpleadoCheckbox.Name = "EmpleadoCheckbox";
            this.EmpleadoCheckbox.Size = new System.Drawing.Size(92, 20);
            this.EmpleadoCheckbox.TabIndex = 7;
            this.EmpleadoCheckbox.Text = "Empleado";
            this.EmpleadoCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 240);
            this.Controls.Add(this.EmpleadoCheckbox);
            this.Controls.Add(this.AutonomoCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalarioText);
            this.Controls.Add(this.InversionText);
            this.Controls.Add(this.CalcularButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox InversionText;
        private System.Windows.Forms.TextBox SalarioText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AutonomoCheckbox;
        private System.Windows.Forms.CheckBox EmpleadoCheckbox;
    }
}

