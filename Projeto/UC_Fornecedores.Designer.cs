namespace PetShop
{
    partial class UC_Fornecedores
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdFornecidos = new System.Windows.Forms.RichTextBox();
            this.txtEndereco = new System.Windows.Forms.RichTextBox();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(30, 293);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 25);
            this.btnEnviar.TabIndex = 28;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(92, 185);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(99, 23);
            this.txtTelefone.TabIndex = 24;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(91, 88);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(100, 23);
            this.txtCNPJ.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 34);
            this.label6.TabIndex = 17;
            this.label6.Text = "Produto(s) fornecido(s)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 23);
            this.txtNome.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome";
            // 
            // txtProdFornecidos
            // 
            this.txtProdFornecidos.Location = new System.Drawing.Point(91, 126);
            this.txtProdFornecidos.Name = "txtProdFornecidos";
            this.txtProdFornecidos.Size = new System.Drawing.Size(171, 53);
            this.txtProdFornecidos.TabIndex = 30;
            this.txtProdFornecidos.Text = "";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(91, 223);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(171, 58);
            this.txtEndereco.TabIndex = 30;
            this.txtEndereco.Text = "";
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.AllowUserToResizeRows = false;
            this.dgvFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFornecedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(286, 21);
            this.dgvFornecedores.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.dgvFornecedores.Name = "dgvFornecedores";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFornecedores.RowHeadersVisible = false;
            this.dgvFornecedores.RowTemplate.Height = 25;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(499, 336);
            this.dgvFornecedores.TabIndex = 32;
            // 
            // UC_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtProdFornecidos);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UC_Fornecedores";
            this.Size = new System.Drawing.Size(793, 378);
            this.Load += new System.EventHandler(this.UC_Fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtProdFornecidos;
        private System.Windows.Forms.RichTextBox txtEndereco;
        private System.Windows.Forms.DataGridView dgvFornecedores;
    }
}
