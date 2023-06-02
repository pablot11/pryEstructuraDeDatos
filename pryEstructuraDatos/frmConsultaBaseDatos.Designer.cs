namespace pryEstructuraDatos
{
    partial class frmConsultaBaseDatos
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
            this.txtConsultaSql = new System.Windows.Forms.TextBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblConsultaSql = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsultaSql
            // 
            this.txtConsultaSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaSql.Location = new System.Drawing.Point(12, 37);
            this.txtConsultaSql.Multiline = true;
            this.txtConsultaSql.Name = "txtConsultaSql";
            this.txtConsultaSql.Size = new System.Drawing.Size(776, 192);
            this.txtConsultaSql.TabIndex = 0;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 269);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(776, 241);
            this.dgvConsulta.TabIndex = 1;
            // 
            // lblConsultaSql
            // 
            this.lblConsultaSql.AutoSize = true;
            this.lblConsultaSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaSql.Location = new System.Drawing.Point(12, 9);
            this.lblConsultaSql.Name = "lblConsultaSql";
            this.lblConsultaSql.Size = new System.Drawing.Size(155, 25);
            this.lblConsultaSql.TabIndex = 2;
            this.lblConsultaSql.Text = "Consulta SQL:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.Location = new System.Drawing.Point(553, 235);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(235, 28);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultaBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 532);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblConsultaSql);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.txtConsultaSql);
            this.Name = "frmConsultaBaseDatos";
            this.Text = "Consulta de Base de Datos";
            this.Load += new System.EventHandler(this.frmConsultaBaseDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsultaSql;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblConsultaSql;
        private System.Windows.Forms.Button btnConsultar;
    }
}