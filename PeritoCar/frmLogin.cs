using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace PeritoCar
{
    public partial class frmLogin : Form
    {
        LiteBD liteBd = new LiteBD();
        public bool logado = false;
        public string usuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string SQL;

            SQL = "SELECT COUNT(usuario), usuario, nome, senha, mudar_senha FROM Usuarios WHERE usuario = '" + txtUsuario.Text + "'";
            try
            {
                dt = liteBd.TabelaDados(SQL);                                                //Cria um DataTable com a consulta SQL
                liteBd.FecharConexao();                                                     //Fecha a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o banco de dados! \n\n" + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                                             

            if (dt.Rows[0][0].ToString() == "1")                                        //Conta a quantidade de registro retornada pela consulta
            {//Se retornar 1 registro
                usuario = dt.Rows[0]["usuario"].ToString();                             //Pega o nome do usuário retornado
                if (Convert.ToBoolean(dt.Rows[0]["mudar_senha"]))                       //Verifica se o campo mudar_senha está setado
                {//se o campo mudar_senha for VERDADEIRO
                    frmMudarSenha frmMudarSenha = new frmMudarSenha(this);
                    frmMudarSenha.ShowDialog();                                         //Exibe o formulário MudarSenha
                    logado = true;
                    this.Dispose();
                }
                else
                {//Se o campo mudar_senha for FALSO
                    if(dt.Rows[0]["senha"].ToString() == txtSenha.Text)
                    {//Se a senha digitada for igual a do banco
                        logado = true;
                        this.Dispose();
                    }
                    else
                    {//Se a senha for Diferente
                        MessageBox.Show("A senha digitada está incorreta, verifique", "Erro na autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                logado = false;
                MessageBox.Show("Usuário não cadastrado, verifique!", "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
