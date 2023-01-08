using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace suliapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lessonTypes = new string[13] { "info", "kemia", "fizika", "angol", "irodalom", "olasz", "matek", "tori", "nyelvtan", "foci", "biosz", "enek", "tesi" };
            string[,] uris = new string[13, 2] { { "info", "https://meet.google.com/lookup/a4mkor2x4b?authuser=1&hs=179" },
                                                 { "kemia", "https://meet.google.com/lookup/ddzsrlttxu?authuser=1&hs=179" },
                                                 { "fizika", "https://meet.google.com/lookup/baytcxdfxp?authuser=1&hs=179" },
                                                 { "angol", "https://meet.google.com/lookup/cbqp5tuk2k?authuser=1&hs=179" },
                                                 { "irodalom", "https://meet.google.com/txm-snjr-adh?authuser=1" },
                                                 { "olasz", "https://meet.google.com/lookup/cbwjhmypgr?authuser=1&hs=179" },
                                                 { "matek", "https://classroom.google.com/u/1/c/MTU4MDY3NDY2NjRa" },
                                                 { "tori", "https://meet.google.com/lookup/dw4435flyy" },
                                                 { "nyelvtan", "https://meet.google.com/lookup/atcypzzkjo?authuser=1&hs=179" },
                                                 { "foci", "https://meet.google.com/lookup/d36zobz7cx?authuser=1&hs=179" },
                                                 { "biosz", "https://meet.google.com/lookup/hjctmhiiv5" },
                                                 { "enek", "https://meet.google.com/umr-tqbi-swh?authuser=1" },
                                                 { "tesi", "https://meet.google.com/lookup/de5dkhpfpk?authuser=1&hs=179" } };
            string[][] lessons = new string[][] {  new string[3] { "1", "8:00 AM", "info" },
                                                   new string[3] { "1", "9:00 AM", "tesi" },
                                                   new string[3] { "1", "10:00 AM", "kemia" },
                                                   new string[3] { "1", "11:00 AM", "fizika" },
                                                   new string[3] { "1", "12:00 PM", "matek"}, //12b kaotikus mozgas
                                                   new string[3] { "2", "8:00 AM", "irodalom" },
                                                   new string[3] { "2", "9:00 AM", "angol" },
                                                   new string[3] { "2", "10:00 AM", "olasz" }, 
                                                   new string[3] { "2", "12:00 PM", "matek" },
                                                   new string[3] { "3", "9:00 AM", "irodalom"},
                                                   new string[3] { "3", "10:00 AM", "matek" },
                                                   new string[3] { "3", "11:00 AM", "foci" },
                                                   new string[3] { "3", "12:00 PM", "biosz" },
                                                   new string[3] { "3", "2:00 PM", "enek" },
                                                   new string[3] { "4", "9:00 AM", "olasz" },
                                                   new string[3] { "4", "10:00 AM", "fizika" },
                                                   new string[3] { "4", "11:00 AM", "matek" }, 
                                                   new string[3] { "4", "12:00 PM", "angol" },
                                                   new string[3] { "4", "1:00 PM", "tori" },
                                                   new string[3] { "5", "9:00 AM", "olasz" },
                                                   new string[3] { "5", "10:00 AM", "kemia" },
                                                   new string[3] { "5", "11:00 AM", "fizika" } };

            while (true)
            {
                int wk = (int)DateTime.Today.DayOfWeek;
                var now = DateTime.Now;  //MM:DD:YY hh:mm:ss APM
                                         //Console.WriteLine(now.ToString("t"));
                //Console.WriteLine(now.ToString("t") + " " + wk);
                foreach (string[] lesson in lessons)
                {
                    if (wk == int.Parse(lesson[0]) && now.ToString("t") == lesson[1])
                    {
                        var uri = uris[Array.IndexOf(lessonTypes, lesson[2]), 1];
                        Console.WriteLine(uri);
                        var psi = new ProcessStartInfo();
                        psi.UseShellExecute = true;
                        psi.FileName = uri;
                        Process.Start(psi);
                        break;
                    }
                }
                Console.WriteLine("retrying...");
                System.Threading.Thread.Sleep(60000);
            }
        }
    }
}
