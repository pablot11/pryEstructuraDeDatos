namespace pryEstructuraDatos
{
    partial class frmBaseDatos
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
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.btnProyeccionMulti = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.mrcProyeccion = new System.Windows.Forms.GroupBox();
            this.mrcSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnSeleccionMulti = new System.Windows.Forms.Button();
            this.btnSeleccionConvulsion = new System.Windows.Forms.Button();
            this.mrcAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.mrcProyeccion.SuspendLayout();
            this.mrcSeleccion.SuspendLayout();
            this.mrcAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(16, 15);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.Size = new System.Drawing.Size(1035, 271);
            this.dgvConsulta.TabIndex = 0;
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(11, 44);
            this.btnProyeccionSimple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(248, 28);
            this.btnProyeccionSimple.TabIndex = 1;
            this.btnProyeccionSimple.Text = "Proyección Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // btnProyeccionMulti
            // 
            this.btnProyeccionMulti.Location = new System.Drawing.Point(11, 101);
            this.btnProyeccionMulti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProyeccionMulti.Name = "btnProyeccionMulti";
            this.btnProyeccionMulti.Size = new System.Drawing.Size(248, 28);
            this.btnProyeccionMulti.TabIndex = 4;
            this.btnProyeccionMulti.Text = "Proyección Multiatributo";
            this.btnProyeccionMulti.UseVisualStyleBackColor = true;
            this.btnProyeccionMulti.Click += new System.EventHandler(this.btnProyeccionMulti_Click);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(11, 161);
            this.btnJuntar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(248, 28);
            this.btnJuntar.TabIndex = 7;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // mrcProyeccion
            // 
            this.mrcProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.mrcProyeccion.Controls.Add(this.btnProyeccionMulti);
            this.mrcProyeccion.Controls.Add(this.btnJuntar);
            this.mrcProyeccion.Location = new System.Drawing.Point(16, 293);
            this.mrcProyeccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcProyeccion.Name = "mrcProyeccion";
            this.mrcProyeccion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcProyeccion.Size = new System.Drawing.Size(267, 207);
            this.mrcProyeccion.TabIndex = 10;
            this.mrcProyeccion.TabStop = false;
            this.mrcProyeccion.Text = "Operaciones de Proyección";
            // 
            // mrcSeleccion
            // 
            this.mrcSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.mrcSeleccion.Controls.Add(this.btnSeleccionMulti);
            this.mrcSeleccion.Controls.Add(this.btnSeleccionConvulsion);
            this.mrcSeleccion.Location = new System.Drawing.Point(400, 293);
            this.mrcSeleccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcSeleccion.Name = "mrcSeleccion";
            this.mrcSeleccion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcSeleccion.Size = new System.Drawing.Size(267, 207);
            this.mrcSeleccion.TabIndex = 11;
            this.mrcSeleccion.TabStop = false;
            this.mrcSeleccion.Text = "Operaciones de Selección";
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(11, 44);
            this.btnSeleccionSimple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(248, 28);
            this.btnSeleccionSimple.TabIndex = 1;
            this.btnSeleccionSimple.Text = "Selección Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // btnSeleccionMulti
            // 
            this.btnSeleccionMulti.Location = new System.Drawing.Point(11, 101);
            this.btnSeleccionMulti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionMulti.Name = "btnSeleccionMulti";
            this.btnSeleccionMulti.Size = new System.Drawing.Size(248, 28);
            this.btnSeleccionMulti.TabIndex = 4;
            this.btnSeleccionMulti.Text = "Selección Multiatributo";
            this.btnSeleccionMulti.UseVisualStyleBackColor = true;
            this.btnSeleccionMulti.Click += new System.EventHandler(this.btnSeleccionMulti_Click);
            // 
            // btnSeleccionConvulsion
            // 
            this.btnSeleccionConvulsion.Location = new System.Drawing.Point(11, 161);
            this.btnSeleccionConvulsion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionConvulsion.Name = "btnSeleccionConvulsion";
            this.btnSeleccionConvulsion.Size = new System.Drawing.Size(248, 28);
            this.btnSeleccionConvulsion.TabIndex = 7;
            this.btnSeleccionConvulsion.Text = "Selección por Convolución";
            this.btnSeleccionConvulsion.UseVisualStyleBackColor = true;
            this.btnSeleccionConvulsion.Click += new System.EventHandler(this.btnSeleccionConvulsion_Click);
            // 
            // mrcAlgebraicas
            // 
            this.mrcAlgebraicas.Controls.Add(this.btnUnion);
            this.mrcAlgebraicas.Controls.Add(this.btnInterseccion);
            this.mrcAlgebraicas.Controls.Add(this.btnDiferencia);
            this.mrcAlgebraicas.Location = new System.Drawing.Point(784, 293);
            this.mrcAlgebraicas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcAlgebraicas.Name = "mrcAlgebraicas";
            this.mrcAlgebraicas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcAlgebraicas.Size = new System.Drawing.Size(267, 207);
            this.mrcAlgebraicas.TabIndex = 12;
            this.mrcAlgebraicas.TabStop = false;
            this.mrcAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(11, 44);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(248, 28);
            this.btnUnion.TabIndex = 1;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(11, 101);
            this.btnInterseccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(248, 28);
            this.btnInterseccion.TabIndex = 4;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(11, 161);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(248, 28);
            this.btnDiferencia.TabIndex = 7;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // frmBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.mrcAlgebraicas);
            this.Controls.Add(this.mrcSeleccion);
            this.Controls.Add(this.mrcProyeccion);
            this.Controls.Add(this.dgvConsulta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBaseDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.mrcProyeccion.ResumeLayout(false);
            this.mrcSeleccion.ResumeLayout(false);
            this.mrcAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.Button btnProyeccionMulti;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.GroupBox mrcProyeccion;
        private System.Windows.Forms.GroupBox mrcSeleccion;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Button btnSeleccionMulti;
        private System.Windows.Forms.Button btnSeleccionConvulsion;
        private System.Windows.Forms.GroupBox mrcAlgebraicas;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnDiferencia;
    }
}