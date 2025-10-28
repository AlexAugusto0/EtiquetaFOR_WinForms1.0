namespace EtiquetaFOR
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            senhaBox = new TextBox();
            Usuario = new Label();
            Senha = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnLogar = new Button();
            btnFechar = new Button();
            usuarioBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icone_novo_2025_PNG;
            pictureBox1.Location = new Point(138, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_24_de_out__de_2025__09_11_06;
            pictureBox2.Location = new Point(685, 386);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // senhaBox
            // 
            senhaBox.Location = new Point(308, 294);
            senhaBox.Name = "senhaBox";
            senhaBox.Size = new Size(207, 23);
            senhaBox.TabIndex = 1;
            senhaBox.TextChanged += senhaBox_TextChanged;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.ForeColor = Color.White;
            Usuario.Location = new Point(213, 249);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(50, 15);
            Usuario.TabIndex = 4;
            Usuario.Text = "Usuário:";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.ForeColor = Color.White;
            Senha.Location = new Point(213, 302);
            Senha.Name = "Senha";
            Senha.Size = new Size(42, 15);
            Senha.TabIndex = 5;
            Senha.Text = "Senha:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.SoftcomTecnologia;
            pictureBox3.Location = new Point(286, 75);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(308, 110);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.EtiquetaFOR;
            pictureBox4.Location = new Point(24, 386);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 19);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // btnLogar
            // 
            btnLogar.Cursor = Cursors.Hand;
            btnLogar.Location = new Point(440, 356);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 3;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Location = new Point(308, 356);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // usuarioBox
            // 
            usuarioBox.FormattingEnabled = true;
            usuarioBox.Location = new Point(308, 241);
            usuarioBox.Name = "usuarioBox";
            usuarioBox.Size = new Size(207, 23);
            usuarioBox.TabIndex = 0;
            usuarioBox.SelectedIndexChanged += usuarioBox_SelectedIndexChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(752, 434);
            Controls.Add(usuarioBox);
            Controls.Add(btnFechar);
            Controls.Add(btnLogar);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(Senha);
            Controls.Add(Usuario);
            Controls.Add(senhaBox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EtiquetaFOR - v1.0";
            Load += Main_Load;
            KeyDown += Main_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox senhaBox;
        private Label Usuario;
        private Label Senha;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnLogar;
        private Button btnFechar;
        private ComboBox usuarioBox;
    }
}
