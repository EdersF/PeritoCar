using System;
using System.Data.SQLite;
using System.Globalization;
using System.Windows.Forms;

namespace PeritoCar
{
    public partial class frmVistoria : Form
    {
        LiteBD liteBd = new LiteBD();
        SQLiteDataReader retornoBD;


        public frmVistoria()
        {
            InitializeComponent();
        }
               
        private void frmVistoria_Load(object sender, EventArgs e)
        {
            dtpData.Value = DateTime.Now;
            // CARREGA COMBOBOX TÉCNICO
            retornoBD = liteBd.ConsultaReader("SELECT nome FROM Tecnico ORDER BY nome");
            while (retornoBD.Read())
            {
                cmbTecnico.Items.Add(retornoBD[0]);
            }
            liteBd.FecharConexao();

            // CARREGA COMBBOX CLIENTE
            retornoBD = liteBd.ConsultaReader("SELECT nome FROM Clientes ORDER BY nome");
            while (retornoBD.Read())
            {
                cmbCliente.Items.Add(retornoBD[0]);
            }
            liteBd.FecharConexao();

            // CARREGA COMBOBOX TIPO DE SERVIÇO
            retornoBD = liteBd.ConsultaReader("SELECT tipo FROM Tipo_Servicos ORDER BY tipo");
            while (retornoBD.Read())
            {
                cmbTipoServico.Items.Add(retornoBD[0]);
            }
            liteBd.FecharConexao();
        }

        private void cmbTipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CARREGA COMBOBOX TIPO DE VEÍCULO
            string SQL;
            cmbTipoServico.BackColor = System.Drawing.Color.White;
            cmbTipoVeiculo.Items.Clear();
            cmbValorServico.Items.Clear();
            cmbTaxaFranquia.Items.Clear();
            cmbTaxaDetran.Items.Clear();
            SQL = "SELECT b.tipo FROM Servicos AS a LEFT JOIN Tipo_Veiculos AS b ON a.id_tipo_veiculo = b.id_tipo_veiculo " + 
                "WHERE id_tipo_servico = (SELECT id_tipo_servico FROM Tipo_Servicos WHERE tipo = '"+ cmbTipoServico.Text +"')";
            retornoBD = liteBd.ConsultaReader(SQL);
            while (retornoBD.Read())
            {
                cmbTipoVeiculo.Items.Add(retornoBD[0]);
            }
            liteBd.FecharConexao();
        }

        private void cmbTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CARREGA COMBOBOX TIPO DE VALOR SERVIÇO
            string SQL;
            cmbTipoVeiculo.BackColor = System.Drawing.Color.White;
            cmbValorServico.Items.Clear();
            cmbTaxaFranquia.Items.Clear();
            cmbTaxaDetran.Items.Clear();
            SQL = "SELECT a.valor_servico, a.taxa_franquia, a.taxa_detran " +
            "FROM Servicos AS a " +
            "WHERE a.id_tipo_servico = (SELECT id_tipo_servico FROM Tipo_Servicos WHERE tipo =  '"+ cmbTipoServico.Text +"')" +
            "AND " +
            "a.id_tipo_veiculo = (SELECT id_tipo_veiculo FROM Tipo_Veiculos WHERE tipo = '"+ cmbTipoVeiculo.Text +"')";
            retornoBD = liteBd.ConsultaReader(SQL);
            while (retornoBD.Read())
            {
                cmbValorServico.Items.Add(retornoBD.GetDouble(0).ToString("C"));
                cmbTaxaFranquia.Items.Add(retornoBD.GetDouble(1).ToString("C"));
                cmbTaxaDetran.Items.Add(retornoBD.GetDouble(2).ToString("C"));
            }
            liteBd.FecharConexao();

            cmbValorServico.SelectedIndex = 0;
            cmbTaxaFranquia.SelectedIndex = 0;
            cmbTaxaDetran.SelectedIndex = 0;
        }      

        private void cmbValorServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculaDesconto();
            CalculaImposto();
            CalculaValorLiquido();
        }

        private void cmbStatusVistoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatusVistoria.Text == "APROVADO")
            {
                cmbStatusVistoria.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                cmbStatusVistoria.BackColor = System.Drawing.Color.OrangeRed;
                cmbStatusVistoria.ForeColor = System.Drawing.Color.White;
            }
        }

        private void txtValorCobrado_TextChanged(object sender, EventArgs e)
        {
            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = txtValorCobrado.Text.Replace(",", "")
                .Replace("R$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                txtValorCobrado.TextChanged -= txtValorCobrado_TextChanged;
                //Format the text as currency
                txtValorCobrado.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", ul);
                txtValorCobrado.TextChanged += txtValorCobrado_TextChanged;
                txtValorCobrado.Select(txtValorCobrado.Text.Length, 0);
            }
            //bool goodToGo = TextisValid(txtValorCobrado.Text);
            //if (!goodToGo)
            //{
            //    txtValorCobrado.Text = "R$ 0,00";
            //    txtValorCobrado.Select(txtValorCobrado.Text.Length, 0);
            //}

            CalculaImposto();
            CalculaValorLiquido();
            CalculaDesconto();
        }

        private void txtCredTudo_TextChanged(object sender, EventArgs e)
        {
            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = txtCredTudo.Text.Replace(",", "")
                .Replace("R$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                txtCredTudo.TextChanged -= txtCredTudo_TextChanged;
                //Format the text as currency
                txtCredTudo.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", ul);
                txtCredTudo.TextChanged += txtCredTudo_TextChanged;
                txtCredTudo.Select(txtCredTudo.Text.Length, 0);
            }
            CalculaDesconto();
            CalculaImposto();
            CalculaValorLiquido();
        }

        private void txtOutrasDespesas_TextChanged(object sender, EventArgs e)
        {
            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = txtOutrasDespesas.Text.Replace(",", "")
                .Replace("R$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                txtOutrasDespesas.TextChanged -= txtOutrasDespesas_TextChanged;
                //Format the text as currency
                txtOutrasDespesas.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", ul);
                txtOutrasDespesas.TextChanged += txtOutrasDespesas_TextChanged;
                txtOutrasDespesas.Select(txtOutrasDespesas.Text.Length, 0);
            }
            CalculaDesconto();
            CalculaImposto();
            CalculaValorLiquido();
        }

        private void CalculaDesconto()
        {
            string sValorServico = cmbValorServico.Text.Replace("R$ ", "");
            string sValorCobrado = txtValorCobrado.Text.Replace("R$ ", "");
            double dValorServico, dValorCobrado, dValorDesconto;

            if (double.TryParse(sValorCobrado, out dValorCobrado)) { }
            if (double.TryParse(sValorServico, out dValorServico)) { }

            dValorDesconto = dValorServico - dValorCobrado;
            txtDesconto.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", dValorDesconto);

            if (dValorServico == 0 || dValorCobrado == 0)
            {
                lblValorLiquido.Text = "";
            }
            else
            {
                lblDesconto.Text = (Math.Round((1-(dValorCobrado / dValorServico)) * 100,2)).ToString() + "%";
            }

        }

        private void CalculaImposto()
        {
            string valorCobrado = txtValorCobrado.Text.Replace("R$ ", "");
            //decimal dec;
            double impostos;
            if (double.TryParse(valorCobrado, out impostos))
            {
                impostos = Convert.ToDouble(impostos) * 0.06;
                txtImpostos.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", impostos);
            }
        }

        private void CalculaValorLiquido()
        {
            string sValorCobrado = txtValorCobrado.Text.Replace("R$ ", "");
            string sImpostos = txtImpostos.Text.Replace("R$ ", "");
            string sTaxaFranquia = cmbTaxaFranquia.Text.Replace("R$ ", "");
            string sTaxaDetran = cmbTaxaDetran.Text.Replace("R$ ", "");
            string sCredTudo = txtCredTudo.Text.Replace("R$ ", "");
            string sOutrasDespesas = txtOutrasDespesas.Text.Replace("R$ ", "");
            double dImpostos, dValorCobrado, dTaxaFranquia, dTaxaDetran, valorLiquido, dCredTudo, dOutrasDespesas;
            //Teste se é possível conversão para double
            if (double.TryParse(sValorCobrado, out dValorCobrado)){}
            if (double.TryParse(sImpostos, out dImpostos)){}
            if (double.TryParse(sTaxaFranquia, out dTaxaFranquia)){}
            if (double.TryParse(sTaxaDetran, out dTaxaDetran)){}
            if (double.TryParse(sCredTudo, out dCredTudo)) { }
            if (double.TryParse(sOutrasDespesas, out dOutrasDespesas)) { }
            //Calcula valor líquido
            valorLiquido = dValorCobrado - dImpostos - dTaxaDetran - dTaxaFranquia - dCredTudo - dOutrasDespesas;
            //Atualiza o textbox
            txtValorLiquido.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", valorLiquido);
            
            if (valorLiquido == 0 || dValorCobrado == 0)
            {
                lblValorLiquido.Text = "";
            }
            else
            {
                lblValorLiquido.Text = (Math.Round((valorLiquido / dValorCobrado)*100,2)).ToString() + "%";
            }

            if((valorLiquido / dValorCobrado) * 100 < 0)
            {
                lblValorLiquido.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblValorLiquido.ForeColor = System.Drawing.Color.Black;
            }

        }

        private bool ValidaCampos()
        {
            bool bomPraIr = false;

            if (cmbTipoServico.Text == "")
            {
                cmbTipoServico.BackColor = System.Drawing.Color.Yellow;
                cmbTipoServico.Focus();
                MessageBox.Show("Os campos 'Tipo do Serviço' e 'Tipo do Veículo' não podem estar vazios!", "Preencha os campos indicados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bomPraIr = false;
            }
            else if(cmbTipoVeiculo.Text == "")
            {
                cmbTipoVeiculo.BackColor = System.Drawing.Color.Yellow;
                cmbTipoVeiculo.Focus();
                MessageBox.Show("Os campos 'Tipo do Serviço' e 'Tipo do Veículo' não podem estar vazios!", "Preencha os campos indicados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bomPraIr = false;
            }
            else
            {
                bomPraIr = true;
            }

            return bomPraIr;
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {            
            string SQL;

            if (!ValidaCampos())
            {
                return;
            }

            SQL = "INSERT INTO Vistorias (data, tipo_veiculo, tipo_servico, tecnico, veiculo, placa, nome_cliente, status_vistoria, valor_servico, desconto, valor_cobrado, modo_pagamento, status_pagamento, imposto, taxa_franquia, taxa_detran, credtudo, valor_liquido, obs) " +
                "VALUES('" + dtpData.Text + "','" + cmbTipoVeiculo.Text + "','" + cmbTipoServico.Text + "','" + cmbTecnico.Text + "','" + txtVeiculo.Text + "','" + txtPlaca.Text + "','" + cmbCliente.Text + "','" + cmbStatusVistoria.Text + "'," + cmbValorServico.Text.Replace(",",".").Replace("R$ ", "") + ","+txtDesconto.Text.Replace(",", ".").Replace("R$ ", "") + ","+txtValorCobrado.Text.Replace(",", ".").Replace("R$ ", "") + ", '"+
                cmbFormaPagamento.Text+"','"+cmbStatusPagamento.Text+"',"+txtImpostos.Text.Replace(",", ".").Replace("R$ ", "") + ","+cmbTaxaFranquia.Text.Replace(",", ".").Replace("R$ ", "") + ","+cmbTaxaDetran.Text.Replace(",", ".").Replace("R$ ", "") + ","+txtCredTudo.Text.Replace(",", ".").Replace("R$ ", "") + ","+txtValorLiquido.Text.Replace(",", ".").Replace("R$ ", "") + ",'"+txtObs.Text+"')";

            liteBd.InsertDeleteUpdate(SQL);
            liteBd.FecharConexao();
            cmbTipoServico.SelectedIndex = 0;
            cmbTecnico.SelectedIndex = 0;
            cmbCliente.Text = "";
            cmbTipoServico.SelectedIndex = 0;
            cmbTipoVeiculo.Items.Clear();
            txtVeiculo.Text = "";
            txtPlaca.Text = "";
            cmbStatusVistoria.Items.Clear();
            cmbValorServico.Items.Clear();
            txtValorCobrado.Text = "R$ 0,00";
            cmbFormaPagamento.Items.Clear();
            cmbStatusPagamento.Items.Clear();
            cmbTaxaFranquia.Items.Clear();
            cmbTaxaDetran.Items.Clear();
            txtCredTudo.Text = "R$ 0,00";
            txtOutrasDespesas.Text = "R$ 0,00";
            txtObs.Text = "";
            txtImpostos.Text = "R$ 0,00";
            lblDesconto.Text = "";

            cmbStatusVistoria.BackColor = System.Drawing.Color.White;
            
        }

    }
}
