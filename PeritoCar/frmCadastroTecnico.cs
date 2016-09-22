using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace PeritoCar
{
    public partial class frmCadastroTecnico : Form
    {
        LiteBD liteBd = new LiteBD();

        public frmCadastroTecnico()
        {
            InitializeComponent();
        }

        private void frmCadastroTecnico_Load(object sender, EventArgs e)
        {
            CarregaGridTecnico();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtTecnico.Text != "")
            {
                liteBd.InsertDeleteUpdate("INSERT INTO Tecnico (nome) " +
                        "VALUES ('" + txtTecnico.Text.Trim().ToUpper() + "')");
                liteBd.FecharConexao();
                txtTecnico.Text = "";
                CarregaGridTecnico();
            }
        }

        public void CarregaGridTecnico()
        {
            dgvTecnico.Rows.Clear();
            SQLiteDataReader retornoBD = liteBd.ConsultaReader("SELECT * FROM Tecnico");
            while (retornoBD.Read())
            {
                dgvTecnico.Rows.Add(retornoBD.GetInt32(0), retornoBD.GetString(1));
            }
            liteBd.FecharConexao();
        }

        private void dgvTecnico_UserDeletingRow_1(object sender, DataGridViewRowCancelEventArgs e)
        {
            liteBd.InsertDeleteUpdate("DELETE FROM Tecnico WHERE id_tecnico = " + dgvTecnico.CurrentRow.Cells[0].Value);
            liteBd.FecharConexao();
        }
    }
}
