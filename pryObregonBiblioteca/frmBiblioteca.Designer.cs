namespace pryObregonBiblioteca
{
    partial class frmBiblioteca
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
            this.lstNombre = new System.Windows.Forms.ListBox();
            this.lstCodigo = new System.Windows.Forms.ListBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtCodigoDistr = new System.Windows.Forms.TextBox();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.txtCodigoEdit = new System.Windows.Forms.TextBox();
            this.lblCodigoDistruibidor = new System.Windows.Forms.Label();
            this.lblCodigoAutor = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNombre
            // 
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Location = new System.Drawing.Point(188, 50);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(220, 17);
            this.lstNombre.TabIndex = 25;
            // 
            // lstCodigo
            // 
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(188, 12);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(74, 17);
            this.lstCodigo.TabIndex = 24;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(218, 212);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(190, 34);
            this.btnSiguiente.TabIndex = 23;
            this.btnSiguiente.Text = ">>>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(12, 212);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(190, 34);
            this.btnAtras.TabIndex = 22;
            this.btnAtras.Text = "<<<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtCodigoDistr
            // 
            this.txtCodigoDistr.Location = new System.Drawing.Point(188, 170);
            this.txtCodigoDistr.Name = "txtCodigoDistr";
            this.txtCodigoDistr.Size = new System.Drawing.Size(74, 20);
            this.txtCodigoDistr.TabIndex = 21;
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Location = new System.Drawing.Point(188, 129);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.Size = new System.Drawing.Size(74, 20);
            this.txtCodigoAutor.TabIndex = 20;
            // 
            // txtCodigoEdit
            // 
            this.txtCodigoEdit.Location = new System.Drawing.Point(188, 88);
            this.txtCodigoEdit.Name = "txtCodigoEdit";
            this.txtCodigoEdit.Size = new System.Drawing.Size(74, 20);
            this.txtCodigoEdit.TabIndex = 19;
            // 
            // lblCodigoDistruibidor
            // 
            this.lblCodigoDistruibidor.AutoSize = true;
            this.lblCodigoDistruibidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDistruibidor.Location = new System.Drawing.Point(12, 170);
            this.lblCodigoDistruibidor.Name = "lblCodigoDistruibidor";
            this.lblCodigoDistruibidor.Size = new System.Drawing.Size(131, 15);
            this.lblCodigoDistruibidor.TabIndex = 18;
            this.lblCodigoDistruibidor.Text = "Codigo Distriubidor";
            // 
            // lblCodigoAutor
            // 
            this.lblCodigoAutor.AutoSize = true;
            this.lblCodigoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAutor.Location = new System.Drawing.Point(54, 130);
            this.lblCodigoAutor.Name = "lblCodigoAutor";
            this.lblCodigoAutor.Size = new System.Drawing.Size(89, 15);
            this.lblCodigoAutor.TabIndex = 17;
            this.lblCodigoAutor.Text = "Codigo Autor";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLibro.Location = new System.Drawing.Point(48, 50);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(95, 15);
            this.lblNombreLibro.TabIndex = 16;
            this.lblNombreLibro.Text = "Nombre Libro";
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.AutoSize = true;
            this.lblCodigoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEditorial.Location = new System.Drawing.Point(33, 88);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(110, 15);
            this.lblCodigoEditorial.TabIndex = 15;
            this.lblCodigoEditorial.Text = "Codigo Editorial";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(91, 14);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 15);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryObregonBiblioteca.Properties.Resources._6cecf1_5412c9114e9048a1b291795621a016fe_mv2;
            this.pictureBox1.Location = new System.Drawing.Point(287, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryObregonBiblioteca.Properties.Resources.HD_wallpaper_colorful_stripes_library_designs_mate;
            this.ClientSize = new System.Drawing.Size(420, 258);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstNombre);
            this.Controls.Add(this.lstCodigo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtCodigoDistr);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.txtCodigoEdit);
            this.Controls.Add(this.lblCodigoDistruibidor);
            this.Controls.Add(this.lblCodigoAutor);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmBiblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNombre;
        private System.Windows.Forms.ListBox lstCodigo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtCodigoDistr;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.TextBox txtCodigoEdit;
        private System.Windows.Forms.Label lblCodigoDistruibidor;
        private System.Windows.Forms.Label lblCodigoAutor;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}