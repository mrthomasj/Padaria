namespace Padaria
{
    partial class UserForm
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
            this.panFunc = new System.Windows.Forms.Panel();
            this.lblNm = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatric = new System.Windows.Forms.TextBox();
            this.lblMatric = new System.Windows.Forms.Label();
            this.lvlDtNasc = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtLogr = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxUf = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.panFunc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFunc
            // 
            this.panFunc.Controls.Add(this.txtTel2);
            this.panFunc.Controls.Add(this.lblTel2);
            this.panFunc.Controls.Add(this.txtTel1);
            this.panFunc.Controls.Add(this.lblTel1);
            this.panFunc.Controls.Add(this.cmbBoxUf);
            this.panFunc.Controls.Add(this.label4);
            this.panFunc.Controls.Add(this.txtCidade);
            this.panFunc.Controls.Add(this.lblCidade);
            this.panFunc.Controls.Add(this.txtBairro);
            this.panFunc.Controls.Add(this.lblBairro);
            this.panFunc.Controls.Add(this.txtLogr);
            this.panFunc.Controls.Add(this.lblLog);
            this.panFunc.Controls.Add(this.maskedTextBox1);
            this.panFunc.Controls.Add(this.lvlDtNasc);
            this.panFunc.Controls.Add(this.txtMatric);
            this.panFunc.Controls.Add(this.lblMatric);
            this.panFunc.Controls.Add(this.txtCpf);
            this.panFunc.Controls.Add(this.lblCpf);
            this.panFunc.Controls.Add(this.txtNome);
            this.panFunc.Controls.Add(this.lblNm);
            this.panFunc.Location = new System.Drawing.Point(68, 25);
            this.panFunc.Name = "panFunc";
            this.panFunc.Size = new System.Drawing.Size(796, 163);
            this.panFunc.TabIndex = 0;
            // 
            // lblNm
            // 
            this.lblNm.AutoSize = true;
            this.lblNm.Location = new System.Drawing.Point(15, 14);
            this.lblNm.Name = "lblNm";
            this.lblNm.Size = new System.Drawing.Size(38, 13);
            this.lblNm.TabIndex = 0;
            this.lblNm.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtMatric
            // 
            this.txtMatric.Location = new System.Drawing.Point(527, 30);
            this.txtMatric.Name = "txtMatric";
            this.txtMatric.Size = new System.Drawing.Size(61, 20);
            this.txtMatric.TabIndex = 5;
            // 
            // lblMatric
            // 
            this.lblMatric.AutoSize = true;
            this.lblMatric.Location = new System.Drawing.Point(524, 14);
            this.lblMatric.Name = "lblMatric";
            this.lblMatric.Size = new System.Drawing.Size(50, 13);
            this.lblMatric.TabIndex = 4;
            this.lblMatric.Text = "Matricula";
            // 
            // lvlDtNasc
            // 
            this.lvlDtNasc.AutoSize = true;
            this.lvlDtNasc.Location = new System.Drawing.Point(389, 14);
            this.lvlDtNasc.Name = "lvlDtNasc";
            this.lvlDtNasc.Size = new System.Drawing.Size(107, 13);
            this.lvlDtNasc.TabIndex = 6;
            this.lvlDtNasc.Text = "Data de Nascimento:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(392, 30);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(232, 14);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(26, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "Cpf:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(235, 30);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(111, 20);
            this.txtCpf.TabIndex = 3;
            // 
            // txtLogr
            // 
            this.txtLogr.Location = new System.Drawing.Point(18, 85);
            this.txtLogr.Name = "txtLogr";
            this.txtLogr.Size = new System.Drawing.Size(192, 20);
            this.txtLogr.TabIndex = 9;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(15, 69);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(53, 13);
            this.lblLog.TabIndex = 8;
            this.lblLog.Text = "Endereço";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(392, 85);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(111, 20);
            this.txtCidade.TabIndex = 13;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(389, 69);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 12;
            this.lblCidade.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "UF:";
            // 
            // cmbBoxUf
            // 
            this.cmbBoxUf.FormattingEnabled = true;
            this.cmbBoxUf.Location = new System.Drawing.Point(527, 84);
            this.cmbBoxUf.Name = "cmbBoxUf";
            this.cmbBoxUf.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUf.TabIndex = 15;
            this.cmbBoxUf.Text = "Selecione...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRePass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Location = new System.Drawing.Point(68, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 51);
            this.panel1.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(235, 19);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(111, 20);
            this.txtPass.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(18, 19);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(111, 20);
            this.txtLogin.TabIndex = 13;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(15, 3);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Login:";
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(392, 19);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(111, 20);
            this.txtRePass.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Confirmar a senha:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(232, 69);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 10;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(235, 85);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(111, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(18, 131);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(111, 20);
            this.txtTel1.TabIndex = 17;
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(15, 115);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(61, 13);
            this.lblTel1.TabIndex = 16;
            this.lblTel1.Text = "Telefone 1:";
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(235, 131);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(111, 20);
            this.txtTel2.TabIndex = 19;
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(232, 115);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(61, 13);
            this.lblTel2.TabIndex = 18;
            this.lblTel2.Text = "Telefone 2:";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(68, 313);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(158, 24);
            this.btnCad.TabIndex = 2;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 611);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panFunc);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panFunc.ResumeLayout(false);
            this.panFunc.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFunc;
        private System.Windows.Forms.Label lblNm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtLogr;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lvlDtNasc;
        private System.Windows.Forms.TextBox txtMatric;
        private System.Windows.Forms.Label lblMatric;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbBoxUf;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnCad;
    }
}