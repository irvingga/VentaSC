namespace SisVentasCS
{
    partial class AddCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoria));
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxListaCategoria = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbusquedaBD = new System.Windows.Forms.TextBox();
            this.btnbuscarr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxcondicion = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bntclosebuscar = new System.Windows.Forms.PictureBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdescipcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxListaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntclosebuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(940, 75);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 25);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 28;
            this.btncerrar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.groupBoxListaCategoria);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 405);
            this.panel1.TabIndex = 27;
            // 
            // groupBoxListaCategoria
            // 
            this.groupBoxListaCategoria.Controls.Add(this.dataGridView1);
            this.groupBoxListaCategoria.Controls.Add(this.panel4);
            this.groupBoxListaCategoria.Controls.Add(this.label7);
            this.groupBoxListaCategoria.Controls.Add(this.txtbusquedaBD);
            this.groupBoxListaCategoria.Controls.Add(this.btnbuscarr);
            this.groupBoxListaCategoria.Location = new System.Drawing.Point(317, 18);
            this.groupBoxListaCategoria.Name = "groupBoxListaCategoria";
            this.groupBoxListaCategoria.Size = new System.Drawing.Size(412, 355);
            this.groupBoxListaCategoria.TabIndex = 25;
            this.groupBoxListaCategoria.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 247);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.btnEliminar);
            this.panel4.Controls.Add(this.btnmodificar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 39);
            this.panel4.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEliminar.Location = new System.Drawing.Point(-40, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnmodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.ForeColor = System.Drawing.Color.LightGray;
            this.btnmodificar.Location = new System.Drawing.Point(127, 8);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(161, 23);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "GUARDAR CAMBIOS";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "BUSCAR CATEGORIA (NOMBRE)";
            // 
            // txtbusquedaBD
            // 
            this.txtbusquedaBD.Location = new System.Drawing.Point(26, 34);
            this.txtbusquedaBD.Name = "txtbusquedaBD";
            this.txtbusquedaBD.Size = new System.Drawing.Size(256, 20);
            this.txtbusquedaBD.TabIndex = 2;
            // 
            // btnbuscarr
            // 
            this.btnbuscarr.Location = new System.Drawing.Point(305, 34);
            this.btnbuscarr.Name = "btnbuscarr";
            this.btnbuscarr.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarr.TabIndex = 1;
            this.btnbuscarr.Text = "BUSCAR";
            this.btnbuscarr.UseVisualStyleBackColor = true;
            this.btnbuscarr.Click += new System.EventHandler(this.btnbuscarr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.comboBoxcondicion);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdescipcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 232);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxcondicion
            // 
            this.comboBoxcondicion.DisplayMember = "(ninguno)";
            this.comboBoxcondicion.FormattingEnabled = true;
            this.comboBoxcondicion.Items.AddRange(new object[] {
            "Activo",
            "Desactivo"});
            this.comboBoxcondicion.Location = new System.Drawing.Point(163, 42);
            this.comboBoxcondicion.Name = "comboBoxcondicion";
            this.comboBoxcondicion.Size = new System.Drawing.Size(101, 21);
            this.comboBoxcondicion.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.bntclosebuscar);
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Controls.Add(this.btnAddCategoria);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 40);
            this.panel3.TabIndex = 23;
            // 
            // bntclosebuscar
            // 
            this.bntclosebuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntclosebuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntclosebuscar.Image")));
            this.bntclosebuscar.Location = new System.Drawing.Point(116, 5);
            this.bntclosebuscar.Name = "bntclosebuscar";
            this.bntclosebuscar.Size = new System.Drawing.Size(38, 33);
            this.bntclosebuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntclosebuscar.TabIndex = 26;
            this.bntclosebuscar.TabStop = false;
            this.bntclosebuscar.Click += new System.EventHandler(this.bntclosebuscar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.AutoEllipsis = true;
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.LightGray;
            this.btnbuscar.Location = new System.Drawing.Point(163, 6);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(95, 30);
            this.btnbuscar.TabIndex = 25;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.AutoEllipsis = true;
            this.btnAddCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddCategoria.FlatAppearance.BorderSize = 0;
            this.btnAddCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAddCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.btnAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategoria.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddCategoria.Location = new System.Drawing.Point(18, 6);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(95, 30);
            this.btnAddCategoria.TabIndex = 22;
            this.btnAddCategoria.Text = "AGREGAR";
            this.btnAddCategoria.UseVisualStyleBackColor = false;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddArticulo_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(20, 43);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "NOMBRE ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "PRESENTACION";
            // 
            // txtdescipcion
            // 
            this.txtdescipcion.Location = new System.Drawing.Point(20, 105);
            this.txtdescipcion.Multiline = true;
            this.txtdescipcion.Name = "txtdescipcion";
            this.txtdescipcion.Size = new System.Drawing.Size(247, 65);
            this.txtdescipcion.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "DESCRIPCION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 11);
            this.panel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(143, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "REGISTRO NUEVA CATEGORIA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(708, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(738, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCategoria";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategoria";
            this.Load += new System.EventHandler(this.AddCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxListaCategoria.ResumeLayout(false);
            this.groupBoxListaCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bntclosebuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxListaCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbusquedaBD;
        private System.Windows.Forms.Button btnbuscarr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxcondicion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox bntclosebuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdescipcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}