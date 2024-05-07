namespace GUI_V_2
{
    partial class CROQUIS
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
            this.DESCARGA = new System.Windows.Forms.Button();
            this.CONTADOR = new System.Windows.Forms.TextBox();
            this.RES = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DESCARGA
            // 
            this.DESCARGA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DESCARGA.Location = new System.Drawing.Point(12, 37);
            this.DESCARGA.Name = "DESCARGA";
            this.DESCARGA.Size = new System.Drawing.Size(200, 30);
            this.DESCARGA.TabIndex = 0;
            this.DESCARGA.Text = "Descargar croquis del Tec";
            this.DESCARGA.UseVisualStyleBackColor = false;
            this.DESCARGA.Click += new System.EventHandler(this.DESCARGA_Click);
            // 
            // CONTADOR
            // 
            this.CONTADOR.BackColor = System.Drawing.SystemColors.Info;
            this.CONTADOR.Location = new System.Drawing.Point(12, 117);
            this.CONTADOR.Name = "CONTADOR";
            this.CONTADOR.Size = new System.Drawing.Size(50, 20);
            this.CONTADOR.TabIndex = 1;
            // 
            // RES
            // 
            this.RES.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RES.Location = new System.Drawing.Point(168, 229);
            this.RES.Name = "RES";
            this.RES.Size = new System.Drawing.Size(104, 20);
            this.RES.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(92, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(142, 27);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proceso de descarga.\r\n";
            // 
            // CROQUIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.RES);
            this.Controls.Add(this.CONTADOR);
            this.Controls.Add(this.DESCARGA);
            this.Name = "CROQUIS";
            this.Text = "CROQUIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DESCARGA;
        private System.Windows.Forms.TextBox CONTADOR;
        private System.Windows.Forms.TextBox RES;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}