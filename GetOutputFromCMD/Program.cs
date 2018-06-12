using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace GetOutputFromCMD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Directory.GetCurrentDirectory() + "\\GoogleDriveHelper.Helper.exe");
            //创建执行CMD
            Process cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = Directory.GetCurrentDirectory()+"\\GoogleDriveHelper.Helper.exe";
            //
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.RedirectStandardInput = true;
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.RedirectStandardError = true;

            cmdProcess.Start();

            string strCMD = cmdProcess.StandardOutput.ReadToEnd();
            //cmdProcess.WaitForExit();
            cmdProcess.Close();

            Console.WriteLine("____"+strCMD);

            Console.ReadKey();


            //string strInputFolder = @"C:\Users\vlei002\Desktop\GetOutputFromCMD";
            //string strGoogleDriveInputFolder = "1rSljBkgF7qt-oT08NitcrzbjcAei1aLn";
            //string strGoogleDriveApiCredentialFile = @"C:\Users\vlei002\Desktop\vivi\Study\CODE\GoogleDriveHelper\GetOutputFromCMD\client_secret.json";

            //cmdProcess.StartInfo.Arguments = "inInputFolder=" + "\"" + strInputFolder + "\"" + " inGoogleDriveInputFolder=" + "\"" + strGoogleDriveInputFolder + "\"" + " inGoogleDriveApiCredentialFile=" + "\"" + strGoogleDriveApiCredentialFile + "\"";


        }
    }
}
