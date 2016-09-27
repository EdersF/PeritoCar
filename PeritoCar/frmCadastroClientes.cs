using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace PeritoCar
{
    public partial class frmCadastroClientes : Form
    {
        LiteBD liteBd = new LiteBD();
        Point ponto;
        string Operacao;

        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            CarregaGrid();
        }

        private void Mostrar_Campos()
        {
            //Desabilitando botões
            btnAlterar.Enabled = false;
            btnIncluir.Enabled = false;
            btn_excluir.Enabled = false;
            //Recolhendo Grid para mostrar os campos
            for (int y = 55; y < 176; y++)
            {
                ponto.Y = y;
                ponto.X = 12;
                dgvClientes.Location = ponto;
                dgvClientes.Height--;
            }
        }

        private void Esconder_Campos()
        {   //Habilitando botões
            btnAlterar.Enabled = true;
            btnIncluir.Enabled = true;
            btn_excluir.Enabled = true;
            //Aumentando Grid para esconder os campos
            for (int y = 175; y > 54; y--)
            {
                ponto.Y = y;
                ponto.X = 12;
                dgvClientes.Location = ponto;
                dgvClientes.Height++;
            }
        }

        private void Limpar_Campos()
        {
            txtIdCliente.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtEnd.Text = "";
            txtCidade.Text = "";
            mtxtCEP.Text = "";
            mtxtTel1.Text = "";
            mtxtTel2.Text = "";
            txtOperadora1.Text = "";
            txtOperadora2.Text = "";
            mtxtCPF.Text = "";
            mtxtCNPJ.Text = "";
        }

        public void CarregaGrid()
        {
            dgvClientes.Rows.Clear();
            SQLiteDataReader retornoBD = liteBd.ConsultaReader("SELECT * FROM Clientes ORDER BY NOME");
            while (retornoBD.Read())
            {
                dgvClientes.Rows.Add(retornoBD[0], retornoBD[1], retornoBD[2], retornoBD[3], retornoBD[4], retornoBD[5], retornoBD[6], retornoBD[7], retornoBD[8], retornoBD[9], retornoBD[10], retornoBD[11]);
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
            txtIdCliente.Text = dgvClientes.CurrentRow.Cells["colCodCli"].Value.ToString();
            txtNome.Text = dgvClientes.CurrentRow.Cells["colnome"].Value.ToString();
            txtEnd.Text = dgvClientes.CurrentRow.Cells["colEndereco"].Value.ToString();
            txtCidade.Text = dgvClientes.CurrentRow.Cells["colCidade"].Value.ToString();
            mtxtCEP.Text = dgvClientes.CurrentRow.Cells["colcep"].Value.ToString();
            txtEmail.Text = dgvClientes.CurrentRow.Cells["colemail"].Value.ToString();
            mtxtTel1.Text = dgvClientes.CurrentRow.Cells["coltelefone1"].Value.ToString();
            txtOperadora1.Text = dgvClientes.CurrentRow.Cells["colOperadora"].Value.ToString();
            mtxtTel2.Text = dgvClientes.CurrentRow.Cells["colTelefone2"].Value.ToString();
            txtOperadora2.Text = dgvClientes.CurrentRow.Cells["colOperadora2"].Value.ToString();
            mtxtCPF.Text = dgvClientes.CurrentRow.Cells["colcpf"].Value.ToString();
            mtxtCNPJ.Text = dgvClientes.CurrentRow.Cells["colcnpj"].Value.ToString();

            Operacao = "ALTERAR";
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Mostrar_Campos();
            //Preenchendo os campos com os dados da linha selecionada
            txtIdCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtEnd.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtCidade.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            mtxtCEP.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            mtxtTel1.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            txtOperadora1.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            mtxtTel2.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
            txtOperadora2.Text = dgvClientes.CurrentRow.Cells[9].Value.ToString();
            mtxtCPF.Text = dgvClientes.CurrentRow.Cells[10].Value.ToString();
            mtxtCNPJ.Text = dgvClientes.CurrentRow.Cells[11].Value.ToString();

            txtIdCliente.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtCidade.Enabled = false;
            mtxtCEP.Enabled = false;
            mtxtTel1.Enabled = false;
            mtxtTel2.Enabled = false;
            txtOperadora1.Enabled = false;
            txtOperadora2.Enabled = false;
            mtxtCPF.Enabled = false;
            mtxtCNPJ.Enabled = false;

            Operacao = "EXCLUIR";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (Operacao)
            {
                case "INCLUIR": //Incluir
                    if (txtNome.Text == "")
                    {//Se os campos estiverem vazios
                        MessageBox.Show("O Nome do cliente não pode ficar vazio!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Focus();
                        return;
                    }
                    try
                    {//Inserindo no Banco de Dados
                        liteBd.InsertDeleteUpdate("INSERT INTO Clientes (nome, endereco, cidade, cep, telefone1, telefone2, email, operadora1, operadora2, cpf, cnpj) " +
                        "VALUES ('" + txtNome.Text + "', '" + txtEnd.Text + "', '" + txtCidade.Text + "', '"+ mtxtCEP.Text +"', '"+ mtxtTel1.Text +"', '"+ mtxtTel2.Text +"', '"+ txtEmail.Text +"', '"+ txtOperadora1.Text +"', '"+ txtOperadora2.Text +"', '"+ mtxtCPF.Text +"', '"+ mtxtCNPJ.Text +"')");
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
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Os campos obrigatórios não podem estar vazios!", "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Focus();
                        return;
                    }
                    try
                    {
                        liteBd.InsertDeleteUpdate("UPDATE Clientes SET nome = '" + txtNome.Text + "', endereco = '" + txtEnd.Text + "', " +
                            "cidade = '" + txtCidade.Text + "', cep = '" + mtxtCEP.Text + "', telefone1= '" + mtxtTel1.Text + "', " +
                            "telefone2= '" + mtxtTel2.Text + "', email= '" + txtEmail.Text + "', operadora1= '" + txtOperadora1.Text + "', " +
                            "operadora2= '" + txtOperadora2.Text + "', cpf = '" + mtxtCPF.Text + "', cnpj = '" + mtxtCNPJ.Text + "' " +
                        "WHERE id_cliente = " + txtIdCliente.Text);
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
                    resposta = MessageBox.Show("Tem certeza que deseja apagar este Cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.No)
                        return;
                    try
                    {
                        liteBd.InsertDeleteUpdate("DELETE FROM CLientes WHERE id_cliente = " + txtIdCliente.Text);
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

            txtIdCliente.Enabled = true;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEnd.Enabled = true;
            txtCidade.Enabled = true;
            mtxtCEP.Enabled = true;
            mtxtTel1.Enabled = true;
            mtxtTel2.Enabled = true;
            txtOperadora1.Enabled = true;
            txtOperadora2.Enabled = true;
            mtxtCEP.Enabled = true;
            mtxtCNPJ.Enabled = true;

            Limpar_Campos();
        }
    }
}
