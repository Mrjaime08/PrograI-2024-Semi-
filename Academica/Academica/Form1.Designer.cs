
namespace Academica
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LBLCodigoAlumno = new System.Windows.Forms.Label();
            this.LBLNombreAlumno = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LBLDireccionAlumno = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 0;
            // 
            // LBLCodigoAlumno
            // 
            this.LBLCodigoAlumno.AutoSize = true;
            this.LBLCodigoAlumno.Location = new System.Drawing.Point(202, 87);
            this.LBLCodigoAlumno.Name = "LBLCodigoAlumno";
            this.LBLCodigoAlumno.Size = new System.Drawing.Size(56, 17);
            this.LBLCodigoAlumno.TabIndex = 1;
            this.LBLCodigoAlumno.Text = "Código:";
            // 
            // LBLNombreAlumno
            // 
            this.LBLNombreAlumno.AutoSize = true;
            this.LBLNombreAlumno.Location = new System.Drawing.Point(202, 146);
            this.LBLNombreAlumno.Name = "LBLNombreAlumno";
            this.LBLNombreAlumno.Size = new System.Drawing.Size(62, 17);
            this.LBLNombreAlumno.TabIndex = 3;
            this.LBLNombreAlumno.Text = "Nombre:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 22);
            this.textBox2.TabIndex = 2;
            // 
            // LBLDireccionAlumno
            // 
            this.LBLDireccionAlumno.AutoSize = true;
            this.LBLDireccionAlumno.Location = new System.Drawing.Point(202, 202);
            this.LBLDireccionAlumno.Name = "LBLDireccionAlumno";
            this.LBLDireccionAlumno.Size = new System.Drawing.Size(71, 17);
            this.LBLDireccionAlumno.TabIndex = 5;
            this.LBLDireccionAlumno.Text = "Dirección:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(333, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dirección:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(292, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(333, 22);
            this.textBox4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dirección:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(292, 286);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(333, 22);
            this.textBox5.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.LBLDireccionAlumno);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LBLNombreAlumno);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LBLCodigoAlumno);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LBLCodigoAlumno;
        private System.Windows.Forms.Label LBLNombreAlumno;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LBLDireccionAlumno;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
    }
}

