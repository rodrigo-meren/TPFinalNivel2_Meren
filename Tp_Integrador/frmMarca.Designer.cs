namespace Tp_Integrador
{
    partial class frmMarca
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
            this.txtMaarca = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaarca
            // 
            this.txtMaarca.Location = new System.Drawing.Point(52, 46);
            this.txtMaarca.Name = "txtMaarca";
            this.txtMaarca.Size = new System.Drawing.Size(120, 20);
            this.txtMaarca.TabIndex = 21;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(61, 9);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(103, 17);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Nueva Marca";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAgregar.Location = new System.Drawing.Point(75, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(233, 150);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtMaarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(249, 189);
            this.MinimumSize = new System.Drawing.Size(249, 189);
            this.Name = "frmMarca";
            this.Text = "Nueva Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAgregar;
    }
}