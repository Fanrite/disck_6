using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Direte;

namespace disck_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string output = "";
            int[] f = new int[4];
            int[] x = { 0, 1, 1, 0 };
            int[] y = { 0, 1, 0, 1 };
            int[] z, t;

            for (int i = 0; i < 4; i++)
                f[i] = Dir.Modul(x[i], (Dir.ConYun(y[i], x[i])));

            for (int i = 0; i < 4; i++)
                output += $"|X={x[i]}|Y={y[i]}|F={f[i]}|\n";
            Console.WriteLine("//----1-----//");
            Console.WriteLine(output);
            //2
            output = "";
            f = new int[8];
            x = new int[8] { 1, 0, 0, 0, 1, 1, 0, 1 };
            y = new int[8] { 0, 1, 0, 0, 1, 1, 1, 0 };
            z = new int[8] { 0, 0, 1, 0, 1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
                f[i] = Dir.Modul(x[i], (Dir.Modul(Dir.ConYun(z[i], y[i]), x[i])));

            for (int i = 0; i < 8; i++)
                output += $"|X={x[i]}|Y={y[i]}|Z={z[i]}|G={f[i]}|\n";

            Console.WriteLine("//------2-------//");
            Console.WriteLine(output);
            //3
            output = "";
            f = new int[14];
            t = new int[14] { 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 1 };
            x = new int[14] { 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1 };
            y = new int[14] { 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1 };
            z = new int[14] { 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0 };

            for (int i = 0; i < 14; i++)
                f[i] = Dir.Modul(Dir.ConYun((Dir.Modul(Dir.ConYun(t[i], x[i]), y[i])), y[i]), z[i]);

            for (int i = 0; i < 14; i++)
                output += $"|X={x[i]}|Y={y[i]}|Z={z[i]}|T={t[i]}|H={f[i]}|\n";

            Console.WriteLine("//--------3---------//");
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
