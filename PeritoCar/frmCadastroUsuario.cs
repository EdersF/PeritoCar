using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Threading;
using System.Windows.Forms;

namespace PeritoCar
{
    public partial class frmCadastroUsuario : Form
    {
        LiteBD liteBd = new LiteBD();
        Point ponto;
        string Operacao;

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            ponto.Y = 55;
            ponto.X = 12;
            dgvUsuarios.Location = ponto;
            dgvUsuarios.Height = 433;

            CarregaGrid();
        }

        private void Mostrar_Campos()
        {
            //Desabilitando botões
            btnAlterar.Enabled = false;
            btnIncluir.Enabled = false;
            btn_excluir.Enabled = false;
            //Recolhendo Grid para mostrar os campos
            for (int y = 55; y < 176; y ++)
            {
                ponto.Y = y;
                dgvUsuarios.Location = ponto;
                dgvUsuarios.Height--;
            }
        }

        private void Esconder_Campos()
        {   //Habilitando botões
            btnAlterar.Enabled = true;
            btnIncluir.Enabled = true;
            btn_excluir.Enabled = true;
            //Aumentando Grid para esconder os campos
            for (int y = 175; y > 54; y --)
            {
                ponto.Y = y;
                dgvUsuarios.Location = ponto;
                dgvUsuarios.Height++;
            }

        }

        private void Limpar_Campos()
        {
            txtEmail.Text = "";
            txtNome.Text = "";
            txtUsuario.Text = "";
            cboxResetar.Checked = false;
                
        }
               
        public void CarregaGrid()
        {
            dgvUsuarios.Rows.Clear();
            SQLiteDataReader retornoBD = liteBd.ConsultaReader("SELECT * FROM USUARIOS");
            while (retornoBD.Read())
            {
                dgvUsuarios.Rows.Add(retornoBD.GetInt32(0), retornoBD.GetString(1), retornoBD.GetString(2), retornoBD.GetString(3));
            }
            liteBd.FecharConexao();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Mostrar_Campos();
            Operacao = "INCLUIR";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Mostrar_Campos();
            //Preenchendo os campos com os dados da linha selecionada
            txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();

            Operacao = "ALTERAR";
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Mostrar_Campos();
            //Preenchendo os campos com os dados da linha selecionada
            txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();

            txtUsuario.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            cboxResetar.Enabled = false;

            Operacao = "EXCLUIR";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (Operacao)
            {
                case "INCLUIR": //Incluir
                    if (txtUsuario.Text == "" || txtEmail.Text == "")
                    {
                        MessageBox.Show("Os campos obrigatórios não podem estar vazios!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Focus();
                        return;
                    }
                    try
                    {
                        liteBd.InsertDeleteUpdate("INSERT INTO USUARIOS (usuario, nome, email, senha, mudar_senha) "+
                        "VALUES ('" + txtUsuario.Text + "', '" + txtNome.Text + "', '" + txtEmail.Text + "', '', 'true')");
                        Limpar_Campos();
                        Esconder_Campos();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Erro de Banco de Dados, Verifique se este usuário já está cadastrado! \n\n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    liteBd.FecharConexao();
                    CarregaGrid();
                    break;

                case "ALTERAR": //Alterar
                    if (txtUsuario.Text == "" || txtEmail.Text == "")
                    {
                        MessageBox.Show("Os campos obrigatórios não podem estar vazios!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Focus();
                        return;
                    }
                    try
                    {
                        liteBd.InsertDeleteUpdate("UPDATE USUARIOS SET usuario = '"+ txtUsuario.Text +"', nome = '"+ txtNome.Text +"', email = '"+ txtEmail.Text +"', mudar_senha = '"+ cboxResetar.Checked +"' " +
                        "WHERE id_usuario = " + txtIdUsuario.Text);
                        Limpar_Campos();
                        Esconder_Campos();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Erro de Banco de Dados, Verifique se este usuário já está cadastrado! \n\n" + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    liteBd.FecharConexao();
                    CarregaGrid();
                    break;

                case "EXCLUIR": //Excluir
                    DialogResult resposta;
                    resposta = MessageBox.Show("Tem certeza que deseja apagar o usuário " + txtUsuario.Text + " ?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.No)
                        return;
                    try
                    {
                        liteBd.InsertDeleteUpdate("DELETE FROM Usuarios WHERE id_usuario = "+ txtIdUsuario.Text);
                        Limpar_Campos();
                        Esconder_Campos();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    liteBd.FecharConexao();
                    CarregaGrid();
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Esconder_Campos();

            txtUsuario.Enabled = true;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            cboxResetar.Enabled = true;

            Limpar_Campos();
        }

        
    }
}
