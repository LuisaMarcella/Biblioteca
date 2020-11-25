namespace Biblioteca.Busquedas
{
    partial class frmBusquedaLibros
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
            this.components = new System.ComponentModel.Container();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgLibros = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEditorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vLibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLibros = new Biblioteca.dsLibros();
            this.vLibrosTableAdapter = new Biblioteca.dsLibrosTableAdapters.vLibrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLibrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1120, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(1021, 503);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 29);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgLibros
            // 
            this.dgLibros.AllowUserToAddRows = false;
            this.dgLibros.AllowUserToDeleteRows = false;
            this.dgLibros.AutoGenerateColumns = false;
            this.dgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.idAutorDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.idGeneroDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.idEditorialDataGridViewTextBoxColumn,
            this.editorialDataGridViewTextBoxColumn,
            this.fechaPublicacionDataGridViewTextBoxColumn});
            this.dgLibros.DataSource = this.vLibrosBindingSource;
            this.dgLibros.Location = new System.Drawing.Point(33, 74);
            this.dgLibros.Name = "dgLibros";
            this.dgLibros.ReadOnly = true;
            this.dgLibros.Size = new System.Drawing.Size(1180, 423);
            this.dgLibros.TabIndex = 5;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(33, 37);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(1180, 26);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 200;
            // 
            // idAutorDataGridViewTextBoxColumn
            // 
            this.idAutorDataGridViewTextBoxColumn.DataPropertyName = "idAutor";
            this.idAutorDataGridViewTextBoxColumn.HeaderText = "idAutor";
            this.idAutorDataGridViewTextBoxColumn.Name = "idAutorDataGridViewTextBoxColumn";
            this.idAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAutorDataGridViewTextBoxColumn.Visible = false;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Width = 200;
            // 
            // idGeneroDataGridViewTextBoxColumn
            // 
            this.idGeneroDataGridViewTextBoxColumn.DataPropertyName = "idGenero";
            this.idGeneroDataGridViewTextBoxColumn.HeaderText = "idGenero";
            this.idGeneroDataGridViewTextBoxColumn.Name = "idGeneroDataGridViewTextBoxColumn";
            this.idGeneroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGeneroDataGridViewTextBoxColumn.Visible = false;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generoDataGridViewTextBoxColumn.Width = 200;
            // 
            // idEditorialDataGridViewTextBoxColumn
            // 
            this.idEditorialDataGridViewTextBoxColumn.DataPropertyName = "idEditorial";
            this.idEditorialDataGridViewTextBoxColumn.HeaderText = "idEditorial";
            this.idEditorialDataGridViewTextBoxColumn.Name = "idEditorialDataGridViewTextBoxColumn";
            this.idEditorialDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEditorialDataGridViewTextBoxColumn.Visible = false;
            // 
            // editorialDataGridViewTextBoxColumn
            // 
            this.editorialDataGridViewTextBoxColumn.DataPropertyName = "Editorial";
            this.editorialDataGridViewTextBoxColumn.HeaderText = "Editorial";
            this.editorialDataGridViewTextBoxColumn.Name = "editorialDataGridViewTextBoxColumn";
            this.editorialDataGridViewTextBoxColumn.ReadOnly = true;
            this.editorialDataGridViewTextBoxColumn.Width = 200;
            // 
            // fechaPublicacionDataGridViewTextBoxColumn
            // 
            this.fechaPublicacionDataGridViewTextBoxColumn.DataPropertyName = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Publicación";
            this.fechaPublicacionDataGridViewTextBoxColumn.Name = "fechaPublicacionDataGridViewTextBoxColumn";
            this.fechaPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaPublicacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // vLibrosBindingSource
            // 
            this.vLibrosBindingSource.DataMember = "vLibros";
            this.vLibrosBindingSource.DataSource = this.dsLibros;
            // 
            // dsLibros
            // 
            this.dsLibros.DataSetName = "dsLibros";
            this.dsLibros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vLibrosTableAdapter
            // 
            this.vLibrosTableAdapter.ClearBeforeFill = true;
            // 
            // frmBusquedaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 560);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgLibros);
            this.Controls.Add(this.txtFiltro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBusquedaLibros";
            this.Text = "Búqueda Libros";
            this.Load += new System.EventHandler(this.frmBusquedaLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLibrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgLibros;
        private System.Windows.Forms.TextBox txtFiltro;
        public dsLibros dsLibros;
        public System.Windows.Forms.BindingSource vLibrosBindingSource;
        public dsLibrosTableAdapters.vLibrosTableAdapter vLibrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEditorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacionDataGridViewTextBoxColumn;
    }
}