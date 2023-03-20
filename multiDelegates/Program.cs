﻿using System;

namespace assignment8ex1
{
    class Program
    {
        //declaring the delegate 
        delegate void HereComesTheSunDelegate();
        public class HereComesTheSun
        {
            public static void chorus()
            {
                Console.Write("Here comes the sun, doo-doo-doo-doo\r\n");
                Console.WriteLine("Here comes the sun, and I say\r\nIt's alright");
                Console.WriteLine();
            }
            public static void chorus2()
            {
                Console.WriteLine("Here comes the sun\r\nHere comes the sun, and I say\r\nIt's alright");
                Console.WriteLine();
                Console.Write("Sun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\n");
                Console.Write("Sun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\n");
                Console.WriteLine("Sun, sun, sun, here it comes");
                Console.WriteLine();
            }
            public static void verse1()
            {
                Console.Write("Little darlin', it's been a long, cold, lonely winter\r\n");
                Console.WriteLine("Little darlin', it feels like years since it's been here");
                Console.WriteLine();
            }
            public static void verse2()
            {
                Console.Write("Little darlin', the smile's returning to their faces\r\n");
                Console.WriteLine("Little darlin', it seems like years since it's been here");
                Console.WriteLine();
            }
            public static void verse3()
            {
                Console.Write("Little darlin', I feel that ice is slowly melting\r\n");
                Console.WriteLine("Little darlin', it seems like years since it's been clear");
                Console.WriteLine();
            }
            public static void end()
            {
                Console.WriteLine("It's alright");
            }
        }

        static void Main(string[] args)
        {
            // instantiating the delegate and including the methods in the correct order
            HereComesTheSunDelegate ch1 = new HereComesTheSunDelegate(HereComesTheSun.chorus); 
            HereComesTheSunDelegate v1 = new HereComesTheSunDelegate(HereComesTheSun.verse1);
            HereComesTheSunDelegate ch2 = new HereComesTheSunDelegate(HereComesTheSun.chorus);
            HereComesTheSunDelegate v2 = new HereComesTheSunDelegate(HereComesTheSun.verse2);
            HereComesTheSunDelegate ch3 = new HereComesTheSunDelegate(HereComesTheSun.chorus2);
            HereComesTheSunDelegate v3 = new HereComesTheSunDelegate(HereComesTheSun.verse3);
            HereComesTheSunDelegate end = new HereComesTheSunDelegate(HereComesTheSun.end);




            // invoking delegates
            ch1();
            v1();
            ch2();
            v2();
            ch3();
            v3();
            end();

        }
    }
}