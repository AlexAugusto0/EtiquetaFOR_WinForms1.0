namespace EtiquetaFOR
{
    partial class configuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configuracoes));
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            btnExibirSenha = new PictureBox();
            textBanco = new TextBox();
            textSenha = new TextBox();
            textUsuario = new TextBox();
            textPorta = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textServidor = new TextBox();
            TestarConexao = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExibirSenha).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(TestarConexao);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 310);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 35);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 12;
            label6.Text = "Login para o Servidor";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnExibirSenha);
            panel2.Controls.Add(textBanco);
            panel2.Controls.Add(textSenha);
            panel2.Controls.Add(textUsuario);
            panel2.Controls.Add(textPorta);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textServidor);
            panel2.Location = new Point(23, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 202);
            panel2.TabIndex = 11;
            // 
            // btnExibirSenha
            // 
            btnExibirSenha.Cursor = Cursors.Hand;
            btnExibirSenha.Image = Properties.Resources.olho_senha;
            btnExibirSenha.Location = new Point(393, 129);
            btnExibirSenha.Name = "btnExibirSenha";
            btnExibirSenha.Size = new Size(27, 25);
            btnExibirSenha.SizeMode = PictureBoxSizeMode.Zoom;
            btnExibirSenha.TabIndex = 11;
            btnExibirSenha.TabStop = false;
            btnExibirSenha.Click += pictureBox1_Click;
            // 
            // textBanco
            // 
            textBanco.Location = new Point(158, 162);
            textBanco.Name = "textBanco";
            textBanco.Size = new Size(229, 23);
            textBanco.TabIndex = 10;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(158, 128);
            textSenha.Name = "textSenha";
            textSenha.ReadOnly = true;
            textSenha.Size = new Size(229, 23);
            textSenha.TabIndex = 9;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(158, 92);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(229, 23);
            textUsuario.TabIndex = 8;
            // 
            // textPorta
            // 
            textPorta.Location = new Point(158, 54);
            textPorta.Name = "textPorta";
            textPorta.Size = new Size(229, 23);
            textPorta.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 156);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 6;
            label5.Text = "Banco de Dados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 128);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 93);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 62);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Porta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Servidor:";
            // 
            // textServidor
            // 
            textServidor.BackColor = SystemColors.Control;
            textServidor.Location = new Point(158, 21);
            textServidor.Name = "textServidor";
            textServidor.Size = new Size(229, 23);
            textServidor.TabIndex = 1;
            // 
            // TestarConexao
            // 
            TestarConexao.Location = new Point(354, 249);
            TestarConexao.Name = "TestarConexao";
            TestarConexao.Size = new Size(104, 36);
            TestarConexao.TabIndex = 0;
            TestarConexao.Text = "Testar Conexão";
            TestarConexao.UseVisualStyleBackColor = true;
            TestarConexao.Click += TestarConexao_Click;
            // 
            // configuracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(511, 334);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "configuracoes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Configurações";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExibirSenha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button TestarConexao;
        private TextBox textServidor;
        private Label label1;
        private Label label6;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox textBanco;
        private TextBox textSenha;
        private TextBox textUsuario;
        private TextBox textPorta;
        private Label label5;
        private Label label4;
        private PictureBox btnExibirSenha;
    }
}