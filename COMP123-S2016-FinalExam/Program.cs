﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 *Name : Abhinav Sharda
 *student No: 300868625
 *Datemodified: 19Aug2016
 *
 */
namespace COMP123_S2016_FinalExam
{
    public static class Program
    {
        public static SplashForm Splash;
        public static GenerateNameForm FirstForm;
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FirstForm = new GenerateNameForm();
            Splash = new SplashForm();
            Application.Run(Splash);
        }
    }
}
