﻿namespace pryEstructuraDatos
{
    partial class frmListaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaSimple));
            this.mrcMostrar = new System.Windows.Forms.GroupBox();
            this.lstMostrar = new System.Windows.Forms.ListBox();
            this.grlMostrar = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picCola = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mrcElementoNuevo = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lstCodigo = new System.Windows.Forms.ComboBox();
            this.mrcMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grlMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcElementoNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcMostrar
            // 
            this.mrcMostrar.Controls.Add(this.lstMostrar);
            this.mrcMostrar.Controls.Add(this.grlMostrar);
            this.mrcMostrar.Location = new System.Drawing.Point(12, 173);
            this.mrcMostrar.Name = "mrcMostrar";
            this.mrcMostrar.Size = new System.Drawing.Size(573, 183);
            this.mrcMostrar.TabIndex = 12;
            this.mrcMostrar.TabStop = false;
            this.mrcMostrar.Text = "Listado en una Lista y una Grilla";
            // 
            // lstMostrar
            // 
            this.lstMostrar.FormattingEnabled = true;
            this.lstMostrar.Location = new System.Drawing.Point(6, 19);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(173, 160);
            this.lstMostrar.TabIndex = 5;
            // 
            // grlMostrar
            // 
            this.grlMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.Columna2,
            this.Columna3});
            this.grlMostrar.Location = new System.Drawing.Point(185, 19);
            this.grlMostrar.Name = "grlMostrar";
            this.grlMostrar.Size = new System.Drawing.Size(385, 160);
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
            this.picCola.Size = new System.Drawing.Size(173, 155);
            this.picCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCola.TabIndex = 11;
            this.picCola.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(398, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.lstCodigo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEliminar);
            this.mrcElementoEliminado.Location = new System.Drawing.Point(398, 12);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(181, 126);
            this.mrcElementoEliminado.TabIndex = 10;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Elimnado:";
            this.mrcElementoEliminado.Enter += new System.EventHandler(this.mrcElementoEliminado_Enter);
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(6, 95);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEliminar.TabIndex = 1;
            this.lblCodigoEliminar.Text = "Código:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(191, 144);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(181, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // mrcElementoNuevo
            // 
            this.mrcElementoNuevo.Controls.Add(this.txtNombre);
            this.mrcElementoNuevo.Controls.Add(this.txtTramite);
            this.mrcElementoNuevo.Controls.Add(this.lblTramite);
            this.mrcElementoNuevo.Controls.Add(this.lblNombre);
            this.mrcElementoNuevo.Controls.Add(this.txtCodigo);
            this.mrcElementoNuevo.Controls.Add(this.lblCodigo);
            this.mrcElementoNuevo.Location = new System.Drawing.Point(191, 12);
            this.mrcElementoNuevo.Name = "mrcElementoNuevo";
            this.mrcElementoNuevo.Size = new System.Drawing.Size(181, 126);
            this.mrcElementoNuevo.TabIndex = 8;
            this.mrcElementoNuevo.TabStop = false;
            this.mrcElementoNuevo.Text = "Nuevo Elemento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(67, 95);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 95);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 4;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lstCodigo
            // 
            this.lstCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(54, 95);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(121, 21);
            this.lstCodigo.TabIndex = 2;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 371);
            this.Controls.Add(this.mrcMostrar);
            this.Controls.Add(this.picCola);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.mrcElementoNuevo);
            this.Name = "frmListaSimple";
            this.Text = "frmListaSimple";
            this.mrcMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grlMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCola)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcElementoNuevo.ResumeLayout(false);
            this.mrcElementoNuevo.PerformLayout();
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
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox mrcElementoNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox lstCodigo;
    }
}