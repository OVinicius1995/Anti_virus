using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Anti_virus
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\ViniciusAbreudeOlive\Desktop\Projetos C#\Projeto ant-virus\Anti_virus\TROCAR.cmd");           
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
          System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

          System.Diagnostics.Process.Start(@"C:\Users\ViniciusAbreudeOlive\Desktop\Projetos C#\Projeto ant-virus\Anti_virus\VarrF.cmd");

          myProcess.Close ();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"cmd.exe");
        }

        private void btnVarrerpc_Click(object sender, EventArgs e)
        {
           
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

            System.Diagnostics.Process.Start(@"C:\Users\ViniciusAbreudeOlive\Desktop\Projetos C#\Projeto ant-virus\Anti_virus\VARRER_PC.cmd");

          myProcess.Close ();           
            
            
        }

        private void btnG_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

           System.Diagnostics.Process.Start(@"C:\Users\ViniciusAbreudeOlive\Desktop\Projetos C#\Projeto ant-virus\Anti_virus\VarrG.cmd");

          myProcess.Close ();
            
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

            System.Diagnostics.Process.Start(@"C:\Users\ViniciusAbreudeOlive\Desktop\Projetos C#\Projeto ant-virus\Anti_virus\VarrE.cmd");

            myProcess.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

            System.Diagnostics.Process.Start(@"C:\Users\ViniciusAbreudeOlive\Desktop\Projetos C#\Projeto ant-virus\Anti_virus\VarrH.cmd");

            myProcess.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblnow.Text = (DateTime.Now.ToString());
        }

        private void btnVarrD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

            System.Diagnostics.Process.Start(@"C:\Users\ViniciusAbreudeOlive\Desktop\Projetos C#\Projeto ant-virus\Anti_virus\VarrD.bat");

            myProcess.Close();
            

        }

        private void Form1_Load(object sender, FormClosingEventArgs e)
        {


        }

        private void btnTeste_Click(object sender, EventArgs e)
        {

            foreach (var d in DriveInfo.GetDrives())
            {
                if (d.IsReady & d.DriveType == DriveType.Removable)
                {
                    MessageBox.Show($"{d.Name}");

                    string pendrive = d.Name;

                    switch(pendrive)
                    {
                        case "A:\\":
                        
                        MessageBox.Show("Unidade A:\\");
                        break;
                        
                        case "B:\\":
                        
                        MessageBox.Show("Unidade B:\\");
                        break;
                        
                        case "C:\\":
                        
                        MessageBox.Show("Unidade C:\\");
                        break;
                        
                        case "D:\\":
                        
                        MessageBox.Show("Unidade D:\\");
                        break;
                        
                        case "E:\\":
                        
                        MessageBox.Show("Unidade E:\\");
                        break;
                        
                        case "F:\\":
                        
                        MessageBox.Show("Unidade F:\\");
                        break;
                        
                        case "G:\\":
                        
                        MessageBox.Show("Unidade G:\\");
                        break;
                        
                        case "H:\\":
                        
                        MessageBox.Show("Unidade H:\\");
                        break;
                        
                        case "I:\\":
                        
                        MessageBox.Show("Unidade I:\\");
                        break;
                        
                        case "J:\\":
                        
                        MessageBox.Show("Unidade J:\\");
                        break;
                        
                        case "K:\\":
                        
                        MessageBox.Show("Unidade K:\\");
                        break;

                        case "L:\\":

                        MessageBox.Show("Unidade L:\\");
                        break;

                        case "M:\\":
                        
                        MessageBox.Show("Unidade M:\\");
                        break;
                        
                        case "N:\\":
                        
                        MessageBox.Show("Unidade N:\\");
                        break;
                        
                        case "O:\\":
                        
                        MessageBox.Show("Unidade O:\\");
                        break;
                        
                        case "P:\\":
                        
                        MessageBox.Show("Unidade P:\\");
                        break;
                        
                        case "Q:\\":
                        
                        MessageBox.Show("Unidade Q:\\");
                        break;
                        
                        case "R:\\":
                        
                        MessageBox.Show("Unidade R:\\");
                        break;
                        
                        case "S:\\":
                        
                        MessageBox.Show("Unidade S:\\");
                        break;
                        
                        case "T:\\":
                        
                        MessageBox.Show("Unidade T:\\");
                        break;
                        
                        case "U:\\":
                        
                        MessageBox.Show("Unidade U:\\");
                        break;
                        
                        case "V:\\":
                        
                        MessageBox.Show("Unidade V:\\");
                        break;
                        
                        case "X:\\":
                        
                        MessageBox.Show("Unidade X:\\");
                        break;
                        
                        case "Y:\\":
                        
                        MessageBox.Show("Unidade Y:\\");
                        break;
                        
                        case "Z:\\":
                     
                        MessageBox.Show("Unidade Z:\\");
                        break;
                    }

                    break;
                }
                else if (!d.IsReady & d.DriveType != DriveType.Removable)
                {
                    MessageBox.Show("Não foram encontradas unidades removiveis verifique!");
                    break;
                }

                
            }
             
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == System.Windows.Forms.CloseReason.UserClosing)
            {
                MessageBox.Show("Poxaaaa não foi dessa vez que você conseguiu, mas tente sair pelo o botão sair *-*!");
                MessageBox.Show("Não foi atoa que eu desenvolvi o botão sair. Muito obrigado!");
                btncancelar.Focus();
                e.Cancel = true;
            }
        }
    }
}
