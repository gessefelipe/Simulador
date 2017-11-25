namespace Simulador
{
    partial class frmSimulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimulador));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuArquivoCarregar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExecutar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rtbReadFile = new System.Windows.Forms.RichTextBox();
            this.gpbExecutar = new System.Windows.Forms.GroupBox();
            this.btnEditarInstrucoes = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbCodigodaLinha = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menu.SuspendLayout();
            this.gpbExecutar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArquivo,
            this.menuExecutar,
            this.menuDownload});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(411, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuArquivo
            // 
            this.menuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArquivoNovo,
            this.toolStripSeparator2,
            this.menuArquivoCarregar,
            this.menuArquivoSalvar,
            this.toolStripSeparator1,
            this.menuArquivoSair});
            this.menuArquivo.Name = "menuArquivo";
            this.menuArquivo.Size = new System.Drawing.Size(61, 20);
            this.menuArquivo.Text = "Arquivo";
            // 
            // menuArquivoNovo
            // 
            this.menuArquivoNovo.Name = "menuArquivoNovo";
            this.menuArquivoNovo.Size = new System.Drawing.Size(119, 22);
            this.menuArquivoNovo.Text = "Novo";
            this.menuArquivoNovo.Click += new System.EventHandler(this.menuArquivoNovo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(116, 6);
            // 
            // menuArquivoCarregar
            // 
            this.menuArquivoCarregar.Name = "menuArquivoCarregar";
            this.menuArquivoCarregar.Size = new System.Drawing.Size(119, 22);
            this.menuArquivoCarregar.Text = "Carregar";
            this.menuArquivoCarregar.Click += new System.EventHandler(this.menuArquivoCarregar_Click);
            // 
            // menuArquivoSalvar
            // 
            this.menuArquivoSalvar.Name = "menuArquivoSalvar";
            this.menuArquivoSalvar.Size = new System.Drawing.Size(119, 22);
            this.menuArquivoSalvar.Text = "Salvar";
            this.menuArquivoSalvar.Click += new System.EventHandler(this.menuArquivoSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // menuArquivoSair
            // 
            this.menuArquivoSair.Name = "menuArquivoSair";
            this.menuArquivoSair.Size = new System.Drawing.Size(119, 22);
            this.menuArquivoSair.Text = "Sair";
            this.menuArquivoSair.Click += new System.EventHandler(this.menuArquivoSair_Click);
            // 
            // menuExecutar
            // 
            this.menuExecutar.Name = "menuExecutar";
            this.menuExecutar.Size = new System.Drawing.Size(63, 20);
            this.menuExecutar.Text = "Executar";
            this.menuExecutar.Click += new System.EventHandler(this.menuExecutar_Click);
            // 
            // menuDownload
            // 
            this.menuDownload.Name = "menuDownload";
            this.menuDownload.Size = new System.Drawing.Size(138, 20);
            this.menuDownload.Text = "Download do Neander";
            this.menuDownload.Click += new System.EventHandler(this.menuDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leitura do Arquivo:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Arquivos .txt|*.txt";
            this.openFileDialog1.Title = "Arquivos \'.txt\' Gerados pelo Neader";
            // 
            // rtbReadFile
            // 
            this.rtbReadFile.Location = new System.Drawing.Point(12, 52);
            this.rtbReadFile.Name = "rtbReadFile";
            this.rtbReadFile.ReadOnly = true;
            this.rtbReadFile.Size = new System.Drawing.Size(181, 209);
            this.rtbReadFile.TabIndex = 2;
            this.rtbReadFile.Text = "";
            // 
            // gpbExecutar
            // 
            this.gpbExecutar.Controls.Add(this.btnEditarInstrucoes);
            this.gpbExecutar.Controls.Add(this.btnExecutar);
            this.gpbExecutar.Controls.Add(this.label2);
            this.gpbExecutar.Location = new System.Drawing.Point(199, 181);
            this.gpbExecutar.Name = "gpbExecutar";
            this.gpbExecutar.Size = new System.Drawing.Size(200, 80);
            this.gpbExecutar.TabIndex = 3;
            this.gpbExecutar.TabStop = false;
            this.gpbExecutar.Text = "Executar";
            // 
            // btnEditarInstrucoes
            // 
            this.btnEditarInstrucoes.Location = new System.Drawing.Point(97, 51);
            this.btnEditarInstrucoes.Name = "btnEditarInstrucoes";
            this.btnEditarInstrucoes.Size = new System.Drawing.Size(97, 23);
            this.btnEditarInstrucoes.TabIndex = 2;
            this.btnEditarInstrucoes.Text = "Editar Instruções";
            this.btnEditarInstrucoes.UseVisualStyleBackColor = true;
            this.btnEditarInstrucoes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(6, 51);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Você deseja executar as instruções?";
            // 
            // rtbCodigodaLinha
            // 
            this.rtbCodigodaLinha.Location = new System.Drawing.Point(199, 53);
            this.rtbCodigodaLinha.Name = "rtbCodigodaLinha";
            this.rtbCodigodaLinha.ReadOnly = true;
            this.rtbCodigodaLinha.Size = new System.Drawing.Size(200, 122);
            this.rtbCodigodaLinha.TabIndex = 4;
            this.rtbCodigodaLinha.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mnemônicos: (Apenas para Visualização)";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Arquivos .txt|*.txt";
            this.saveFileDialog1.Title = "Salvar Arquivo como...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(66, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(71, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AC:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(59, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(235, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(71, 67);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PC:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(59, 38);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.richTextBox1.Location = new System.Drawing.Point(6, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(375, 90);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alto Nível:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.richTextBox2.Location = new System.Drawing.Point(9, 151);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(375, 156);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Baixo Nível:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(10, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 386);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // frmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 273);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbCodigodaLinha);
            this.Controls.Add(this.gpbExecutar);
            this.Controls.Add(this.rtbReadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "frmSimulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.gpbExecutar.ResumeLayout(false);
            this.gpbExecutar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuArquivo;
        private System.Windows.Forms.ToolStripMenuItem menuArquivoCarregar;
        private System.Windows.Forms.ToolStripMenuItem menuArquivoSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem menuExecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rtbReadFile;
        private System.Windows.Forms.GroupBox gpbExecutar;
        private System.Windows.Forms.Button btnEditarInstrucoes;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbCodigodaLinha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem menuArquivoNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuDownload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

