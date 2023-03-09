using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
