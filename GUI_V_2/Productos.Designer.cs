namespace GUI_V_2
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.btnCerrar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.botonConexion = new System.Windows.Forms.Button();
            this.Croquis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Descargar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.apellido_m = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido_p = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.boton_Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCerrar.Location = new System.Drawing.Point(809, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 17);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(871, 606);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "2. Ingrese el nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(8, 209);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(154, 24);
            this.name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "3. Ingrese el apellido paterno:\r\n\r\n";
            // 
            // boton_buscar
            // 
            this.boton_buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.boton_buscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.boton_buscar.Location = new System.Drawing.Point(9, 455);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(154, 33);
            this.boton_buscar.TabIndex = 9;
            this.boton_buscar.Text = "BUSCAR";
            this.boton_buscar.UseVisualStyleBackColor = false;
            this.boton_buscar.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boton_Actualizar);
            this.panel1.Controls.Add(this.boton_Eliminar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.botonConexion);
            this.panel1.Controls.Add(this.Croquis);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Descargar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.apellido_m);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.apellido_p);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.boton_buscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 533);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(169, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // botonConexion
            // 
            this.botonConexion.BackColor = System.Drawing.Color.SlateBlue;
            this.botonConexion.Location = new System.Drawing.Point(666, 358);
            this.botonConexion.Name = "botonConexion";
            this.botonConexion.Size = new System.Drawing.Size(150, 36);
            this.botonConexion.TabIndex = 15;
            this.botonConexion.Text = "Conectar a base de datos";
            this.botonConexion.UseVisualStyleBackColor = false;
            this.botonConexion.Click += new System.EventHandler(this.botonConexion_Click);
            // 
            // Croquis
            // 
            this.Croquis.BackColor = System.Drawing.Color.SlateBlue;
            this.Croquis.Location = new System.Drawing.Point(667, 400);
            this.Croquis.Name = "Croquis";
            this.Croquis.Size = new System.Drawing.Size(149, 36);
            this.Croquis.TabIndex = 15;
            this.Croquis.Text = "Descargar croquis del Tec ";
            this.Croquis.UseVisualStyleBackColor = false;
            this.Croquis.Click += new System.EventHandler(this.Croquis_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(276, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 270);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Descargar
            // 
            this.Descargar.BackColor = System.Drawing.Color.SlateBlue;
            this.Descargar.Location = new System.Drawing.Point(667, 442);
            this.Descargar.Name = "Descargar";
            this.Descargar.Size = new System.Drawing.Size(149, 36);
            this.Descargar.TabIndex = 12;
            this.Descargar.Text = "Descargar horario ";
            this.Descargar.UseVisualStyleBackColor = false;
            this.Descargar.Click += new System.EventHandler(this.Descargar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "5.Seleccione la opción a realizar:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // apellido_m
            // 
            this.apellido_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_m.Location = new System.Drawing.Point(8, 380);
            this.apellido_m.Name = "apellido_m";
            this.apellido_m.Size = new System.Drawing.Size(154, 24);
            this.apellido_m.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "4. Ingrese el apellido materno:\r\n\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // apellido_p
            // 
            this.apellido_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_p.Location = new System.Drawing.Point(8, 299);
            this.apellido_p.Name = "apellido_p";
            this.apellido_p.Size = new System.Drawing.Size(154, 24);
            this.apellido_p.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(295, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 212);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "1.Ingrese el numero de lista:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(8, 121);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(154, 20);
            this.ID.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(576, 50);
            this.label6.TabIndex = 19;
            this.label6.Text = "Para buscar o elimiar o agregar a un nuevo estudiante o profesor.\r\nFavor de relle" +
    "nar los siguientes campos:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.boton_Eliminar.Location = new System.Drawing.Point(9, 494);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(153, 33);
            this.boton_Eliminar.TabIndex = 20;
            this.boton_Eliminar.Text = "ELIMINAR";
            this.boton_Eliminar.UseVisualStyleBackColor = false;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // boton_Actualizar
            // 
            this.boton_Actualizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.boton_Actualizar.Location = new System.Drawing.Point(169, 494);
            this.boton_Actualizar.Name = "boton_Actualizar";
            this.boton_Actualizar.Size = new System.Drawing.Size(152, 33);
            this.boton_Actualizar.TabIndex = 21;
            this.boton_Actualizar.Text = "ACTUALIZAR";
            this.boton_Actualizar.UseVisualStyleBackColor = false;
            this.boton_Actualizar.Click += new System.EventHandler(this.boton_Actualizar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(871, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Descargar;
        private System.Windows.Forms.Button Croquis;
        private System.Windows.Forms.TextBox apellido_p;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox apellido_m;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonConexion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button boton_Actualizar;
        private System.Windows.Forms.Button boton_Eliminar;
    }
}