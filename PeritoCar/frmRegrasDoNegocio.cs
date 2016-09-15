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
            CarregaCombobox();
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
            liteBd.InsertDeleteUpdate("DELETE FROM Tipo_Veiculos WHERE id_tipo_veiculo = " + dgvTipoVeiculo.CurrentRow.Cells[0].Value);
            liteBd.FecharConexao();
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
            liteBd.InsertDeleteUpdate("DELETE FROM Tipo_Servicos WHERE id_tipo_servico = " + dgvTipoServico.CurrentRow.Cells[0].Value);
            liteBd.FecharConexao();
        }

        //==========================Valores / Serviços================================================
        private void CarregaCombobox()
        {
            SQLiteDataReader retornoBD;

            retornoBD = liteBd.ConsultaReader("SELECT tipo FROM Tipo_Veiculos");
            while (retornoBD.Read())
            {
                cmbTipoVeiculo.Items.Add(retornoBD.GetString(0));
            }
            liteBd.FecharConexao();

            retornoBD = liteBd.ConsultaReader("SELECT tipo FROM Tipo_Servicos");
            while (retornoBD.Read())
            {
                cmbTipoServico.Items.Add(retornoBD.GetString(0));
            }

            liteBd.FecharConexao();
        }

        private void btnInserir3_Click(object sender, EventArgs e)
        {
            if(cmbTipoServico.Text == "" || cmbTipoVeiculo.Text == "" || txtTaxaDetran.Text == "" || 
                txtValorServico.Text == "" || txtTaxaFranquia.Text == "" )
            {
                MessageBox.Show("Preencha todos os campos!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
