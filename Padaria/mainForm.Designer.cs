namespace Padaria
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItCadUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItCadProd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUser,
            this.mnProd});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnUser
            // 
            this.mnUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItLogin,
            this.mnItLogout,
            this.mnItCadUser});
            this.mnUser.Name = "mnUser";
            this.mnUser.Size = new System.Drawing.Size(59, 20);
            this.mnUser.Text = "Usuário";
            // 
            // mnItLogin
            // 
            this.mnItLogin.Name = "mnItLogin";
            this.mnItLogin.Size = new System.Drawing.Size(180, 22);
            this.mnItLogin.Text = "Login...";
            this.mnItLogin.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // mnItLogout
            // 
            this.mnItLogout.Name = "mnItLogout";
            this.mnItLogout.Size = new System.Drawing.Size(180, 22);
            this.mnItLogout.Text = "Logout...";
            this.mnItLogout.Visible = false;
            this.mnItLogout.Click += new System.EventHandler(this.mnItLogout_Click);
            // 
            // mnItCadUser
            // 
            this.mnItCadUser.Name = "mnItCadUser";
            this.mnItCadUser.Size = new System.Drawing.Size(180, 22);
            this.mnItCadUser.Text = "Cadastro";
            this.mnItCadUser.Visible = false;
            this.mnItCadUser.Click += new System.EventHandler(this.mnItCadUser_Click);
            // 
            // mnProd
            // 
            this.mnProd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItCadProd,
            this.mnItEstoque});
            this.mnProd.Enabled = false;
            this.mnProd.Name = "mnProd";
            this.mnProd.Size = new System.Drawing.Size(67, 20);
            this.mnProd.Text = "Produtos";
            // 
            // mnItCadProd
            // 
            this.mnItCadProd.Name = "mnItCadProd";
            this.mnItCadProd.Size = new System.Drawing.Size(180, 22);
            this.mnItCadProd.Text = "Cadastro";
            this.mnItCadProd.Click += new System.EventHandler(this.mnItCadProd_Click);
            // 
            // mnItEstoque
            // 
            this.mnItEstoque.Name = "mnItEstoque";
            this.mnItEstoque.Size = new System.Drawing.Size(180, 22);
            this.mnItEstoque.Text = "Consulta Estoque";
            this.mnItEstoque.Click += new System.EventHandler(this.consultaEstoqueToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Padaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnUser;
        public System.Windows.Forms.ToolStripMenuItem mnItLogin;
        public System.Windows.Forms.ToolStripMenuItem mnItLogout;
        public System.Windows.Forms.ToolStripMenuItem mnItCadUser;
        public System.Windows.Forms.ToolStripMenuItem mnProd;
        public System.Windows.Forms.ToolStripMenuItem mnItCadProd;
        public System.Windows.Forms.ToolStripMenuItem mnItEstoque;
    }
}

