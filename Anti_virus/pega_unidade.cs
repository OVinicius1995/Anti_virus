using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anti_virus
{
    class pega_unidade
    {
    public void limpaVirus(string unidade)
    {
        try
        {
                
                unidade = System.Text.RegularExpressions.Regex.Replace(unidade, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ]+?", string.Empty);

                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();

                System.Diagnostics.Process.Start($@"C:\cleaner_engine\{unidade}.cmd");

                myProcess.Close();

                

            }

        catch (Exception ex)
        {
            throw new Exception("Erro ao realizar a limpeza do virus: " + ex.Message); 
        }
        finally
        {
            Console.ReadLine();
        }
    }

     public void pegaUni(string p)
        {
            var pendrive = p;
        }
}

}
