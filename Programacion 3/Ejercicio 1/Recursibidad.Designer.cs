
namespace Ejercicio_1
{
    partial class Recursibidad
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
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_For = new System.Windows.Forms.Button();
            this.Txt_Factorial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(97, 52);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mostrar.TabIndex = 0;
            this.Btn_Mostrar.Text = "Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(202, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 1;
            // 
            // Btn_For
            // 
            this.Btn_For.Location = new System.Drawing.Point(97, 114);
            this.Btn_For.Name = "Btn_For";
            this.Btn_For.Size = new System.Drawing.Size(75, 23);
            this.Btn_For.TabIndex = 2;
            this.Btn_For.Text = "For";
            this.Btn_For.UseVisualStyleBackColor = true;
            this.Btn_For.Click += new System.EventHandler(this.Btn_For_Click);
            // 
            // Txt_Factorial
            // 
            this.Txt_Factorial.Location = new System.Drawing.Point(86, 277);
            this.Txt_Factorial.Name = "Txt_Factorial";
            this.Txt_Factorial.Size = new System.Drawing.Size(100, 20);
            this.Txt_Factorial.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Factorial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recursibidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Factorial);
            this.Controls.Add(this.Btn_For);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Btn_Mostrar);
            this.Name = "Recursibidad";
            this.Text = "Recursibidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Mostrar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Btn_For;
        private System.Windows.Forms.TextBox Txt_Factorial;
        private System.Windows.Forms.Button button1;
    }
}