namespace EtiquetaFOR
{
    partial class telaTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaTecnico));
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox3 = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(33, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 387);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(400, 159);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(122, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Instalação Manual";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(400, 125);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(140, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Detecção Automática";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(400, 193);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(110, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "CheckBoxTESTE";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // telaTecnico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(687, 446);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "telaTecnico";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EtiquetaFor - v1.0";
            Load += telaTecnico_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
    }
}