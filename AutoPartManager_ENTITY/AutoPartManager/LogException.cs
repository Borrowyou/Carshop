using System;

namespace LogExceptions
{
    public static class LogExcept
    {
	    public static void LogException(Exception E)
	    {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\log" + "Exception " + DateTime.Now.ToString("hh.mm.ss.ffffff");

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace +
                    Environment.NewLine + "StackTrace :" + ex.InnerException +
                   "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
            }

	    }
    }
}