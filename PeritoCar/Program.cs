﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeritoCar
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //frmLogin frmLogin = new frmLogin();
            //frmLogin.ShowDialog();

            //if (frmLogin.logado)
            //{
                Application.Run(new frmVistoria());
            //}
        }
    }
}
