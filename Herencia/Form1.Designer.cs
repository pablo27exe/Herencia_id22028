namespace Herencia
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
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(565, 47);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(151, 53);
            this.sumar.TabIndex = 0;
            this.sumar.Text = "SUMAR";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.button1_Click);
            // 
            // restar
            // 
            this.restar.Location = new System.Drawing.Point(565, 106);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(151, 53);
            this.restar.TabIndex = 1;
            this.restar.Text = "RESTAR";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(565, 224);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(151, 53);
            this.dividir.TabIndex = 2;
            this.dividir.Text = "DIVIDIR";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.button3_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(565, 165);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(151, 53);
            this.multiplicar.TabIndex = 3;
            this.multiplicar.Text = "MULTIPLICAR";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(565, 283);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(151, 53);
            this.borrar.TabIndex = 4;
            this.borrar.Text = "BORRAR";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(64, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(30, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(64, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // valor1
            // 
            this.valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.valor1.Location = new System.Drawing.Point(163, 107);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(220, 36);
            this.valor1.TabIndex = 8;
            // 
            // valor2
            // 
            this.valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.valor2.Location = new System.Drawing.Point(163, 208);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(220, 36);
            this.valor2.TabIndex = 9;
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.resultado.Location = new System.Drawing.Point(163, 287);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(220, 36);
            this.resultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.TextBox resultado;
    }
}

