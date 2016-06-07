using System;
using System.IO;

namespace LogExceptions
{
    public static class LogExcept
    {
	    public static void LogException(Exception ex)
	    {
            string DirPath = AppDomain.CurrentDomain.BaseDirectory + "log\\";
            Directory.CreateDirectory(DirPath);
            string filePath = DirPath + "AppException " + DateTime.Now.ToString("hh.mm.ss.ffffff") + ".txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace +
                    Environment.NewLine + "INNER EXCEPTION MESSAGE :" + ex.InnerException + 
                   "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
            }

	    }
    }
}