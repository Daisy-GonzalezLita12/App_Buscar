namespace GUI_V_2
{
    partial class Descarga_de_horarios
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
            this.btn_iniciar_descarga = new System.Windows.Forms.Button();
            this.textContador = new System.Windows.Forms.TextBox();
            this.textResultados = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_iniciar_descarga
            // 
            this.btn_iniciar_descarga.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_iniciar_descarga.Location = new System.Drawing.Point(10, 24);
            this.btn_iniciar_descarga.Name = "btn_iniciar_descarga";
            this.btn_iniciar_descarga.Size = new System.Drawing.Size(295, 36);
            this.btn_iniciar_descarga.TabIndex = 0;
            this.btn_iniciar_descarga.Text = "Iniciar descarga";
            this.btn_iniciar_descarga.UseVisualStyleBackColor = false;
            // 
            // textContador
            // 
            this.textContador.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textContador.Location = new System.Drawing.Point(8, 110);
            this.textContador.Name = "textContador";
            this.textContador.Size = new System.Drawing.Size(26, 20);
            this.textContador.TabIndex = 1;
            // 
            // textResultados
            // 
            this.textResultados.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textResultados.Location = new System.Drawing.Point(196, 208);
            this.textResultados.Name = "textResultados";
            this.textResultados.Size = new System.Drawing.Size(109, 20);
            this.textResultados.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Location = new System.Drawing.Point(40, 110);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(265, 26);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porcentaje :";
            // 
            // Descarga_de_horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textResultados);
            this.Controls.Add(this.textContador);
            this.Controls.Add(this.btn_iniciar_descarga);
            this.Name = "Descarga_de_horarios";
            this.Text = "Descarga_de_horarios";
            this.Load += new System.EventHandler(this.Descarga_de_horarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciar_descarga;
        private System.Windows.Forms.TextBox textContador;
        private System.Windows.Forms.TextBox textResultados;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}