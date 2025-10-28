using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Text.Json;

namespace EtiquetaFOR
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            senhaBox.UseSystemPasswordChar = true; // Esconde caracteres
            senhaBox.KeyDown += senhaBox_KeyDown;  // Detecta tecla F11
            this.Text = AppInfo.GetTituloAplicacao();
            LoadUsuarios();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            usuarioBox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            configuracoes tela = new configuracoes();
            tela.ShowDialog();
        }

        private void senhaBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void senhaBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                e.SuppressKeyPress = true; // evita beep do F11

                if (senhaBox.Text == "suporte@softcom")
                {
                    // senha correta → abre a tela de configurações
                    telaTecnico tela = new telaTecnico();
                    tela.ShowDialog();
                    senhaBox.Clear(); // limpa a senha
                }
                else
                {
                    // senha incorreta → mensagem humanizada
                    MessageBox.Show(
                        "Ops! A senha digitada não confere, " +
                        "Verifique e tente novamente, por favor.",
                        "Senha incorreta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    senhaBox.Clear();       // limpa campo
                    senhaBox.Focus();       // foca de novo no TextBox
                }
            }
        }
        private void AbrirTelaConfiguracoes()
        {
            telaTecnico tela = new telaTecnico();
            tela.ShowDialog(); // abre como modal (travando a principal)
        }
        public static class AppInfo
        {
            public static string GetTituloAplicacao()
            {
                string nome = Assembly.GetExecutingAssembly().GetName().Name;
                //Version versao = Assembly.GetExecutingAssembly().GetName().Version;
                return $"{nome} - v1.0";
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string senha = senhaBox.Text.Trim();

            if (usuarioBox.SelectedItem == null || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha o usuário e a senha.",
                                "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoSelecionado = ((ComboItem)usuarioBox.SelectedItem).Value;

            try
            {
                // Caminho da configuração
                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

                if (!File.Exists(caminhoArquivo))
                {
                    MessageBox.Show("⚠️ Configuração de banco não encontrada. Configure primeiro nas Configurações.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string json = File.ReadAllText(caminhoArquivo);
                var config = JsonSerializer.Deserialize<ConfiguracaoBD>(json);

                // Monta connection string
                string servidorCompleto = string.IsNullOrEmpty(config.Porta)
                    ? config.Servidor
                    : $"{config.Servidor},{config.Porta}";

                string connectionString =
                    $"Server={servidorCompleto};Database={config.Banco};User Id={config.Usuario};Password={config.Senha};TrustServerCertificate=True;";

                // Faz a verificação de login
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    string query = @"SELECT [Nome] 
                                     FROM [Cadastro De Vendedores] 
                                     WHERE [Código do Vendedor] = @codigo AND [Senha] = @Senha";

                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.Add("@Codigo", SqlDbType.NVarChar, 50).Value = codigoSelecionado.Trim();
                        cmd.Parameters.Add("@Senha", SqlDbType.NVarChar, 50).Value = senha.Trim();

                        string nomeVendedor = cmd.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(nomeVendedor))
                        {
                            MessageBox.Show($"✅ Bem-vindo, {nomeVendedor}!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Abre o próximo form e fecha o atual
                            Form telaEntrada = new Entrada();
                            telaEntrada.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("❌ Usuário ou senha incorretos.\nVerifique e tente novamente.",
                                            "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar logar:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usuarioBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadUsuarios()
        {
            try
            {
                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
                if (!File.Exists(caminhoArquivo)) return;

                string json = System.IO.File.ReadAllText(caminhoArquivo);
                var config = JsonSerializer.Deserialize<ConfiguracaoBD>(json);

                string servidorCompleto = string.IsNullOrEmpty(config.Porta) ? config.Servidor : $"{config.Servidor},{config.Porta}";
                string connectionString = $"Server={servidorCompleto};Database={config.Banco};User Id={config.Usuario};Password={config.Senha};TrustServerCertificate=True;";

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    string query = "SELECT [Código do Vendedor], [Nome] FROM [Cadastro De Vendedores] ORDER BY [Nome]";


                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        usuarioBox.Items.Clear();
                        while (reader.Read())
                        {
                            usuarioBox.Items.Add(new ComboItem
                            {
                                Text = reader["Nome"].ToString(),      // visível
                                Value = reader["Código do Vendedor"].ToString()    // invisível
                            });
                        }
                    }
                }

                usuarioBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                usuarioBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                usuarioBox.DisplayMember = "Text"; // mostra nome
                usuarioBox.ValueMember = "Value";  // código interno
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuários:\n{ex.Message}");
            }
        }
        public class ComboItem
        {
            public string Text { get; set; }  // Nome visível
            public string Value { get; set; } // Código invisível
            public override string ToString() => Text;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // impede o "bip" do Enter
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    

