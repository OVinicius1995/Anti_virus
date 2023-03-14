using System;
using System.IO;
using System.Windows.Forms;


namespace Anti_virus
{


    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblnow.Text = (DateTime.Now.ToString());
            pega_unidade pegunid = new pega_unidade();

            foreach (var d in DriveInfo.GetDrives())
            {

                if (d.DriveType == DriveType.NoRootDirectory)
                {

                    MessageBox.Show("Opss... É um diretório root.");

                }
                else { txtUnidade.Text = d.Name; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pega_unidade pegunid = new pega_unidade();
            cmbUnidade.Enabled = false;
            btnLimparCmb.Enabled = false;

            foreach (var d in DriveInfo.GetDrives())
            {

               if (d.DriveType == DriveType.NoRootDirectory)
                {

                    MessageBox.Show("Opss... É um diretório root.");

                } else {
                    
                    txtUnidade.Text = d.Name;
                }
            }

        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var escolha = MessageBox.Show("A unidade pré-carregada está correta? ", "Unidade", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            pega_unidade unid = new pega_unidade();

            if (escolha == System.Windows.Forms.DialogResult.Yes)
            {

                foreach (var f in DriveInfo.GetDrives())
                {

                    if (f.DriveType == DriveType.NoRootDirectory)
                    {

                        MessageBox.Show("Opss... É um diretório root.");
                        break;
                    }
                    else if (f.DriveType == DriveType.Removable && f.IsReady && f.DriveType != DriveType.Network) {

                        var pendrive = f.Name;

                        switch (pendrive)
                        {
                            case "A:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "B:\\":
                                unid.limpaVirus(pendrive);
                                break;

                            case "C:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "D:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "E:\\":
                                
                                unid.limpaVirus(pendrive);
                                break;

                            case "F:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "G:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "H:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "I:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "J:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "K:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "L:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "M:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "N:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "O:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "P:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "Q:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "R:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "S:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "T:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "U:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "V:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "X:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "Y:\\":

                                unid.limpaVirus(pendrive);
                                break;

                            case "Z:\\":

                                unid.limpaVirus(pendrive);
                                break;
                        }
                    }
                }
            } else if (escolha == System.Windows.Forms.DialogResult.No) {


                MessageBox.Show("Peço por gentileza que verifique se na lista abaixo está sendo apresentado a unidada da qual será feita a limpeza.","",MessageBoxButtons.OK,MessageBoxIcon.Information);

                cmbUnidade.Enabled = true;
                btnLimparCmb.Enabled = true;
                btnLimpar.Enabled = false;

                cmbUnidade.Text = "Escolha a Unidade";

                foreach (var g in DriveInfo.GetDrives() ) { 
                    if (g.IsReady || txtUnidade.Text == "Unidade" || g.DriveType != DriveType.Network) { 

                       string[] unidades = new string[1] { $"{g.Name}" };
                        this.cmbUnidade.Items.Add(unidades[0]);
                    }
                }
            }
        }

    private void btnLimparCmb_Click(object sender, EventArgs e)
        {

            pega_unidade unid = new pega_unidade(); 

            if (cmbUnidade.Text == "Escolha a Unidade" || cmbUnidade.Text == "") {

                MessageBox.Show("É preciso selecionar uma unidade.", "Unidade incorreta ou em branco!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            } else { 

            var unidadeSelecionada = cmbUnidade.Text;

            switch (unidadeSelecionada)
            {
                case "A:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "B:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "C:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "D:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "E:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "F:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "G:\\":
                                           
                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "H:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "I:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "J:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "K:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "L:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "M:\\":
                        
                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "N:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "O:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "P:\\":
                  
                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "Q:\\":
                        
                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "R:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "S:\\":

                   unid.limpaVirus(unidadeSelecionada);
                   cmbUnidade.Text = "Escolha a Unidade";
                   break;

                case "T:\\":

                   cmbUnidade.Text = "Escolha a Unidade";
                   unid.limpaVirus(unidadeSelecionada);
                   break;

                case "U:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "V:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "X:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "Y:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;

                case "Z:\\":

                    unid.limpaVirus(unidadeSelecionada);
                    cmbUnidade.Text = "Escolha a Unidade";
                    break;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                MessageBox.Show("Poxaaaa não foi dessa vez que você conseguiu, mas tente sair pelo o botão sair *-*!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Não foi atoa que eu desenvolvi o botão sair. Muito obrigado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSair.Focus();
                e.Cancel = true;
            }
        }
    }
}

