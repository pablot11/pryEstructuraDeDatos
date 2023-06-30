namespace pryEstructuraDatos
{
    partial class frmConsultarPorOperaciones
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
            this.lstSentencias = new System.Windows.Forms.ComboBox();
            this.lblElegirConsulta = new System.Windows.Forms.Label();
            this.lblSql = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSentencias
            // 
            this.lstSentencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSentencias.FormattingEnabled = true;
            this.lstSentencias.Items.AddRange(new object[] {
            "Diferencia",
            "Intersección",
            "Juntar",
            "Proyección Simple",
            "Proyección Multiatributo",
            "Selección Multiatributo con operador AND",
            "Selección Multiatributo con operador OR",
            "Selección Multiatributo por convulsión",
            "Selección Simple",
            "Unión"});
            this.lstSentencias.Location = new System.Drawing.Point(325, 6);
            this.lstSentencias.Name = "lstSentencias";
            this.lstSentencias.Size = new System.Drawing.Size(440, 24);
            this.lstSentencias.TabIndex = 0;
            this.lstSentencias.SelectedIndexChanged += new System.EventHandler(this.lstSentencias_SelectedIndexChanged);
            // 
            // lblElegirConsulta
            // 
            this.lblElegirConsulta.AutoSize = true;
            this.lblElegirConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirConsulta.Location = new System.Drawing.Point(13, 6);
            this.lblElegirConsulta.Name = "lblElegirConsulta";
            this.lblElegirConsulta.Size = new System.Drawing.Size(277, 18);
            this.lblElegirConsulta.TabIndex = 1;
            this.lblElegirConsulta.Text = "Operación a realizar en la base de datos:";
            // 
            // lblSql
            // 
            this.lblSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSql.Location = new System.Drawing.Point(12, 36);
            this.lblSql.Name = "lblSql";
            this.lblSql.Size = new System.Drawing.Size(883, 123);
            this.lblSql.TabIndex = 2;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(15, 185);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(880, 342);
            this.dgvConsulta.TabIndex = 3;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(771, 3);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(124, 30);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmConsultarPorOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 533);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lblSql);
            this.Controls.Add(this.lblElegirConsulta);
            this.Controls.Add(this.lstSentencias);
            this.Name = "frmConsultarPorOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Base de Datos";
            this.Load += new System.EventHandler(this.frmConsultarPorOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstSentencias;
        private System.Windows.Forms.Label lblElegirConsulta;
        private System.Windows.Forms.Label lblSql;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnListar;
    }
}