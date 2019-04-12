namespace Padaria
{
    partial class CadProdForm
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
            this.panProd = new System.Windows.Forms.Panel();
            this.txtVlr = new System.Windows.Forms.TextBox();
            this.lblVlr = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNm = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.panProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panProd
            // 
            this.panProd.Controls.Add(this.txtVlr);
            this.panProd.Controls.Add(this.lblVlr);
            this.panProd.Controls.Add(this.txtQtd);
            this.panProd.Controls.Add(this.lblQtd);
            this.panProd.Controls.Add(this.txtCat);
            this.panProd.Controls.Add(this.lblCategoria);
            this.panProd.Controls.Add(this.txtMarca);
            this.panProd.Controls.Add(this.lblMarca);
            this.panProd.Controls.Add(this.txtNome);
            this.panProd.Controls.Add(this.lblNm);
            this.panProd.Location = new System.Drawing.Point(12, 12);
            this.panProd.Name = "panProd";
            this.panProd.Size = new System.Drawing.Size(520, 132);
            this.panProd.TabIndex = 1;
            // 
            // txtVlr
            // 
            this.txtVlr.Location = new System.Drawing.Point(18, 80);
            this.txtVlr.Name = "txtVlr";
            this.txtVlr.Size = new System.Drawing.Size(111, 20);
            this.txtVlr.TabIndex = 21;
            this.txtVlr.Text = "00,00";
            this.txtVlr.Enter += new System.EventHandler(this.txtVlr_Enter);
            this.txtVlr.Leave += new System.EventHandler(this.txtVlr_Leave);
            // 
            // lblVlr
            // 
            this.lblVlr.AutoSize = true;
            this.lblVlr.Location = new System.Drawing.Point(15, 64);
            this.lblVlr.Name = "lblVlr";
            this.lblVlr.Size = new System.Drawing.Size(95, 13);
            this.lblVlr.TabIndex = 20;
            this.lblVlr.Text = "Valor Unitário/Kilo:";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(235, 80);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(111, 20);
            this.txtQtd.TabIndex = 17;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(232, 64);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(65, 13);
            this.lblQtd.TabIndex = 16;
            this.lblQtd.Text = "Quantidade:";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(372, 30);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(111, 20);
            this.txtCat.TabIndex = 11;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(369, 14);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(235, 30);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(111, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(232, 14);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 20);
            this.txtNome.TabIndex = 1;
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
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(30, 164);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(192, 28);
            this.btnCad.TabIndex = 2;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // CadProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 204);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.panProd);
            this.Name = "CadProdForm";
            this.Text = "Cadastro de produtos";
            this.panProd.ResumeLayout(false);
            this.panProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panProd;
        private System.Windows.Forms.Label lblVlr;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNm;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtVlr;
    }
}