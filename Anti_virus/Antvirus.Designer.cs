namespace Anti_virus
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbldatahora = new System.Windows.Forms.Label();
            this.lblnow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.btnLimparCmb = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Location = new System.Drawing.Point(397, 380);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(140, 42);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Sair";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lbldatahora
            // 
            this.lbldatahora.Location = new System.Drawing.Point(0, 0);
            this.lbldatahora.Name = "lbldatahora";
            this.lbldatahora.Size = new System.Drawing.Size(100, 23);
            this.lbldatahora.TabIndex = 0;
            // 
            // lblnow
            // 
            this.lblnow.AutoSize = true;
            this.lblnow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblnow.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblnow.Location = new System.Drawing.Point(166, 72);
            this.lblnow.Name = "lblnow";
            this.lblnow.Size = new System.Drawing.Size(75, 28);
            this.lblnow.TabIndex = 12;
            this.lblnow.Text = "label1";
            this.lblnow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tag = "tick.timer1";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(274, 196);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(140, 26);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.toolTip1.SetToolTip(this.btnLimpar, "Executa a limpeza do vírus. ");
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtUnidade
            // 
            this.txtUnidade.Enabled = false;
            this.txtUnidade.ForeColor = System.Drawing.Color.LightGray;
            this.txtUnidade.Location = new System.Drawing.Point(124, 200);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.ReadOnly = true;
            this.txtUnidade.Size = new System.Drawing.Size(139, 20);
            this.txtUnidade.TabIndex = 15;
            this.txtUnidade.TabStop = false;
            this.txtUnidade.Text = "Unidade";
            this.txtUnidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtUnidade, "Exibe as unidades disponíveis");
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Location = new System.Drawing.Point(124, 235);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(139, 21);
            this.cmbUnidade.TabIndex = 16;
            this.toolTip1.SetToolTip(this.cmbUnidade, "Selecione a unidade para realizar a limpeza.");
            // 
            // btnLimparCmb
            // 
            this.btnLimparCmb.Location = new System.Drawing.Point(274, 231);
            this.btnLimparCmb.Name = "btnLimparCmb";
            this.btnLimparCmb.Size = new System.Drawing.Size(140, 26);
            this.btnLimparCmb.TabIndex = 17;
            this.btnLimparCmb.Text = "Limpar";
            this.btnLimparCmb.UseVisualStyleBackColor = true;
            this.btnLimparCmb.Click += new System.EventHandler(this.btnLimparCmb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 434);
            this.Controls.Add(this.btnLimparCmb);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblnow);
            this.Controls.Add(this.lbldatahora);
            this.Controls.Add(this.btncancelar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbldatahora;
        private System.Windows.Forms.Label lblnow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.Button btnLimparCmb;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

