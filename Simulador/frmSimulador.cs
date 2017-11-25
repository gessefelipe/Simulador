using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador
{
    public partial class frmSimulador : Form
    {
        public frmSimulador()
        {
            InitializeComponent();
        }
        private void menuArquivoCarregar_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                menuArquivoNovo.Enabled = true;
                menuArquivoCarregar.Enabled = false;

                int key = 1;

                List<string> lines = File.ReadLines(openFileDialog1.FileName).ToList();

                foreach (string current in lines)
                {
                    if (current == "")
                        key = 0;

                    if (key == 1)
                    {
                        int result = verificar_linha(current);
                        if (result == 0)
                        {
                            rtbCodigodaLinha.Text = "ERRO 472: ERRO AO ABRIR O ARQUIVO";
                            rtbReadFile.Text = "ERRO 472: ERRO AO ABRIR O ARQUIVO";
                            break;
                        }

                    }
                    rtbReadFile.Text += current + "\n";
                }
            }
        }
        public string mnemonicos(string codigo)
        {
            if (codigo == "  0")
                return "NOP";
            else if (codigo == " 16")
                return "STA";
            else if (codigo == " 32")
                return "LDA";
            else if (codigo == " 48")
                return "ADD";
            else if (codigo == " 64")
                return "OR";
            else if (codigo == " 80")
                return "AND";
            else if (codigo == " 96")
                return "NOT";
            else if (codigo == "128")
                return "JMP";
            else if (codigo == "144")
                return "JN";
            else if (codigo == "160")
                return "JZ";
            else if (codigo == "240")
                return "HLT";
            else
                return "472";
        }
        public int verificar_linha(string current)
        {
            string linha = current;
            if (linha.Length >= 8)
                linha = linha.Substring(5, 3);
            string mnemonico = mnemonicos(linha);
            if (mnemonico == "472")
            {
                MessageBox.Show("Arquivo Inválido\n\nEsse formato de arquivo não é aceito.\nFavor gerar um Arquivo do Neander.\n\nCaminho para Salvar:\nArquivo > Salvar Texto...", "Erro 472 : Erro ao Abrir Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                rtbCodigodaLinha.Text += "Código: " + int.Parse(linha) + " - Mnemônicos: " + mnemonico + "\n";
                return 1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rtbReadFile.ReadOnly == true)
            {
                rtbReadFile.ReadOnly = false;
                btnEditarInstrucoes.Text = "Bloquear Edição";
                btnExecutar.Enabled = false;
            }
            else
            {
                if (1 == 1)
                {

                    int key = 1;
                    rtbCodigodaLinha.Text = "";
                    foreach (string current in rtbReadFile.Lines)
                    {
                        if (current == "")
                            key = 0;

                        if (key == 1)
                        {
                            int result = verificar_linha(current);
                            if (result == 0)
                            {
                                rtbCodigodaLinha.Text = "ERRO 472: ERRO COM O ARQUIVO";
                                rtbReadFile.Text = "ERRO 472: ERRO COM O ARQUIVO";
                                return ;
                            }

                        }
                    }


                    rtbReadFile.ReadOnly = true;
                    btnEditarInstrucoes.Text = "Editar Instruções";
                    btnExecutar.Enabled = true;
                }
            }

        }
        private void menuArquivoNovo_Click(object sender, EventArgs e)
        {
            if (this.Size.Height > 400)
            {
                this.Size = new Size(this.Size.Width, 316);
                this.Location = new Point(this.Location.X, this.Location.Y + 206);
            }
            rtbReadFile.Text = "";
            rtbCodigodaLinha.Text = "";
            btnExecutar.Enabled = true;
            btnEditarInstrucoes.Enabled = true;
            btnEditarInstrucoes.Text = "Editar Instruções";
            menuArquivoNovo.Enabled = true;
            menuArquivoCarregar.Enabled = true;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
        public int estouro(int valor_ac)
        {
            if (valor_ac >= 256)
            {
                return valor_ac - 256;
            }
            return valor_ac;

        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (rtbReadFile.Text != "")
            {
                if (this.Size.Height < 400) { 
                    this.Size = new Size(this.Size.Width, this.Size.Height + 412);
                    this.Location = new Point(this.Location.X, this.Location.Y - 206);
                }
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                textBox1.Text = "0";
                textBox2.Text = "0";

                int key = 1;
                int desvio = 0;
                int posicao_desvio = 0;
                int processamento = 0;
                int multiplexador = 0;
                int i = 0;

                while (rtbReadFile.Text != null)
                {
                    string current;
                    if (desvio == 1)
                    {
                        current = rtbReadFile.Lines[i - 1];
                    }

                    else
                    {
                        current = rtbReadFile.Lines[i];
                        i++;
                    }
                    if (current == "")
                        key = 0;

                    if (key == 1)
                    {
                        if (desvio == 0)
                        {
                            string result = tipo_mnemonico(current);
                            richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> PC = " + processamento + ".\n";
                            richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Acessou o endereço de memória na posição " + processamento + ".\n";
                            if (result == "NOP")
                            {
                                richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Sem Operação.\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Registrador de Instrução = NOP.\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Sem Operação.\n\n";
                                processamento++;
                                textBox2.Text = processamento.ToString();
                            }
                            else if (result == "HLT")
                            {
                                richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Interrompe Processamento.";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Registrador de Instrução = HLT.\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Processo Interrompido.";
                                processamento++;
                                textBox2.Text = processamento.ToString();
                                break;
                            }
                            else if (result == "LDA")
                            {
                                int posicao = carregando_endposicao(current);
                                richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Carregou o valor do endereço de memória na posição " + posicao + " no Acumulador.\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Registrador de Instrução = LDA " + posicao + ".\n";
                                multiplexador = 1;
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Decodificador -> Multiplexador = " + multiplexador + ".\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Acessa a memória RAM na posição " + posicao + ".\n";
                                int valor = carregando_valordoend(posicao);
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Decodificador -> ULA\n" +
                                    "                                              Operandos:\n" +
                                    "                                                     A - VAZIO\n                                                     B - " + valor + "\n" +
                                    "                                              Entrada da Unidade de Controle:\n" +
                                    "                                                     :=\n";

                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Carrega a saída da ULA no Acumulador (Valor: " + valor + ").\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Incrementa o valor do PC para a próxima instrução.\n\n";

                                textBox1.Text = valor.ToString();
                                processamento += 2;
                                textBox2.Text = processamento.ToString();
                            }
                            else if (result == "ADD")
                            {
                                int posicao = carregando_endposicao(current);
                                richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Adicionou o valor do endereço de memória na posição " + posicao + " no Acumulador.\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Registrador de Instrução = ADD " + posicao + ".\n";
                                multiplexador = 1;
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Decodificador -> Multiplexador = " + multiplexador + ".\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Acessa a memória RAM na posição " + posicao + ".\n";
                                int valor = carregando_valordoend(posicao);
                                int valor_ac = int.Parse(textBox1.Text);
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Decodificador -> ULA\n" +
                                    "                                              Operandos:\n" +
                                    "                                                     A - " + valor_ac + "\n                                                     B - " + valor + "\n" +
                                    "                                              Entrada da Unidade de Controle:\n" +
                                    "                                                     +\n";

                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Carrega a saída da ULA no Acumulador (Valor: " + valor + ").\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Incrementa o valor do PC para a próxima instrução.\n\n";


                                valor = valor + valor_ac;
                                textBox1.Text = estouro(valor).ToString();
                                processamento += 2;
                                textBox2.Text = processamento.ToString();
                            }
                            else if (result == "NOT")
                            {
                                richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Comando NOT executado.\n";
                                int valor_ac = int.Parse(textBox1.Text);
                                int valor = 0;
                                valor = 255 - valor_ac;
                                textBox1.Text = estouro(valor).ToString();
                                processamento += 1;
                                textBox2.Text = processamento.ToString();
                            }
                            else if (result == "STA")
                            {
                                int posicao = carregando_endposicao(current);
                                richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Carregou o valor do Acumulador no endereço de memória na posição " + posicao + ".\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Registrador de Instrução = STA " + posicao + ".\n";
                                multiplexador = 0;
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Decodificador -> Multiplexador = " + multiplexador + ".\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Acessa a memória RAM na posição " + posicao + ".\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Carrega o valor do Acumulador no endereço de memória na posição acessada anteriormente (Posição: " + posicao + ").\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Incrementa o valor do PC para a próxima instrução.\n\n";
                                int valor_ac = int.Parse(textBox1.Text);
                                alterando_dados(posicao, valor_ac);
                                processamento += 2;
                                textBox2.Text = processamento.ToString();
                            }
                            else if (result == "JN")
                            {
                                int valor_ac = int.Parse(textBox1.Text);
                                posicao_desvio = carregando_endposicao(current);
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Registrador de Instrução = JN " + posicao_desvio + ".\n";
                                if (valor_ac > 127)
                                {
                                    richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Houve desvio condicional - jump on negative para a posição " + posicao_desvio + ", pois o valor do acumulador é negativo.\n";
                                    desvio = 1;
                                    processamento = posicao_desvio;
                                }
                                else
                                {
                                    processamento += 2;
                                    richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Não houve desvio condicional - jump on negative, pois o valor do acumulador não é negativo.\n";
                                }
                                textBox2.Text = processamento.ToString();
                            }
                            else if (result == "JZ")
                            {
                                int valor_ac = int.Parse(textBox1.Text);
                                posicao_desvio = carregando_endposicao(current);
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Registrador de Instrução = JN " + posicao_desvio + ".\n";
                                multiplexador = 0;
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Decodificador -> Multiplexador = " + multiplexador + ".\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Acessa a memória RAM na posição " + posicao_desvio + ".\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Decodificador -> ULA\n" +
                                    "                                              Operandos:\n" +
                                    "                                                     A - " + valor_ac + "\n                                                     B - 0\n" +
                                    "                                              Entrada da Unidade de Controle:\n" +
                                    "                                                     =\n";

                                if (valor_ac == 0)
                                {
                                    richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Houve desvio condicional - jump on zero para a posição " + posicao_desvio + ", pois o valor do acumulador é zero.\n";
                                    richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Desvio Condicional (Posição: " + posicao_desvio + ").\n";
                                    richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Incrementa o valor do PC para a próxima instrução.\n\n";
                                    desvio = 1;
                                    processamento = posicao_desvio;
                                }
                                else
                                {
                                    processamento += 2;
                                    richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Não houve desvio condicional - jump on zero, pois o valor do acumulador não é zero.\n";
                                    richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Sem Desvio Condicional.\n";
                                    richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Incrementa o valor do PC para a próxima instrução.\n\n";
                                }
                                textBox2.Text = processamento.ToString();
                            }
                            else if (result == "JMP")
                            {
                                posicao_desvio = carregando_endposicao(current);
                                richTextBox1.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Houve desvio incondicional - jump para a posição " + posicao_desvio + ".\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Registrador de Instrução = JMP " + posicao_desvio + ".\n";
                                multiplexador = 1;
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> Decodificador -> Multiplexador = " + multiplexador + ".\n";
                                richTextBox2.Text += "<" + DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() + "> O valor do PC foi alterado para a posição do desvio (Posição: " + posicao_desvio + ").\n\n";

                                desvio = 1;
                                processamento = posicao_desvio;
                                textBox2.Text = processamento.ToString();
                            }

                        }
                        else
                        {
                            if ((i = valor_ini(posicao_desvio)) != 257)
                            {
                                desvio = 0;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo não foi carregado!\n\nNão foi possível processar a sua solicitação!", "ERRO: ARQUIVO NÃO CARREGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int valor_ini(int posicao_negativo)
        {
            int key = 1;
            int cont_linha = 0;
            string linha;
            foreach (string current in rtbReadFile.Lines)
            {
                if (current == "")
                    key = 0;

                if (key == 1)
                {
                    linha = current.Substring(0, 3);

                    if (int.Parse(linha) == posicao_negativo)
                    {
                        return cont_linha;
                    }
                }
                cont_linha++;
            }
            return 257;
        }
        public string tipo_mnemonico(string current)
        {
            string linha = current;
            linha = linha.Substring(5, 3);
            return mnemonicos(linha);
        }
        public int carregando_endposicao(string current)
        {
            string linha = current;
            linha = linha.Substring(linha.Length - 3, 3);
            string PegaSegundoCaracter = linha[1].ToString();
            if (PegaSegundoCaracter == " ")
            {
                linha = current.Substring(current.Length - 2, 2);
            }

            return int.Parse(linha);
        }
        public int carregando_valordoend(int posicao)
        {
            int key = 1;
            string linha = "";
            foreach (string current in rtbReadFile.Lines)
            {
                linha = current;
                if (current == "")
                    key = 0;

                else if (key == 0)
                {

                    linha = linha.Substring(0, 3);
                    int valor = int.Parse(linha);
                    if (valor == posicao)
                    {
                        linha = current.Substring(current.Length - 9, 3);
                        break;
                    }
                }
            }
            return int.Parse(linha);
        }
        public void alterando_dados(int posicao, int valor_ac)
        {
            int key = 1;
            int line = 0;
            string[] lines = rtbReadFile.Lines;
            string linha = "";
            foreach (string current in rtbReadFile.Lines)
            {
                linha = current;
                if (current == "")
                    key = 0;

                else if (key == 0)
                {

                    linha = linha.Substring(0, 3);
                    int valor = int.Parse(linha);

                    if (valor == posicao)
                    {
                        if (valor_ac >= 0 && valor_ac < 10)
                        {

                            lines[line] = posicao + "    " + valor_ac + "      ";
                            rtbReadFile.Lines = lines;
                        }
                        else if (valor_ac >= 10 && valor_ac < 100)
                        {
                            lines[line] = posicao + "   " + valor_ac + "      ";
                            rtbReadFile.Lines = lines;
                        }
                        else if (valor_ac >= 100)
                        {
                            lines[line] = posicao + "  " + valor_ac + "      ";
                            rtbReadFile.Lines = lines;
                        }
                        break;
                    }
                }
                line++;
            }
        }
        private void menuArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (rtbReadFile.Text == "")
            {
                MessageBox.Show("Não foi possível prosseguir com o salvamento do arquivo, pois o campo Leitura do Arquivo está vazia.\n\nFavor, corrigir este erro e tente novamente.", "ERRO: Tentativa de Salvamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                saveFileDialog1.FileName = "Simulador_" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
                DialogResult resultado = saveFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    rtbReadFile.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    //exibe mensagem informando que a operação foi cancelada
                    MessageBox.Show("Operação cancelada", "Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void menuExecutar_Click(object sender, EventArgs e)
        {
            if (btnExecutar.Enabled == true)
                btnExecutar_Click(this, new EventArgs());
        }
        private void menuDownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pStart = new System.Diagnostics.Process();
            pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"ftp://ftp.inf.ufrgs.br/pub/inf107/WNeander.exe");
            pStart.Start();
        }

        private void menuArquivoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

