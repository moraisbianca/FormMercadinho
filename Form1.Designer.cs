namespace SuperMercado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.inserir = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.lstproduto = new System.Windows.Forms.ListView();
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.novo = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.totproduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // inserir
            // 
            this.inserir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inserir.Location = new System.Drawing.Point(237, 177);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(147, 57);
            this.inserir.TabIndex = 3;
            this.inserir.Text = "Inserir Produto";
            this.inserir.UseVisualStyleBackColor = false;
            this.inserir.Click += new System.EventHandler(this.inserir_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(33, 40);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Produto";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(33, 89);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Quantidade:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(33, 139);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(54, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Valor unit.";
            // 
            // txtproduto
            // 
            this.txtproduto.AcceptsTab = true;
            this.txtproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproduto.Location = new System.Drawing.Point(141, 32);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(379, 26);
            this.txtproduto.TabIndex = 0;
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(141, 131);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(379, 26);
            this.txtvalor.TabIndex = 2;
            // 
            // txtquant
            // 
            this.txtquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquant.Location = new System.Drawing.Point(141, 81);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(379, 26);
            this.txtquant.TabIndex = 1;
            // 
            // lstproduto
            // 
            this.lstproduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Produto,
            this.qnt,
            this.Valor,
            this.totproduto});
            this.lstproduto.Enabled = false;
            this.lstproduto.HideSelection = false;
            this.lstproduto.Location = new System.Drawing.Point(12, 252);
            this.lstproduto.Name = "lstproduto";
            this.lstproduto.Size = new System.Drawing.Size(609, 292);
            this.lstproduto.TabIndex = 7;
            this.lstproduto.UseCompatibleStateImageBehavior = false;
            this.lstproduto.View = System.Windows.Forms.View.Details;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            // 
            // qnt
            // 
            this.qnt.Text = "Qntd.";
            // 
            // Valor
            // 
            this.Valor.Text = "Valor Unit.";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(33, 593);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(86, 13);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Total da Venda: ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(141, 584);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 13);
            this.lbltotal.TabIndex = 9;
            // 
            // novo
            // 
            this.novo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novo.Location = new System.Drawing.Point(144, 647);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(110, 51);
            this.novo.TabIndex = 4;
            this.novo.Text = "Nova Venda";
            this.novo.UseVisualStyleBackColor = false;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // fechar
            // 
            this.fechar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.Location = new System.Drawing.Point(341, 647);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(109, 51);
            this.fechar.TabIndex = 5;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(209, 593);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(28, 13);
            this.total.TabIndex = 12;
            this.total.Text = "0,00";
            // 
            // totproduto
            // 
            this.totproduto.Text = "Total por produto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(633, 744);
            this.Controls.Add(this.total);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.novo);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lstproduto);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.inserir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperMercado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.ListView lstproduto;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.Button fechar;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader qnt;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader totproduto;
    }
}

