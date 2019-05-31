namespace Colisão_e_gravidade_no_Csharp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EU_SOU_O_TEMPO = new System.Windows.Forms.Timer(this.components);
            this.BTN_CAIXA = new System.Windows.Forms.Button();
            this.BTN_CHAO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EU_SOU_O_TEMPO
            // 
            this.EU_SOU_O_TEMPO.Enabled = true;
            this.EU_SOU_O_TEMPO.Interval = 1;
            this.EU_SOU_O_TEMPO.Tick += new System.EventHandler(this.EU_SOU_O_TEMPO_Tick_1);
            // 
            // BTN_CAIXA
            // 
            this.BTN_CAIXA.BackColor = System.Drawing.Color.Transparent;
            this.BTN_CAIXA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_CAIXA.BackgroundImage")));
            this.BTN_CAIXA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_CAIXA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CAIXA.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CAIXA.Location = new System.Drawing.Point(220, 12);
            this.BTN_CAIXA.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_CAIXA.Name = "BTN_CAIXA";
            this.BTN_CAIXA.Size = new System.Drawing.Size(109, 101);
            this.BTN_CAIXA.TabIndex = 0;
            this.BTN_CAIXA.UseVisualStyleBackColor = false;
            // 
            // BTN_CHAO
            // 
            this.BTN_CHAO.BackColor = System.Drawing.Color.Transparent;
            this.BTN_CHAO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_CHAO.BackgroundImage")));
            this.BTN_CHAO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_CHAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CHAO.ForeColor = System.Drawing.Color.Transparent;
            this.BTN_CHAO.Location = new System.Drawing.Point(52, 559);
            this.BTN_CHAO.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_CHAO.Name = "BTN_CHAO";
            this.BTN_CHAO.Size = new System.Drawing.Size(456, 54);
            this.BTN_CHAO.TabIndex = 1;
            this.BTN_CHAO.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 631);
            this.Controls.Add(this.BTN_CHAO);
            this.Controls.Add(this.BTN_CAIXA);
            this.Name = "Form1";
            this.Text = "Gravidade e Colisão no Csharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer EU_SOU_O_TEMPO;
        private System.Windows.Forms.Button BTN_CAIXA;
        private System.Windows.Forms.Button BTN_CHAO;
    }
}

