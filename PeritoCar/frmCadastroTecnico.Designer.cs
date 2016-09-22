namespace PeritoCar
{
    partial class frmCadastroTecnico
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
            this.txtTecnico = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvTecnico = new System.Windows.Forms.DataGridView();
            this.colCodTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTecnico
            // 
            this.txtTecnico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTecnico.Location = new System.Drawing.Point(12, 26);
            this.txtTecnico.Name = "txtTecnico";
            this.txtTecnico.Size = new System.Drawing.Size(186, 20);
            this.txtTecnico.TabIndex = 17;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(204, 26);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 18;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvTecnico
            // 
            this.dgvTecnico.AllowUserToAddRows = false;
            this.dgvTecnico.BackgroundColor = System.Drawing.Color.White;
            this.dgvTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecnico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodTecnico,
            this.colTecnico});
            this.dgvTecnico.Location = new System.Drawing.Point(12, 53);
            this.dgvTecnico.MultiSelect = false;
            this.dgvTecnico.Name = "dgvTecnico";
            this.dgvTecnico.ReadOnly = true;
            this.dgvTecnico.RowHeadersVisible = false;
            this.dgvTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTecnico.Size = new System.Drawing.Size(267, 326);
            this.dgvTecnico.TabIndex = 19;
            this.dgvTecnico.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTecnico_UserDeletingRow_1);
            // 
            // colCodTecnico
            // 
            this.colCodTecnico.HeaderText = "Cod Tecnico";
            this.colCodTecnico.Name = "colCodTecnico";
            this.colCodTecnico.ReadOnly = true;
            this.colCodTecnico.Width = 60;
            // 
            // colTecnico
            // 
            this.colTecnico.HeaderText = "Técnico";
            this.colTecnico.Name = "colTecnico";
            this.colTecnico.ReadOnly = true;
            this.colTecnico.Width = 200;
            // 
            // frmCadastroTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 391);
            this.Controls.Add(this.dgvTecnico);
            this.Controls.Add(this.txtTecnico);
            this.Controls.Add(this.btnInserir);
            this.Name = "frmCadastroTecnico";
            this.Text = "Cadastro de Técnico";
            this.Load += new System.EventHandler(this.frmCadastroTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTecnico;
    }
}