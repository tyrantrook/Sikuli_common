using System;
using System.Threading;

namespace Sikuli_common
{

    class Program
    {

        static AutoItX3Lib.AutoItX3 au3;                                        //our au3 class that gives us au3 functionality
        static Thread thread;                                                   //our thread
        static bool threadshouldexecute = true;                                 //only execute thread 2 while this equals true
        static int i = 0;                                                       //our incrementer

        /// <summary>
        /// The entry point, or main thread / main loop, of our program
        /// </summary>
        
        static void Main(string[] args)
        {
            au3 = new AutoItX3Lib.AutoItX3();                                   //initialize our au3 class library

            au3.AutoItSetOption("WinTitleMatchMode", 4);                        //advanced window matching

            thread = new Thread(new ThreadStart(threadtest));                   //initialize and start our thread
            thread.Start();

            if (au3.WinExists("Untitled - Notepad", "") == 0)                   //if an Untitled - Notepad document doesn't exist
                au3.Run(@"C:\WINDOWS\SYSTEM32\notepad.exe", "", au3.SW_SHOW);   //run notepad
            else
                au3.WinActivate("Untitled - Notepad", "");                      //otherwise activate the window

            string hWnd = "";                                                   //let's use a window handle

            while (hWnd.Length == 0)                                            //try to get a handle to notepad until it succeeds
                hWnd = au3.WinGetHandle("Untitled - Notepad", "");

            while (au3.WinActive("handle=" + hWnd, "") == 0)                    //loop while it's not active
            {
                au3.WinActivate("handle=" + hWnd, "");                          //and activate it
                Thread.Sleep(100);
            }

            while (au3.WinExists("handle=" + hWnd, "") != 0)                    //while the window exists, loop
            {
                //send our incrementing variable, i, to notepad, with a trailing |
                au3.ControlSend("handle=" + hWnd, "", "Edit1", i.ToString() + "|", 0);

                i++;                                                            //increment i

                Thread.Sleep(100);                                              //short sleep so we don't burn CPU
            }

            //if the while loop exited--because there's no Untitled - Notepad--make the other thread stop executing
            threadshouldexecute = false;

            Console.Write("Press [ENTER] to continue...");                      //tell the user to press ENTER to quit
            Console.ReadLine();                                                 //pause until enter is pressed
        }

        /// <summary>
        /// our void function to execute thread #2
        /// </summary>
        static void threadtest()
        {
            while (threadshouldexecute)                                         //loop while this thread should execute
            {
                au3.ToolTip("Thread 2\ni: " + i.ToString(), 0, 0);              //display a tooltip with the incrementing variable i in it

                Thread.Sleep(50);                                               //sleep to free up CPU
            }

            au3.ToolTip("", 0, 0);                                              //clear the tooltip after loop is done
        }
    }
}