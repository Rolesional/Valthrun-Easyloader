using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {

        [STAThread]

     
        static void Main()
        {
            Console.Title = "Valthrun easy loader";
            Console.WriteLine("");
            Console.WriteLine(" Welcome To easy loader!"); 
            Console.WriteLine(" this loader by rolesional btw");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            string dir = @"C:\EasyLoader";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            Console.WriteLine(" Downloading Files btw");
           
            using (WebClient roles = new WebClient())
            {
                roles.DownloadFileAsync(
                    new System.Uri("https://github.com/Valthrun/Valthrun/releases/download/v0.3.2/controller.exe"),
                    "C:\\EasyLoader\\controller.exe"
                );

                using (WebClient kdm = new WebClient())
                {
                    kdm.DownloadFileAsync(
                        new System.Uri("https://github.com/Rolesional/RolesWareCS2/raw/main/SoftWare%20Files/kdmapper.exe"),
                        "C:\\EasyLoader\\kdmapper.exe"
                    );
                    using (WebClient dr1 = new WebClient())
                    {
                        dr1.DownloadFileAsync(
                            new System.Uri("https://github.com/Valthrun/Valthrun/releases/download/v0.3.2/valthrun-driver.sys"),
                            "C:\\EasyLoader\\valthrun-driver.sys"
                        );

                                Thread.Sleep(4000);
    
                                    Console.WriteLine(" Driver is loading bro");
                                    var proc1 = new ProcessStartInfo();
                                    proc1.UseShellExecute = true;

                                    proc1.WorkingDirectory = @"C:\EasyLoader";

                                    proc1.FileName = @"C:\EasyLoader\kdmapper.exe";
                                    proc1.Verb = "runas";
                                    proc1.Arguments = "valthrun-driver.sys";
                                    Process.Start(proc1);
                                    Thread.Sleep(6000);
                                    Console.WriteLine(" success my friend");
                                    Console.WriteLine(" Valthrun (game chair) is loading...");
                                    Thread.Sleep(2000);
                                    var proc2 = new ProcessStartInfo();
                                    proc2.UseShellExecute = true;

                                    proc2.WorkingDirectory = @"C:\EasyLoader";

                                    proc2.FileName = @"C:\EasyLoader\controller.exe";
                                    proc2.Verb = "runas";
                                    proc2.Arguments = "";
                                    Process.Start(proc2);
                                    Console.WriteLine(" Game Chair Loaded! (Loader Closing)");
                                    Thread.Sleep(6000);


                                }
                                
                            }
                        }
                    }
                }
            }
        
