namespace Ejemplo01
{
    partial class Form1
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
            this.txtboxMensaje = new System.Windows.Forms.TextBox();
            this.btnMuestraMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxMensaje
            // 
            this.txtboxMensaje.Location = new System.Drawing.Point(91, 26);
            this.txtboxMensaje.Name = "txtboxMensaje";
            this.txtboxMensaje.Size = new System.Drawing.Size(100, 20);
            this.txtboxMensaje.TabIndex = 0;
            // 
            // btnMuestraMensaje
            // 
            this.btnMuestraMensaje.Location = new System.Drawing.Point(104, 100);
            this.btnMuestraMensaje.Name = "btnMuestraMensaje";
            this.btnMuestraMensaje.Size = new System.Drawing.Size(75, 23);
            this.btnMuestraMensaje.TabIndex = 1;
            this.btnMuestraMensaje.Text = "Mensaje";
            this.btnMuestraMensaje.UseVisualStyleBackColor = true;
            this.btnMuestraMensaje.Click += new System.EventHandler(this.btnMuestraMensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMuestraMensaje);
            this.Controls.Add(this.txtboxMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxMensaje;
        private System.Windows.Forms.Button btnMuestraMensaje;
    }
}

