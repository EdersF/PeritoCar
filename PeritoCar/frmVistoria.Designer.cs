namespace PeritoCar
{
    partial class frmVistoria
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
            this.tabVistoria = new System.Windows.Forms.TabControl();
            this.tabPageLancar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTaxaFranquia = new System.Windows.Forms.ComboBox();
            this.cmbTaxaDetran = new System.Windows.Forms.ComboBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbStatusPagamento = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblValorLiquido = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtValorLiquido = new System.Windows.Forms.TextBox();
            this.txtOutrasDespesas = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCredTudo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtImpostos = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbValorServico = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValorCobrado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbStatusVistoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoServico = new System.Windows.Forms.ComboBox();
            this.cmbTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabVistoria.SuspendLayout();
            this.tabPageLancar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVistoria
            // 
            this.tabVistoria.Controls.Add(this.tabPageLancar);
            this.tabVistoria.Controls.Add(this.tabPage2);
            this.tabVistoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVistoria.Location = new System.Drawing.Point(0, 0);
            this.tabVistoria.Name = "tabVistoria";
            this.tabVistoria.SelectedIndex = 0;
            this.tabVistoria.Size = new System.Drawing.Size(721, 533);
            this.tabVistoria.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabVistoria.TabIndex = 0;
            // 
            // tabPageLancar
            // 
            this.tabPageLancar.Controls.Add(this.panel2);
            this.tabPageLancar.Controls.Add(this.panel1);
            this.tabPageLancar.Location = new System.Drawing.Point(4, 22);
            this.tabPageLancar.Name = "tabPageLancar";
            this.tabPageLancar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLancar.Size = new System.Drawing.Size(713, 507);
            this.tabPageLancar.TabIndex = 0;
            this.tabPageLancar.Text = "Lançar";
            this.tabPageLancar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.cmbTaxaFranquia);
            this.panel2.Controls.Add(this.cmbTaxaDetran);
            this.panel2.Controls.Add(this.btnLancar);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cmbFormaPagamento);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cmbStatusPagamento);
            this.panel2.Controls.Add(this.txtObs);
            this.panel2.Controls.Add(this.lblValorLiquido);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtValorLiquido);
            this.panel2.Controls.Add(this.txtOutrasDespesas);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtCredTudo);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtImpostos);
            this.panel2.Controls.Add(this.txtDesconto);
            this.panel2.Controls.Add(this.lblDesconto);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmbValorServico);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtValorCobrado);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(8, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 262);
            this.panel2.TabIndex = 8;
            // 
            // cmbTaxaFranquia
            // 
            this.cmbTaxaFranquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaxaFranquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTaxaFranquia.FormattingEnabled = true;
            this.cmbTaxaFranquia.Location = new System.Drawing.Point(385, 31);
            this.cmbTaxaFranquia.Name = "cmbTaxaFranquia";
            this.cmbTaxaFranquia.Size = new System.Drawing.Size(89, 21);
            this.cmbTaxaFranquia.TabIndex = 28;
            // 
            // cmbTaxaDetran
            // 
            this.cmbTaxaDetran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaxaDetran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTaxaDetran.FormattingEnabled = true;
            this.cmbTaxaDetran.Location = new System.Drawing.Point(385, 58);
            this.cmbTaxaDetran.Name = "cmbTaxaDetran";
            this.cmbTaxaDetran.Size = new System.Drawing.Size(89, 21);
            this.cmbTaxaDetran.TabIndex = 30;
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(535, 200);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(103, 42);
            this.btnLancar.TabIndex = 40;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Forma de Pagamento";
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Items.AddRange(new object[] {
            "",
            "DINHEIRO",
            "DÉBITO",
            "CRÉDITO",
            "CHEQUE",
            "FATURA"});
            this.cmbFormaPagamento.Location = new System.Drawing.Point(122, 82);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(114, 21);
            this.cmbFormaPagamento.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Status do Pagamento";
            // 
            // cmbStatusPagamento
            // 
            this.cmbStatusPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatusPagamento.FormattingEnabled = true;
            this.cmbStatusPagamento.Items.AddRange(new object[] {
            "PAGO",
            "NÃO PAGO",
            "REVISTORIA"});
            this.cmbStatusPagamento.Location = new System.Drawing.Point(122, 109);
            this.cmbStatusPagamento.Name = "cmbStatusPagamento";
            this.cmbStatusPagamento.Size = new System.Drawing.Size(114, 21);
            this.cmbStatusPagamento.TabIndex = 24;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(9, 163);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(496, 88);
            this.txtObs.TabIndex = 38;
            // 
            // lblValorLiquido
            // 
            this.lblValorLiquido.AutoSize = true;
            this.lblValorLiquido.Location = new System.Drawing.Point(630, 112);
            this.lblValorLiquido.Name = "lblValorLiquido";
            this.lblValorLiquido.Size = new System.Drawing.Size(0, 13);
            this.lblValorLiquido.TabIndex = 18;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(532, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Valor Líquido";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(289, 112);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Outras Despesas";
            // 
            // txtValorLiquido
            // 
            this.txtValorLiquido.Enabled = false;
            this.txtValorLiquido.Location = new System.Drawing.Point(535, 109);
            this.txtValorLiquido.Name = "txtValorLiquido";
            this.txtValorLiquido.Size = new System.Drawing.Size(89, 20);
            this.txtValorLiquido.TabIndex = 36;
            this.txtValorLiquido.Text = "R$ 0,00";
            // 
            // txtOutrasDespesas
            // 
            this.txtOutrasDespesas.Location = new System.Drawing.Point(385, 109);
            this.txtOutrasDespesas.Name = "txtOutrasDespesas";
            this.txtOutrasDespesas.Size = new System.Drawing.Size(89, 20);
            this.txtOutrasDespesas.TabIndex = 34;
            this.txtOutrasDespesas.Text = "R$ 0,00";
            this.txtOutrasDespesas.TextChanged += new System.EventHandler(this.txtOutrasDespesas_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(325, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "CredTudo";
            // 
            // txtCredTudo
            // 
            this.txtCredTudo.Location = new System.Drawing.Point(385, 83);
            this.txtCredTudo.Name = "txtCredTudo";
            this.txtCredTudo.Size = new System.Drawing.Size(89, 20);
            this.txtCredTudo.TabIndex = 32;
            this.txtCredTudo.Text = "R$ 0,00";
            this.txtCredTudo.TextChanged += new System.EventHandler(this.txtCredTudo_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(298, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Taxa do Detran";
            // 
            // txtImpostos
            // 
            this.txtImpostos.Enabled = false;
            this.txtImpostos.Location = new System.Drawing.Point(385, 5);
            this.txtImpostos.Name = "txtImpostos";
            this.txtImpostos.Size = new System.Drawing.Size(89, 20);
            this.txtImpostos.TabIndex = 26;
            this.txtImpostos.Text = "R$ 0,00";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(122, 56);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(102, 20);
            this.txtDesconto.TabIndex = 20;
            this.txtDesconto.Text = "R$ 0,00";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(230, 59);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(19, 13);
            this.lblDesconto.TabIndex = 8;
            this.lblDesconto.Text = "----";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Valor do Serviço";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Valor Cobrado";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(307, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Impostos (6%)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Desconto";
            // 
            // cmbValorServico
            // 
            this.cmbValorServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValorServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbValorServico.FormattingEnabled = true;
            this.cmbValorServico.Location = new System.Drawing.Point(122, 4);
            this.cmbValorServico.Name = "cmbValorServico";
            this.cmbValorServico.Size = new System.Drawing.Size(103, 21);
            this.cmbValorServico.TabIndex = 16;
            this.cmbValorServico.SelectedIndexChanged += new System.EventHandler(this.cmbValorServico_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Observações";
            // 
            // txtValorCobrado
            // 
            this.txtValorCobrado.Location = new System.Drawing.Point(122, 31);
            this.txtValorCobrado.Name = "txtValorCobrado";
            this.txtValorCobrado.Size = new System.Drawing.Size(103, 20);
            this.txtValorCobrado.TabIndex = 18;
            this.txtValorCobrado.Text = "R$ 0,00";
            this.txtValorCobrado.TextChanged += new System.EventHandler(this.txtValorCobrado_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(289, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Taxa da Franquia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.cmbStatusVistoria);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCliente);
            this.panel1.Controls.Add(this.cmbTecnico);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Controls.Add(this.txtVeiculo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbTipoServico);
            this.panel1.Controls.Add(this.cmbTipoVeiculo);
            this.panel1.Controls.Add(this.dtpData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 205);
            this.panel1.TabIndex = 4;
            // 
            // cmbStatusVistoria
            // 
            this.cmbStatusVistoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusVistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatusVistoria.FormattingEnabled = true;
            this.cmbStatusVistoria.ItemHeight = 13;
            this.cmbStatusVistoria.Items.AddRange(new object[] {
            "APROVADO",
            "REPROVADO"});
            this.cmbStatusVistoria.Location = new System.Drawing.Point(535, 36);
            this.cmbStatusVistoria.Name = "cmbStatusVistoria";
            this.cmbStatusVistoria.Size = new System.Drawing.Size(127, 21);
            this.cmbStatusVistoria.TabIndex = 14;
            this.cmbStatusVistoria.SelectedIndexChanged += new System.EventHandler(this.cmbStatusVistoria_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Técnico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Placa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Status Vistoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veículo";
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Items.AddRange(new object[] {
            ""});
            this.cmbCliente.Location = new System.Drawing.Point(98, 63);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(222, 21);
            this.cmbCliente.TabIndex = 4;
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Items.AddRange(new object[] {
            ""});
            this.cmbTecnico.Location = new System.Drawing.Point(98, 36);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(161, 21);
            this.cmbTecnico.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo do Serviço";
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(98, 170);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(161, 20);
            this.txtPlaca.TabIndex = 12;
            this.txtPlaca.WordWrap = false;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(98, 144);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(161, 20);
            this.txtVeiculo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo do Veículo";
            // 
            // cmbTipoServico
            // 
            this.cmbTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoServico.FormattingEnabled = true;
            this.cmbTipoServico.Items.AddRange(new object[] {
            ""});
            this.cmbTipoServico.Location = new System.Drawing.Point(98, 90);
            this.cmbTipoServico.Name = "cmbTipoServico";
            this.cmbTipoServico.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoServico.TabIndex = 6;
            this.cmbTipoServico.SelectedIndexChanged += new System.EventHandler(this.cmbTipoServico_SelectedIndexChanged);
            // 
            // cmbTipoVeiculo
            // 
            this.cmbTipoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoVeiculo.FormattingEnabled = true;
            this.cmbTipoVeiculo.Location = new System.Drawing.Point(98, 117);
            this.cmbTipoVeiculo.Name = "cmbTipoVeiculo";
            this.cmbTipoVeiculo.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoVeiculo.TabIndex = 8;
            this.cmbTipoVeiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVeiculo_SelectedIndexChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(98, 10);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(97, 20);
            this.dtpData.TabIndex = 0;
            this.dtpData.Value = new System.DateTime(2016, 9, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmVistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 533);
            this.Controls.Add(this.tabVistoria);
            this.Name = "frmVistoria";
            this.Text = "Vistoria";
            this.Load += new System.EventHandler(this.frmVistoria_Load);
            this.tabVistoria.ResumeLayout(false);
            this.tabPageLancar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVistoria;
        private System.Windows.Forms.TabPage tabPageLancar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoVeiculo;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox cmbTipoServico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbStatusPagamento;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblValorLiquido;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtValorLiquido;
        private System.Windows.Forms.TextBox txtOutrasDespesas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCredTudo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtImpostos;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbValorServico;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtValorCobrado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbStatusVistoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.ComboBox cmbTaxaFranquia;
        private System.Windows.Forms.ComboBox cmbTaxaDetran;
    }
}