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
            this.btnF = new System.Windows.Forms.Button();
            this.btnVarrerpc = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbldatahora = new System.Windows.Forms.Label();
            this.lblnow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVarrD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnF
            // 
            this.btnF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnF.Location = new System.Drawing.Point(124, 210);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(140, 25);
            this.btnF.TabIndex = 6;
            this.btnF.Text = "Varrer na unidade F:";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnVarrerpc
            // 
            this.btnVarrerpc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVarrerpc.Location = new System.Drawing.Point(274, 188);
            this.btnVarrerpc.Name = "btnVarrerpc";
            this.btnVarrerpc.Size = new System.Drawing.Size(140, 23);
            this.btnVarrerpc.TabIndex = 7;
            this.btnVarrerpc.Text = "varrer o computador";
            this.btnVarrerpc.UseVisualStyleBackColor = true;
            this.btnVarrerpc.Click += new System.EventHandler(this.btnVarrerpc_Click);
            // 
            // btnG
            // 
            this.btnG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnG.Location = new System.Drawing.Point(124, 236);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(140, 23);
            this.btnG.TabIndex = 8;
            this.btnG.Text = "Varrer na unidade G:";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnE
            // 
            this.btnE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnE.Location = new System.Drawing.Point(124, 186);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(140, 23);
            this.btnE.TabIndex = 9;
            this.btnE.Text = "Varrer na unidade E:";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnH
            // 
            this.btnH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnH.Location = new System.Drawing.Point(274, 163);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(140, 23);
            this.btnH.TabIndex = 10;
            this.btnH.Text = "Varrer na unidade H:";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.Location = new System.Drawing.Point(274, 217);
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
            // btnVarrD
            // 
            this.btnVarrD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVarrD.Location = new System.Drawing.Point(123, 163);
            this.btnVarrD.Name = "btnVarrD";
            this.btnVarrD.Size = new System.Drawing.Size(140, 23);
            this.btnVarrD.TabIndex = 13;
            this.btnVarrD.Text = "Varrer na unidade D:";
            this.btnVarrD.UseVisualStyleBackColor = true;
            this.btnVarrD.Click += new System.EventHandler(this.btnVarrD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 434);
            this.Controls.Add(this.btnVarrD);
            this.Controls.Add(this.lblnow);
            this.Controls.Add(this.lbldatahora);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnVarrerpc);
            this.Controls.Add(this.btnF);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnVarrerpc;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbldatahora;
        private System.Windows.Forms.Label lblnow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnVarrD;
    }
}

