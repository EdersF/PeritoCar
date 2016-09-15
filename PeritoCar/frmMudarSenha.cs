using System;
using System.Windows.Forms;

namespace PeritoCar
{
    public partial class frmMudarSenha : Form
    {
        frmLogin InstanciafrmLogin;
        string usuario;

        public frmMudarSenha(frmLogin frmLogin)
        {
            InitializeComponent();
            InstanciafrmLogin = frmLogin;
            usuario = InstanciafrmLogin.txtUsuario.Text;
        }
        
        private void frmMudarSenha_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LiteBD liteBd = new LiteBD();
            string SQL;
            SQL = "UPDATE Usuarios SET senha = '" + txtSenha.Text + "', mudar_senha = 'false' WHERE usuario = '" + usuario + "'";

            try
            {
                liteBd.InsertDeleteUpdate(SQL);                                             //Faz a atualização na tabela
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alterar a senha! \n"+ ex.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();                                                             //Fecha o formulário e libera memória
        }
    }
}
