namespace Tp_Integrador
{
    partial class Catalogo
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pcbArticulos = new System.Windows.Forms.PictureBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(30, 89);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(669, 255);
            this.dgvArticulos.StandardTab = true;
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pcbArticulos
            // 
            this.pcbArticulos.Location = new System.Drawing.Point(707, 89);
            this.pcbArticulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pcbArticulos.Name = "pcbArticulos";
            this.pcbArticulos.Size = new System.Drawing.Size(324, 255);
            this.pcbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbArticulos.TabIndex = 1;
            this.pcbArticulos.TabStop = false;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(504, 19);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(116, 23);
            this.txtFiltroAvanzado.TabIndex = 25;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(294, 19);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(140, 24);
            this.cboCriterio.TabIndex = 24;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(84, 19);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(140, 24);
            this.cboCampo.TabIndex = 23;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(449, 23);
            this.lblFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(35, 13);
            this.lblFiltroAvanzado.TabIndex = 22;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(239, 23);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(47, 13);
            this.lblCriterio.TabIndex = 21;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(29, 23);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(45, 13);
            this.lblCampo.TabIndex = 20;
            this.lblCampo.Text = "Campo";
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFiltro.Location = new System.Drawing.Point(635, 18);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(88, 23);
            this.btnFiltro.TabIndex = 19;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEliminarFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFisico.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarFisico.Location = new System.Drawing.Point(105, 415);
            this.btnEliminarFisico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(132, 23);
            this.btnEliminarFisico.TabIndex = 17;
            this.btnEliminarFisico.Text = "Eliminar Articulo";
            this.btnEliminarFisico.UseVisualStyleBackColor = false;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(267, 366);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(146, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar Articulo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(111, 366);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(30, 33);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(254, 20);
            this.txtFiltro.TabIndex = 27;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(102, 12);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(117, 17);
            this.lblFiltro.TabIndex = 26;
            this.lblFiltro.Text = "Buscar articulo";
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Location = new System.Drawing.Point(267, 415);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(146, 23);
            this.btnDetalle.TabIndex = 28;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.Location = new System.Drawing.Point(441, 366);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(146, 23);
            this.btnAgregarMarca.TabIndex = 29;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAgregarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCat.Location = new System.Drawing.Point(441, 415);
            this.btnAgregarCat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(146, 23);
            this.btnAgregarCat.TabIndex = 30;
            this.btnAgregarCat.Text = "Agregar Categoria";
            this.btnAgregarCat.UseVisualStyleBackColor = false;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiltroAvanzado);
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.lblCampo);
            this.groupBox1.Controls.Add(this.lblCriterio);
            this.groupBox1.Controls.Add(this.lblFiltroAvanzado);
            this.groupBox1.Controls.Add(this.cboCampo);
            this.groupBox1.Controls.Add(this.cboCriterio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(372, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(735, 59);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Avanzada";
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1136, 487);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarCat);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pcbArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pcbArticulos;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

