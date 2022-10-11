namespace PetShop
{
    partial class UC_Produtos
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.Location = new System.Drawing.Point(150, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(137, 23);
            this.txtNome.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviar.Location = new System.Drawing.Point(594, 49);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 25);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtValor.Location = new System.Drawing.Point(372, 22);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Unidade de medida";
            // 
            // txtMedida
            // 
            this.txtMedida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMedida.Location = new System.Drawing.Point(594, 21);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(100, 23);
            this.txtMedida.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMarca.Location = new System.Drawing.Point(150, 54);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(137, 23);
            this.txtMarca.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade";
            // 
            // txtQtd
            // 
            this.txtQtd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQtd.Location = new System.Drawing.Point(372, 51);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 23);
            this.txtQtd.TabIndex = 1;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(8, 111);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.dgvProdutos.Name = "dgvProdutos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(777, 264);
            this.dgvProdutos.TabIndex = 9;
            // 
            // UC_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UC_Produtos";
            this.Size = new System.Drawing.Size(793, 378);
            this.Load += new System.EventHandler(this.UC_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}
