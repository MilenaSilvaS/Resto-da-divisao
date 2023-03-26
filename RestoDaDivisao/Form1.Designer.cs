
namespace RestoDaDivisao
{
    partial class FrmRestoDaDivisao
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
            this.lblDividendo = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.btnRealizarDivisao = new System.Windows.Forms.Button();
            this.lblResto = new System.Windows.Forms.Label();
            this.txtRestoDaDivisao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(13, 12);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(58, 13);
            this.lblDividendo.TabIndex = 0;
            this.lblDividendo.Text = "Dividendo:";
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(68, 9);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(107, 20);
            this.txtDividendo.TabIndex = 1;
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(191, 12);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(42, 13);
            this.lblDivisor.TabIndex = 2;
            this.lblDivisor.Text = "Divisor:";
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(239, 9);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(107, 20);
            this.txtDivisor.TabIndex = 3;
            // 
            // btnRealizarDivisao
            // 
            this.btnRealizarDivisao.Location = new System.Drawing.Point(36, 36);
            this.btnRealizarDivisao.Name = "btnRealizarDivisao";
            this.btnRealizarDivisao.Size = new System.Drawing.Size(139, 24);
            this.btnRealizarDivisao.TabIndex = 4;
            this.btnRealizarDivisao.Text = "Realizar Divisão";
            this.btnRealizarDivisao.UseVisualStyleBackColor = true;
            this.btnRealizarDivisao.Click += new System.EventHandler(this.btnRealizarDivisao_Click);
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(194, 43);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(38, 13);
            this.lblResto.TabIndex = 5;
            this.lblResto.Text = "Resto:";
            // 
            // txtRestoDaDivisao
            // 
            this.txtRestoDaDivisao.Enabled = false;
            this.txtRestoDaDivisao.Location = new System.Drawing.Point(239, 40);
            this.txtRestoDaDivisao.Name = "txtRestoDaDivisao";
            this.txtRestoDaDivisao.ReadOnly = true;
            this.txtRestoDaDivisao.Size = new System.Drawing.Size(107, 20);
            this.txtRestoDaDivisao.TabIndex = 6;
            // 
            // FrmRestoDaDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 71);
            this.Controls.Add(this.txtRestoDaDivisao);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.btnRealizarDivisao);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.lblDividendo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRestoDaDivisao";
            this.Text = "Resto de uma divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Button btnRealizarDivisao;
        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.TextBox txtRestoDaDivisao;
    }
}

