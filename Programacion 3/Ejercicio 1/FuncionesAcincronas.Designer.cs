
namespace Ejercicio_1
{
    partial class FuncionesAcincronas
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
            this.Btn_Ejecutar = new System.Windows.Forms.Button();
            this.Lbl_Resultato = new System.Windows.Forms.Label();
            this.Lbl_Sumar = new System.Windows.Forms.Label();
            this.Btn_Sumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Ejecutar
            // 
            this.Btn_Ejecutar.Location = new System.Drawing.Point(274, 58);
            this.Btn_Ejecutar.Name = "Btn_Ejecutar";
            this.Btn_Ejecutar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ejecutar.TabIndex = 0;
            this.Btn_Ejecutar.Text = "Ejecutar";
            this.Btn_Ejecutar.UseVisualStyleBackColor = true;
            this.Btn_Ejecutar.Click += new System.EventHandler(this.Btn_Ejecutar_Click);
            // 
            // Lbl_Resultato
            // 
            this.Lbl_Resultato.AutoSize = true;
            this.Lbl_Resultato.Location = new System.Drawing.Point(296, 148);
            this.Lbl_Resultato.Name = "Lbl_Resultato";
            this.Lbl_Resultato.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Resultato.TabIndex = 1;
            this.Lbl_Resultato.Text = "label1";
            // 
            // Lbl_Sumar
            // 
            this.Lbl_Sumar.AutoSize = true;
            this.Lbl_Sumar.Location = new System.Drawing.Point(484, 148);
            this.Lbl_Sumar.Name = "Lbl_Sumar";
            this.Lbl_Sumar.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Sumar.TabIndex = 3;
            this.Lbl_Sumar.Text = "label1";
            // 
            // Btn_Sumar
            // 
            this.Btn_Sumar.Location = new System.Drawing.Point(462, 58);
            this.Btn_Sumar.Name = "Btn_Sumar";
            this.Btn_Sumar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sumar.TabIndex = 2;
            this.Btn_Sumar.Text = "Sumar";
            this.Btn_Sumar.UseVisualStyleBackColor = true;
            this.Btn_Sumar.Click += new System.EventHandler(this.Btn_Sumar_Click);
            // 
            // FuncionesAcincronas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Sumar);
            this.Controls.Add(this.Btn_Sumar);
            this.Controls.Add(this.Lbl_Resultato);
            this.Controls.Add(this.Btn_Ejecutar);
            this.Name = "FuncionesAcincronas";
            this.Text = "FuncionesAcincronas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ejecutar;
        private System.Windows.Forms.Label Lbl_Resultato;
        private System.Windows.Forms.Label Lbl_Sumar;
        private System.Windows.Forms.Button Btn_Sumar;
    }
}