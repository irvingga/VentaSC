namespace SisVentasCS
{
    partial class AddArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArticulo));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxListaArticulos = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbusquedaBD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxestado = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureproducto = new System.Windows.Forms.PictureBox();
            this.btncargarimagen = new System.Windows.Forms.Button();
            this.txtphatimagen = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bntclosebuscar = new System.Windows.Forms.PictureBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnAddArticulo = new System.Windows.Forms.Button();
            this.txtpresentacion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBoxListaArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureproducto)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntclosebuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE UN NUEVO PRODUCTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.groupBoxListaArticulos);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 405);
            this.panel1.TabIndex = 12;
            // 
            // groupBoxListaArticulos
            // 
            this.groupBoxListaArticulos.Controls.Add(this.dataGridView1);
            this.groupBoxListaArticulos.Controls.Add(this.panel4);
            this.groupBoxListaArticulos.Controls.Add(this.label7);
            this.groupBoxListaArticulos.Controls.Add(this.txtbusquedaBD);
            this.groupBoxListaArticulos.Controls.Add(this.button1);
            this.groupBoxListaArticulos.Location = new System.Drawing.Point(317, 18);
            this.groupBoxListaArticulos.Name = "groupBoxListaArticulos";
            this.groupBoxListaArticulos.Size = new System.Drawing.Size(412, 355);
            this.groupBoxListaArticulos.TabIndex = 25;
            this.groupBoxListaArticulos.TabStop = false;
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
            this.btnEliminar.Location = new System.Drawing.Point(229, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnmodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.ForeColor = System.Drawing.Color.LightGray;
            this.btnmodificar.Location = new System.Drawing.Point(14, 8);
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
            this.label7.Size = new System.Drawing.Size(244, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "BUSCAR  PRODUCTO (NOMBRE/CODIGO)";
            // 
            // txtbusquedaBD
            // 
            this.txtbusquedaBD.Location = new System.Drawing.Point(26, 34);
            this.txtbusquedaBD.Name = "txtbusquedaBD";
            this.txtbusquedaBD.Size = new System.Drawing.Size(256, 20);
            this.txtbusquedaBD.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Controls.Add(this.comboBoxestado);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pictureproducto);
            this.groupBox1.Controls.Add(this.btncargarimagen);
            this.groupBox1.Controls.Add(this.txtphatimagen);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtpresentacion);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 335);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(163, 182);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(50, 16);
            this.labelEstado.TabIndex = 30;
            this.labelEstado.Text = "ESTADO";
            // 
            // comboBoxestado
            // 
            this.comboBoxestado.DisplayMember = "(ninguno)";
            this.comboBoxestado.FormattingEnabled = true;
            this.comboBoxestado.Items.AddRange(new object[] {
            "Activo",
            "Desactivo"});
            this.comboBoxestado.Location = new System.Drawing.Point(166, 199);
            this.comboBoxestado.Name = "comboBoxestado";
            this.comboBoxestado.Size = new System.Drawing.Size(101, 21);
            this.comboBoxestado.TabIndex = 29;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureproducto
            // 
            this.pictureproducto.InitialImage = null;
            this.pictureproducto.Location = new System.Drawing.Point(20, 155);
            this.pictureproducto.Name = "pictureproducto";
            this.pictureproducto.Size = new System.Drawing.Size(100, 103);
            this.pictureproducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureproducto.TabIndex = 27;
            this.pictureproducto.TabStop = false;
            // 
            // btncargarimagen
            // 
            this.btncargarimagen.AutoEllipsis = true;
            this.btncargarimagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btncargarimagen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btncargarimagen.FlatAppearance.BorderSize = 0;
            this.btncargarimagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btncargarimagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.btncargarimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargarimagen.ForeColor = System.Drawing.Color.LightGray;
            this.btncargarimagen.Location = new System.Drawing.Point(135, 232);
            this.btncargarimagen.Name = "btncargarimagen";
            this.btncargarimagen.Size = new System.Drawing.Size(144, 23);
            this.btncargarimagen.TabIndex = 26;
            this.btncargarimagen.Text = "CARGAR IMAGEN";
            this.btncargarimagen.UseVisualStyleBackColor = false;
            this.btncargarimagen.Click += new System.EventHandler(this.btncargarimagen_Click);
            // 
            // txtphatimagen
            // 
            this.txtphatimagen.Location = new System.Drawing.Point(20, 265);
            this.txtphatimagen.Name = "txtphatimagen";
            this.txtphatimagen.Size = new System.Drawing.Size(263, 20);
            this.txtphatimagen.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.bntclosebuscar);
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Controls.Add(this.btnAddArticulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 292);
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
           
            this.btnbuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbuscar_MouseClick);
            // 
            // btnAddArticulo
            // 
            this.btnAddArticulo.AutoEllipsis = true;
            this.btnAddArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddArticulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddArticulo.FlatAppearance.BorderSize = 0;
            this.btnAddArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAddArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.btnAddArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticulo.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddArticulo.Location = new System.Drawing.Point(18, 6);
            this.btnAddArticulo.Name = "btnAddArticulo";
            this.btnAddArticulo.Size = new System.Drawing.Size(95, 30);
            this.btnAddArticulo.TabIndex = 22;
            this.btnAddArticulo.Text = "AGREGAR";
            this.btnAddArticulo.UseVisualStyleBackColor = false;
            this.btnAddArticulo.Click += new System.EventHandler(this.btnAddArticulo_Click);
            // 
            // txtpresentacion
            // 
            this.txtpresentacion.Location = new System.Drawing.Point(166, 104);
            this.txtpresentacion.Name = "txtpresentacion";
            this.txtpresentacion.Size = new System.Drawing.Size(100, 20);
            this.txtpresentacion.TabIndex = 18;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "DESCRIPCIÓN";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(166, 155);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtdescripcion.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "CATEGORIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "PRESENTACION";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(20, 105);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "CODIGO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(110)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 11);
            this.panel2.TabIndex = 23;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(713, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 25);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 25;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // AddArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(741, 460);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddArticulo";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddArticulo";
            this.Load += new System.EventHandler(this.AddArticulo_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxListaArticulos.ResumeLayout(false);
            this.groupBoxListaArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureproducto)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bntclosebuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpresentacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btncargarimagen;
        private System.Windows.Forms.TextBox txtphatimagen;
        private System.Windows.Forms.PictureBox pictureproducto;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox groupBoxListaArticulos;
        private System.Windows.Forms.PictureBox bntclosebuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbusquedaBD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxestado;
        private System.Windows.Forms.Button btnEliminar;
    }
}