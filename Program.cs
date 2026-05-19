using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStation_Pablo
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //ID Funcionario
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Criando o login da biblioteca
            FormLogin entrando = new FormLogin();
            entrando.saida = false;
            Application.Run(entrando);
            if (entrando.saida)
            {
                entrando.Dispose();
                entrando.Close();
                Application.Run(new Form1());
            }



        }
    }
}
