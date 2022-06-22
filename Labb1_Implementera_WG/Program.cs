using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net.Http;
using Labb1_Implementera_WG.Factory;
using Labb1_Implementera_WG.ProductInterface;
using Labb1_Implementera_WG.Product;


/* 
Labb 1, Implemtera
Wilhelm Groth
2022-06-21

De designmönster jag har implementerat är:
1. Factory Method
2. Singleton 
3. Adapter 


 
 */

namespace Labb1_Implementera_WG
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();

        }


        static void RunApp()
        {
            Console.Clear();
            Console.WriteLine("Choose TV: ");
            Console.WriteLine("1: TCL");
            Console.WriteLine("2: Samsung");
            Console.WriteLine("3: Watch Netflix via Playstation 5");
            var input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case (int)ModelType.TCL:
                    var televisionTCL = TelevisionFactory.GetTelevision(ModelType.TCL); // Implementring av Factory Method
                    Console.WriteLine("Use remote or TV system? ");
                    Console.WriteLine("1: Remote");
                    Console.WriteLine("2: TV system");
                
                    var input1 = int.Parse(Console.ReadLine());

                    if (input1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("1- Channel up");
                        Console.WriteLine("2- Channel down");
                        Console.WriteLine("3- Volume down");
                        Console.WriteLine("4- Volume up");
                        Console.WriteLine("5- Start Netflix");
                        var remoteinput = int.Parse(Console.ReadLine());
                        switch (remoteinput)
                        {
                            case 1:
                                Console.Clear();
                               televisionTCL.GetRemoteSingleton().ChannelUp();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 2:
                                Console.Clear();
                                televisionTCL.GetRemoteSingleton().ChannelDown();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 3:
                                Console.Clear();
                                televisionTCL.GetRemoteSingleton().VolumeUp();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 4:
                                Console.Clear();
                                televisionTCL.GetRemoteSingleton().VolumeDown();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 5:
                                Console.Clear();
                                televisionTCL.GetRemoteSingleton().StartNetflix();
                                Console.ReadLine();
                                RunApp();
                                break;
                            default:
                                RunApp();
                                break;

                        }

                    }
                    else if (input1 == 2)
                    {
                        Console.WriteLine("1 - Change Brightness");
                        Console.WriteLine("2 - Change Contrast");
                        Console.WriteLine("3 - Get local TV time");
                        var systemInput = int.Parse(Console.ReadLine());
                        switch (systemInput)
                        {
                            case 1:
                                Console.Clear();
                                televisionTCL.ChangeBrightness();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 2:
                                Console.Clear();
                                televisionTCL.ChangeContrast();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 3:
                                Console.Clear();
                                televisionTCL.GetTime();
                                Console.ReadLine();
                                RunApp();
                                break;

                            default:
                                RunApp();
                                break;

                        }
                    }

                    break;


                case (int)ModelType.Samsung:
                    var televisionSamsung = TelevisionFactory.GetTelevision(ModelType.Samsung); 
                    Console.WriteLine("Use remote or TV system? ");
                    Console.WriteLine("1: Remote");
                    Console.WriteLine("2: TV system");
                    var inputSamsung= int.Parse(Console.ReadLine());
                 
                    if (inputSamsung == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("1- Channel up");
                        Console.WriteLine("2- Channel down");
                        Console.WriteLine("3- Volume down");
                        Console.WriteLine("4- Volume up");
                        Console.WriteLine("5- Start Netflix");
                        var remoteinput = int.Parse(Console.ReadLine());
                        switch (remoteinput)
                        {
                            case 1:
                                Console.Clear();
                                televisionSamsung.GetRemoteSingleton().ChannelUp();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 2:
                                Console.Clear();
                                televisionSamsung.GetRemoteSingleton().ChannelDown();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 3:
                                Console.Clear();
                                televisionSamsung.GetRemoteSingleton().VolumeUp();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 4:
                                Console.Clear();
                                televisionSamsung.GetRemoteSingleton().VolumeDown();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 5:
                                Console.Clear();
                                televisionSamsung.GetRemoteSingleton().StartNetflix();
                                Console.ReadLine();
                                RunApp();
                                break;
                            default:
                                RunApp();
                                break;

                        }

                    }

                    else if (inputSamsung == 2)
                    {

                        Console.WriteLine("1 - Change Brightness");
                        Console.WriteLine("2 - Change Contrast");
                        Console.WriteLine("3 - Get local TV time");
                        var systemInput = int.Parse(Console.ReadLine());
                        switch (systemInput)
                        {
                            case 1:
                                Console.Clear();
                                televisionSamsung.ChangeBrightness();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 2:
                                Console.Clear();
                                televisionSamsung.ChangeContrast();
                                Console.ReadLine();
                                RunApp();
                                break;
                            case 3:
                                Console.Clear();
                                televisionSamsung.GetTime();
                                Console.ReadLine();
                                RunApp();
                                break;
                  
                            default:
                                RunApp();
                                Console.ReadLine();
                                break;

                        }

                    }

                    break;


             
                   
                case 3:
                    IPlaystation targetPlaystastion = new AdapterPlaystationNetflix(new AdapteePlaystationNetflix());
                    targetPlaystastion.WatchNetflix();
                    Console.ReadLine();
                    RunApp();
                    break;
                default:
                    Console.WriteLine("Try again");
                    RunApp();
                    break;
            }

        }

    }


}