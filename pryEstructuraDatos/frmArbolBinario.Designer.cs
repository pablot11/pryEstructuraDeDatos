namespace pryEstructuraDatos
{
    partial class frmArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolBinario));
            this.mrcMostrar = new System.Windows.Forms.GroupBox();
            this.lstMostrar = new System.Windows.Forms.ListBox();
            this.grlMostrar = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picCola = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mrcElementoNuevo = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mrcOrden = new System.Windows.Forms.GroupBox();
            this.optInOrden = new System.Windows.Forms.RadioButton();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optAsc = new System.Windows.Forms.RadioButton();
            this.optDes = new System.Windows.Forms.RadioButton();
            this.tvMostrar = new System.Windows.Forms.TreeView();
            this.mrcForma = new System.Windows.Forms.GroupBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEquilibrarArbol = new System.Windows.Forms.Button();
            this.mrcMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grlMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcElementoNuevo.SuspendLayout();
            this.mrcOrden.SuspendLayout();
            this.mrcForma.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcMostrar
            // 
            this.mrcMostrar.Controls.Add(this.lstMostrar);
            this.mrcMostrar.Controls.Add(this.grlMostrar);
            this.mrcMostrar.Location = new System.Drawing.Point(12, 196);
            this.mrcMostrar.Name = "mrcMostrar";
            this.mrcMostrar.Size = new System.Drawing.Size(572, 188);
            this.mrcMostrar.TabIndex = 18;
            this.mrcMostrar.TabStop = false;
            this.mrcMostrar.Text = "Listado en una Lista y una Grilla";
            // 
            // lstMostrar
            // 
            this.lstMostrar.FormattingEnabled = true;
            this.lstMostrar.Location = new System.Drawing.Point(6, 19);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(168, 160);
            this.lstMostrar.TabIndex = 5;
            // 
            // grlMostrar
            // 
            this.grlMostrar.AllowUserToAddRows = false;
            this.grlMostrar.AllowUserToDeleteRows = false;
            this.grlMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.Columna2,
            this.Columna3});
            this.grlMostrar.Location = new System.Drawing.Point(180, 19);
            this.grlMostrar.Name = "grlMostrar";
            this.grlMostrar.ReadOnly = true;
            this.grlMostrar.Size = new System.Drawing.Size(367, 160);
            this.grlMostrar.TabIndex = 3;
            // 
            // columna1
            // 
            this.columna1.HeaderText = "Código";
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "Nombre";
            this.Columna2.Name = "Columna2";
            this.Columna2.ReadOnly = true;
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "Trámite";
            this.Columna3.Name = "Columna3";
            this.Columna3.ReadOnly = true;
            // 
            // picCola
            // 
            this.picCola.Image = ((System.Drawing.Image)(resources.GetObject("picCola.Image")));
            this.picCola.Location = new System.Drawing.Point(12, 12);
            this.picCola.Name = "picCola";
            this.picCola.Size = new System.Drawing.Size(173, 178);
            this.picCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCola.TabIndex = 17;
            this.picCola.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(9, 67);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 21);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.btnBuscar);
            this.mrcElementoEliminado.Controls.Add(this.lstCodigo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEliminar);
            this.mrcElementoEliminado.Controls.Add(this.btnEliminar);
            this.mrcElementoEliminado.Location = new System.Drawing.Point(378, 12);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(205, 123);
            this.mrcElementoEliminado.TabIndex = 16;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Elimnado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(101, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstCodigo
            // 
            this.lstCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(55, 40);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(133, 21);
            this.lstCodigo.TabIndex = 5;
            this.lstCodigo.SelectedIndexChanged += new System.EventHandler(this.lstCodigo_SelectedIndexChanged);
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(6, 40);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminar.TabIndex = 1;
            this.lblCodigoEliminar.Text = "Código:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(9, 145);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mrcElementoNuevo
            // 
            this.mrcElementoNuevo.Controls.Add(this.txtNombre);
            this.mrcElementoNuevo.Controls.Add(this.txtTramite);
            this.mrcElementoNuevo.Controls.Add(this.lblTramite);
            this.mrcElementoNuevo.Controls.Add(this.lblNombre);
            this.mrcElementoNuevo.Controls.Add(this.btnAgregar);
            this.mrcElementoNuevo.Controls.Add(this.txtCodigo);
            this.mrcElementoNuevo.Controls.Add(this.lblCodigo);
            this.mrcElementoNuevo.Location = new System.Drawing.Point(191, 12);
            this.mrcElementoNuevo.Name = "mrcElementoNuevo";
            this.mrcElementoNuevo.Size = new System.Drawing.Size(181, 178);
            this.mrcElementoNuevo.TabIndex = 15;
            this.mrcElementoNuevo.TabStop = false;
            this.mrcElementoNuevo.Text = "Nuevo Elemento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 68);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(67, 103);
            this.txtTramite.MaxLength = 15;
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 3;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 103);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 4;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 33);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // mrcOrden
            // 
            this.mrcOrden.Controls.Add(this.optInOrden);
            this.mrcOrden.Controls.Add(this.optPostOrden);
            this.mrcOrden.Controls.Add(this.optPreOrden);
            this.mrcOrden.Location = new System.Drawing.Point(589, 12);
            this.mrcOrden.Name = "mrcOrden";
            this.mrcOrden.Size = new System.Drawing.Size(173, 97);
            this.mrcOrden.TabIndex = 19;
            this.mrcOrden.TabStop = false;
            this.mrcOrden.Text = "Listar en Orden:";
            // 
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Location = new System.Drawing.Point(15, 19);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(63, 17);
            this.optInOrden.TabIndex = 7;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "InOrden";
            this.optInOrden.UseVisualStyleBackColor = true;
            this.optInOrden.CheckedChanged += new System.EventHandler(this.optInOrden_CheckedChanged);
            this.optInOrden.Click += new System.EventHandler(this.optInOrden_Click);
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(15, 42);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(75, 17);
            this.optPostOrden.TabIndex = 8;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "PostOrden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            this.optPostOrden.Click += new System.EventHandler(this.optPostOrden_Click);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(15, 65);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(70, 17);
            this.optPreOrden.TabIndex = 9;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "PreOrden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.Click += new System.EventHandler(this.optPreOrden_Click);
            // 
            // optAsc
            // 
            this.optAsc.AutoSize = true;
            this.optAsc.Location = new System.Drawing.Point(15, 19);
            this.optAsc.Name = "optAsc";
            this.optAsc.Size = new System.Drawing.Size(82, 17);
            this.optAsc.TabIndex = 10;
            this.optAsc.TabStop = true;
            this.optAsc.Text = "Ascendente";
            this.optAsc.UseVisualStyleBackColor = true;
            this.optAsc.CheckedChanged += new System.EventHandler(this.optAsc_CheckedChanged);
            this.optAsc.Click += new System.EventHandler(this.optAsc_Click);
            // 
            // optDes
            // 
            this.optDes.AutoSize = true;
            this.optDes.Location = new System.Drawing.Point(15, 45);
            this.optDes.Name = "optDes";
            this.optDes.Size = new System.Drawing.Size(89, 17);
            this.optDes.TabIndex = 11;
            this.optDes.TabStop = true;
            this.optDes.Text = "Descendente";
            this.optDes.UseVisualStyleBackColor = true;
            this.optDes.Click += new System.EventHandler(this.optDes_Click);
            // 
            // tvMostrar
            // 
            this.tvMostrar.Location = new System.Drawing.Point(590, 225);
            this.tvMostrar.Name = "tvMostrar";
            this.tvMostrar.Size = new System.Drawing.Size(173, 159);
            this.tvMostrar.TabIndex = 20;
            // 
            // mrcForma
            // 
            this.mrcForma.Controls.Add(this.optAsc);
            this.mrcForma.Controls.Add(this.optDes);
            this.mrcForma.Location = new System.Drawing.Point(589, 115);
            this.mrcForma.Name = "mrcForma";
            this.mrcForma.Size = new System.Drawing.Size(173, 75);
            this.mrcForma.TabIndex = 23;
            this.mrcForma.TabStop = false;
            this.mrcForma.Text = "Forma:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(589, 196);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(173, 23);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.TabStop = false;
            this.btnGrabar.Text = "Grabar Archivo";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEquilibrarArbol
            // 
            this.btnEquilibrarArbol.Location = new System.Drawing.Point(401, 157);
            this.btnEquilibrarArbol.Name = "btnEquilibrarArbol";
            this.btnEquilibrarArbol.Size = new System.Drawing.Size(158, 23);
            this.btnEquilibrarArbol.TabIndex = 8;
            this.btnEquilibrarArbol.Text = "Equilibrar";
            this.btnEquilibrarArbol.UseVisualStyleBackColor = true;
            this.btnEquilibrarArbol.Click += new System.EventHandler(this.btnEquilibrarArbol_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 388);
            this.Controls.Add(this.btnEquilibrarArbol);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.mrcForma);
            this.Controls.Add(this.tvMostrar);
            this.Controls.Add(this.mrcOrden);
            this.Controls.Add(this.mrcMostrar);
            this.Controls.Add(this.picCola);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcElementoNuevo);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.mrcMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grlMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcElementoNuevo.ResumeLayout(false);
            this.mrcElementoNuevo.PerformLayout();
            this.mrcOrden.ResumeLayout(false);
            this.mrcOrden.PerformLayout();
            this.mrcForma.ResumeLayout(false);
            this.mrcForma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcMostrar;
        private System.Windows.Forms.ListBox lstMostrar;
        private System.Windows.Forms.DataGridView grlMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna3;
        private System.Windows.Forms.PictureBox picCola;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.ComboBox lstCodigo;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox mrcElementoNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox mrcOrden;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optAsc;
        private System.Windows.Forms.RadioButton optDes;
        private System.Windows.Forms.TreeView tvMostrar;
        private System.Windows.Forms.RadioButton optInOrden;
        private System.Windows.Forms.GroupBox mrcForma;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEquilibrarArbol;
    }
}