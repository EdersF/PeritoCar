using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PeritoCar
{
    public partial class frmRegrasDoNegocio : Form
    {
        LiteBD liteBd = new LiteBD();

        public frmRegrasDoNegocio()
        {
            InitializeComponent();
        }

        private void frmRegrasDoNegocio_Load(object sender, EventArgs e)
        {
            CarregaGridTipoVeiculo();
            CarregaGridTipoServico();
            CarregaGridServico();
            CarregaCombobox();
            liteBd.FecharConexao();
        }
        //==========================Tipo de Veiculos====================================================
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if( txtTipoVeiculo.Text != "")
            {
                liteBd.InsertDeleteUpdate("INSERT INTO Tipo_Veiculos (tipo) " +
                        "VALUES ('" + txtTipoVeiculo.Text.Trim().ToUpper() +"')");
                liteBd.FecharConexao();
                txtTipoVeiculo.Text = "";
                CarregaGridTipoVeiculo();
                CarregaCombobox();
            }
        }

        public void CarregaGridTipoVeiculo()
        {
            dgvTipoVeiculo.Rows.Clear();
            SQLiteDataReader retornoBD = liteBd.ConsultaReader("SELECT * FROM Tipo_Veiculos");
            while (retornoBD.Read())
            {
                dgvTipoVeiculo.Rows.Add(retornoBD.GetInt32(0), retornoBD.GetString(1));
            }
            liteBd.FecharConexao();
        }

        private void dgvTipoVeiculo_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            liteBd.InsertDeleteUpdate("PRAGMA FOREIGN_KEYS = ON; DELETE FROM Tipo_Veiculos WHERE id_tipo_veiculo = " + dgvTipoVeiculo.CurrentRow.Cells[0].Value);
            liteBd.FecharConexao();
        }

        private void dgvTipoVeiculo_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CarregaCombobox();
            CarregaGridServico();
            CarregaGridTipoVeiculo();
        }

        //==========================Tipo de Serviços===================================================
        private void btnInserir2_Click(object sender, EventArgs e)
        {
            if (txtTipoServico.Text != "")
            {
                liteBd.InsertDeleteUpdate("INSERT INTO Tipo_Servicos (tipo) " +
                        "VALUES ('" + txtTipoServico.Text.Trim().ToUpper() + "')");
                liteBd.FecharConexao();
                txtTipoServico.Text = "";
                CarregaGridTipoServico();
                CarregaCombobox();
            }
        }

        public void CarregaGridTipoServico()
        {
            dgvTipoServico.Rows.Clear();
            SQLiteDataReader retornoBD = liteBd.ConsultaReader("SELECT * FROM Tipo_Servicos");
            while (retornoBD.Read())
            {
                dgvTipoServico.Rows.Add(retornoBD.GetInt32(0), retornoBD.GetString(1));
            }
            liteBd.FecharConexao();
        }

        private void dgvTipoServico_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            liteBd.InsertDeleteUpdate("PRAGMA FOREIGN_KEYS = ON; DELETE FROM Tipo_Servicos WHERE id_tipo_servico = " + dgvTipoServico.CurrentRow.Cells[0].Value);
            liteBd.FecharConexao();
        }

        private void dgvTipoServico_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CarregaCombobox();
            CarregaGridServico();
            CarregaGridTipoServico();
        }

        //==========================Valores / Serviços================================================
        private void CarregaCombobox()
        {
            SQLiteDataReader retornoBD;

            cmbTipoVeiculo.Items.Clear();
            retornoBD = liteBd.ConsultaReader("SELECT tipo FROM Tipo_Veiculos");
            cmbTipoVeiculo.Items.Add("");
            while (retornoBD.Read())
            {
                cmbTipoVeiculo.Items.Add(retornoBD.GetString(0));
            }
            liteBd.FecharConexao();

            cmbTipoServico.Items.Clear();
            retornoBD = liteBd.ConsultaReader("SELECT tipo FROM Tipo_Servicos");
            cmbTipoServico.Items.Add("");
            while (retornoBD.Read())
            {
                cmbTipoServico.Items.Add(retornoBD.GetString(0));
            }

            liteBd.FecharConexao();
        }

        private void CarregaGridServico()
        {
            dgvServicos.Rows.Clear();
            SQLiteDataReader retornoBD;

            retornoBD = liteBd.ConsultaReader("SELECT A.id_servico, C.tipo, B.tipo, A.valor_servico, A.taxa_franquia, A.taxa_detran " +
                "FROM (Servicos as A LEFT JOIN Tipo_Servicos as B ON A.id_tipo_servico = B.id_tipo_servico) LEFT JOIN Tipo_Veiculos as C ON A.id_tipo_veiculo = C.id_tipo_veiculo ");

            while (retornoBD.Read())
            {
                dgvServicos.Rows.Add(retornoBD.GetInt32(0), retornoBD.GetString(1), retornoBD.GetString(2), retornoBD.GetDouble(3), retornoBD.GetDouble(4), retornoBD.GetDouble(5));
            }
            liteBd.FecharConexao();
        }

        private void btnInserir3_Click(object sender, EventArgs e)
        {
            SQLiteDataReader retornoBD;
            int idTipoServico, idTipoVeiculo;
            string valorServico, taxaFranquia, taxaDetran;

            if(cmbTipoServico.Text == "" || cmbTipoVeiculo.Text == "" || txtTaxaDetran.Text == "" || 
                txtValorServico.Text == "" || txtTaxaFranquia.Text == "" )
            {
                MessageBox.Show("Preencha todos os campos!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            idTipoServico = Convert.ToInt32(liteBd.ConsultaScalar("SELECT id_tipo_servico FROM Tipo_Servicos WHERE tipo = '" + cmbTipoServico.Text + "'"));
            liteBd.FecharConexao();
            idTipoVeiculo = Convert.ToInt32(liteBd.ConsultaScalar("SELECT id_tipo_veiculo FROM Tipo_Veiculos WHERE tipo = '" + cmbTipoVeiculo.Text + "'"));
            liteBd.FecharConexao();

            valorServico = txtValorServico.Text.Replace(",", ".");
            taxaFranquia = txtTaxaFranquia.Text.Replace(",", ".");
            taxaDetran = txtTaxaDetran.Text.Replace(",", ".");

            liteBd.InsertDeleteUpdate("INSERT INTO Servicos (id_tipo_servico, id_tipo_veiculo, valor_servico, taxa_franquia, taxa_detran) "+
                "VALUES ("+ idTipoServico +", "+ idTipoVeiculo +", "+ valorServico +", "+ taxaFranquia +", "+ taxaDetran +")");
            liteBd.FecharConexao();

            cmbTipoServico.SelectedIndex = 0;
            cmbTipoVeiculo.SelectedIndex = 0;
            txtTaxaDetran.Text = "";
            txtTaxaFranquia.Text = "";
            txtTipoServico.Text = "";
            txtTipoVeiculo.Text = "";
            txtValorServico.Text = "";

            CarregaGridServico();
        }

        private void dgvServicos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Tem certeza que deseja apagar o serviço? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
                return;
            try
            {
                liteBd.InsertDeleteUpdate("DELETE FROM Servicos WHERE id_servico = " + dgvServicos.CurrentRow.Cells[0].Value);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            liteBd.FecharConexao();
        }

        private void dgvServicos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CarregaGridServico();
        }

    }
}
