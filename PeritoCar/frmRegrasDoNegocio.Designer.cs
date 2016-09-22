namespace PeritoCar
{
    partial class frmRegrasDoNegocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTipoVeiculo = new System.Windows.Forms.TabPage();
            this.txtTipoVeiculo = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvTipoVeiculo = new System.Windows.Forms.DataGridView();
            this.colIdTipoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTipoServico = new System.Windows.Forms.TabPage();
            this.txtTipoServico = new System.Windows.Forms.TextBox();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.dgvTipoServico = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabValoresServicos = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaxaFranquia = new System.Windows.Forms.TextBox();
            this.cmbTipoServico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaxaDetran = new System.Windows.Forms.TextBox();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.btnInserir3 = new System.Windows.Forms.Button();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoVeiculo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFranquia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabTipoVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVeiculo)).BeginInit();
            this.tabTipoServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServico)).BeginInit();
            this.tabValoresServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTipoVeiculo);
            this.tabControl1.Controls.Add(this.tabTipoServico);
            this.tabControl1.Controls.Add(this.tabValoresServicos);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 529);
            this.tabControl1.TabIndex = 10;
            // 
            // tabTipoVeiculo
            // 
            this.tabTipoVeiculo.Controls.Add(this.txtTipoVeiculo);
            this.tabTipoVeiculo.Controls.Add(this.btnInserir);
            this.tabTipoVeiculo.Controls.Add(this.dgvTipoVeiculo);
            this.tabTipoVeiculo.Location = new System.Drawing.Point(4, 22);
            this.tabTipoVeiculo.Name = "tabTipoVeiculo";
            this.tabTipoVeiculo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTipoVeiculo.Size = new System.Drawing.Size(657, 503);
            this.tabTipoVeiculo.TabIndex = 0;
            this.tabTipoVeiculo.Text = "Tipo de Veículo";
            this.tabTipoVeiculo.UseVisualStyleBackColor = true;
            // 
            // txtTipoVeiculo
            // 
            this.txtTipoVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoVeiculo.Location = new System.Drawing.Point(7, 47);
            this.txtTipoVeiculo.Name = "txtTipoVeiculo";
            this.txtTipoVeiculo.Size = new System.Drawing.Size(186, 20);
            this.txtTipoVeiculo.TabIndex = 12;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(199, 47);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvTipoVeiculo
            // 
            this.dgvTipoVeiculo.AllowUserToAddRows = false;
            this.dgvTipoVeiculo.AllowUserToResizeColumns = false;
            this.dgvTipoVeiculo.AllowUserToResizeRows = false;
            this.dgvTipoVeiculo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipoVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTipoVeiculo,
            this.colTipoVeiculo});
            this.dgvTipoVeiculo.Location = new System.Drawing.Point(7, 76);
            this.dgvTipoVeiculo.MultiSelect = false;
            this.dgvTipoVeiculo.Name = "dgvTipoVeiculo";
            this.dgvTipoVeiculo.ReadOnly = true;
            this.dgvTipoVeiculo.RowHeadersVisible = false;
            this.dgvTipoVeiculo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTipoVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoVeiculo.Size = new System.Drawing.Size(267, 421);
            this.dgvTipoVeiculo.TabIndex = 16;
            this.dgvTipoVeiculo.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvTipoVeiculo_UserDeletedRow);
            this.dgvTipoVeiculo.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTipoVeiculo_UserDeletingRow);
            // 
            // colIdTipoVeiculo
            // 
            this.colIdTipoVeiculo.HeaderText = "Cod Tipo Veículo";
            this.colIdTipoVeiculo.Name = "colIdTipoVeiculo";
            this.colIdTipoVeiculo.ReadOnly = true;
            this.colIdTipoVeiculo.Width = 80;
            // 
            // colTipoVeiculo
            // 
            this.colTipoVeiculo.HeaderText = "Tipo Veiculo";
            this.colTipoVeiculo.Name = "colTipoVeiculo";
            this.colTipoVeiculo.ReadOnly = true;
            this.colTipoVeiculo.Width = 200;
            // 
            // tabTipoServico
            // 
            this.tabTipoServico.Controls.Add(this.txtTipoServico);
            this.tabTipoServico.Controls.Add(this.btnInserir2);
            this.tabTipoServico.Controls.Add(this.dgvTipoServico);
            this.tabTipoServico.Location = new System.Drawing.Point(4, 22);
            this.tabTipoServico.Name = "tabTipoServico";
            this.tabTipoServico.Padding = new System.Windows.Forms.Padding(3);
            this.tabTipoServico.Size = new System.Drawing.Size(657, 503);
            this.tabTipoServico.TabIndex = 1;
            this.tabTipoServico.Text = "Tipo de Serviço";
            this.tabTipoServico.UseVisualStyleBackColor = true;
            // 
            // txtTipoServico
            // 
            this.txtTipoServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoServico.Location = new System.Drawing.Point(6, 47);
            this.txtTipoServico.Name = "txtTipoServico";
            this.txtTipoServico.Size = new System.Drawing.Size(186, 20);
            this.txtTipoServico.TabIndex = 17;
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(198, 47);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(75, 23);
            this.btnInserir2.TabIndex = 18;
            this.btnInserir2.Text = "Inserir";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // dgvTipoServico
            // 
            this.dgvTipoServico.AllowUserToAddRows = false;
            this.dgvTipoServico.AllowUserToResizeColumns = false;
            this.dgvTipoServico.AllowUserToResizeRows = false;
            this.dgvTipoServico.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipoServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvTipoServico.Location = new System.Drawing.Point(6, 76);
            this.dgvTipoServico.MultiSelect = false;
            this.dgvTipoServico.Name = "dgvTipoServico";
            this.dgvTipoServico.ReadOnly = true;
            this.dgvTipoServico.RowHeadersVisible = false;
            this.dgvTipoServico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTipoServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoServico.Size = new System.Drawing.Size(267, 421);
            this.dgvTipoServico.TabIndex = 19;
            this.dgvTipoServico.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvTipoServico_UserDeletedRow);
            this.dgvTipoServico.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTipoServico_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod Tipo Serviço";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo Serviço";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // tabValoresServicos
            // 
            this.tabValoresServicos.Controls.Add(this.label7);
            this.tabValoresServicos.Controls.Add(this.label8);
            this.tabValoresServicos.Controls.Add(this.label6);
            this.tabValoresServicos.Controls.Add(this.label4);
            this.tabValoresServicos.Controls.Add(this.txtTaxaFranquia);
            this.tabValoresServicos.Controls.Add(this.cmbTipoServico);
            this.tabValoresServicos.Controls.Add(this.label2);
            this.tabValoresServicos.Controls.Add(this.cmbTipoVeiculo);
            this.tabValoresServicos.Controls.Add(this.label5);
            this.tabValoresServicos.Controls.Add(this.label3);
            this.tabValoresServicos.Controls.Add(this.label1);
            this.tabValoresServicos.Controls.Add(this.txtTaxaDetran);
            this.tabValoresServicos.Controls.Add(this.txtValorServico);
            this.tabValoresServicos.Controls.Add(this.btnInserir3);
            this.tabValoresServicos.Controls.Add(this.dgvServicos);
            this.tabValoresServicos.Location = new System.Drawing.Point(4, 22);
            this.tabValoresServicos.Name = "tabValoresServicos";
            this.tabValoresServicos.Size = new System.Drawing.Size(657, 503);
            this.tabValoresServicos.TabIndex = 2;
            this.tabValoresServicos.Text = "Valores / Serviços";
            this.tabValoresServicos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "R$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Taxa da Franquia";
            // 
            // txtTaxaFranquia
            // 
            this.txtTaxaFranquia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTaxaFranquia.Location = new System.Drawing.Point(262, 104);
            this.txtTaxaFranquia.Name = "txtTaxaFranquia";
            this.txtTaxaFranquia.Size = new System.Drawing.Size(62, 20);
            this.txtTaxaFranquia.TabIndex = 56;
            // 
            // cmbTipoServico
            // 
            this.cmbTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServico.FormattingEnabled = true;
            this.cmbTipoServico.Location = new System.Drawing.Point(7, 104);
            this.cmbTipoServico.Name = "cmbTipoServico";
            this.cmbTipoServico.Size = new System.Drawing.Size(172, 21);
            this.cmbTipoServico.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo de Serviço";
            // 
            // cmbTipoVeiculo
            // 
            this.cmbTipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVeiculo.FormattingEnabled = true;
            this.cmbTipoVeiculo.Location = new System.Drawing.Point(7, 47);
            this.cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            this.cmbTipoVeiculo.Size = new System.Drawing.Size(172, 21);
            this.cmbTipoVeiculo.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Taxa do Detran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Valor do Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tipo de Veículo";
            // 
            // txtTaxaDetran
            // 
            this.txtTaxaDetran.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTaxaDetran.Location = new System.Drawing.Point(400, 48);
            this.txtTaxaDetran.Name = "txtTaxaDetran";
            this.txtTaxaDetran.Size = new System.Drawing.Size(64, 20);
            this.txtTaxaDetran.TabIndex = 58;
            // 
            // txtValorServico
            // 
            this.txtValorServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorServico.Location = new System.Drawing.Point(262, 47);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(62, 20);
            this.txtValorServico.TabIndex = 54;
            // 
            // btnInserir3
            // 
            this.btnInserir3.Location = new System.Drawing.Point(389, 101);
            this.btnInserir3.Name = "btnInserir3";
            this.btnInserir3.Size = new System.Drawing.Size(75, 23);
            this.btnInserir3.TabIndex = 60;
            this.btnInserir3.Text = "Inserir";
            this.btnInserir3.UseVisualStyleBackColor = true;
            this.btnInserir3.Click += new System.EventHandler(this.btnInserir3_Click);
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.AllowUserToResizeColumns = false;
            this.dgvServicos.AllowUserToResizeRows = false;
            this.dgvServicos.BackgroundColor = System.Drawing.Color.White;
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.colTipoVeiculo2,
            this.dataGridViewTextBoxColumn4,
            this.colValorServico,
            this.colFranquia,
            this.colDetran});
            this.dgvServicos.Location = new System.Drawing.Point(3, 133);
            this.dgvServicos.MultiSelect = false;
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.ReadOnly = true;
            this.dgvServicos.RowHeadersVisible = false;
            this.dgvServicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicos.Size = new System.Drawing.Size(506, 367);
            this.dgvServicos.TabIndex = 22;
            this.dgvServicos.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvServicos_UserDeletedRow);
            this.dgvServicos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvServicos_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cod Serviço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // colTipoVeiculo2
            // 
            this.colTipoVeiculo2.HeaderText = "Tipo de Veículo";
            this.colTipoVeiculo2.Name = "colTipoVeiculo2";
            this.colTipoVeiculo2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo Serviço";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // colValorServico
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0";
            this.colValorServico.DefaultCellStyle = dataGridViewCellStyle7;
            this.colValorServico.HeaderText = "Valor do Serviço";
            this.colValorServico.Name = "colValorServico";
            this.colValorServico.ReadOnly = true;
            this.colValorServico.Width = 70;
            // 
            // colFranquia
            // 
            dataGridViewCellStyle8.Format = "C2";
            this.colFranquia.DefaultCellStyle = dataGridViewCellStyle8;
            this.colFranquia.HeaderText = "Taxa da Franquia";
            this.colFranquia.Name = "colFranquia";
            this.colFranquia.ReadOnly = true;
            this.colFranquia.Width = 70;
            // 
            // colDetran
            // 
            dataGridViewCellStyle9.Format = "C2";
            this.colDetran.DefaultCellStyle = dataGridViewCellStyle9;
            this.colDetran.HeaderText = "Taxa do Detran";
            this.colDetran.Name = "colDetran";
            this.colDetran.ReadOnly = true;
            this.colDetran.Width = 70;
            // 
            // frmRegrasDoNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRegrasDoNegocio";
            this.Text = "Regras do Negócio";
            this.Load += new System.EventHandler(this.frmRegrasDoNegocio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTipoVeiculo.ResumeLayout(false);
            this.tabTipoVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVeiculo)).EndInit();
            this.tabTipoServico.ResumeLayout(false);
            this.tabTipoServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServico)).EndInit();
            this.tabValoresServicos.ResumeLayout(false);
            this.tabValoresServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTipoVeiculo;
        private System.Windows.Forms.TabPage tabTipoServico;
        private System.Windows.Forms.DataGridView dgvTipoVeiculo;
        private System.Windows.Forms.TabPage tabValoresServicos;
        private System.Windows.Forms.TextBox txtTipoVeiculo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTipoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoVeiculo;
        private System.Windows.Forms.TextBox txtTipoServico;
        private System.Windows.Forms.Button btnInserir2;
        private System.Windows.Forms.DataGridView dgvTipoServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.Button btnInserir3;
        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.ComboBox cmbTipoServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaxaFranquia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaxaDetran;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoVeiculo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFranquia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetran;
    }
}