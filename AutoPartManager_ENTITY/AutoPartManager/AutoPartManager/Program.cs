using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using System.Threading;
using NLog;

namespace AutoPartManager
{
    static class Program
    {
        private static Logger _logger;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]

        static void Main()
        {
            _logger = LogManager.GetCurrentClassLogger();
            //Application.ThreadException += OnThreadException;
           // AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new FormAutoPartManager());
            }
            catch (Exception exc)
            {
                LogFatalException(exc);
                throw;
            }
        }

        private static void LogFatalException(Exception exc)
        {
            string message = String.Format(
                "(Application version {0}) {1}", Application.ProductVersion, exc.Message);

            _logger.Fatal(message, exc);
        }

        private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.IsTerminating)
            {
                _logger.Info("Application is terminating due to an unhandled exception in a secondary thread.");
            }
            LogFatalException(e.ExceptionObject as Exception);
        }

        private static void OnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            LogFatalException(e.Exception);
        }
    }
}

