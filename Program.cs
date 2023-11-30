using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type stringType = typeof(string);
            //Console.WriteLine("TypeName: \t" + stringType.FullName);
            //Console.WriteLine("Full Name: \t" + stringType.FullName);
            //Console.WriteLine("Assembly: \t" + stringType.Assembly);
            //Console.WriteLine("NameSpace: \t" + stringType.Namespace);
            //Console.WriteLine("Base: \t" + stringType.BaseType);
            //Console.WriteLine(" *** Methods in String class ***");

            //MethodInfo[] methods = stringType.GetMethods();
            //foreach (var method in methods)
            //{
            //    Console.WriteLine(method);
            //}
            //Console.WriteLine("*********************************");
            //Console.WriteLine("\n");
            //Console.WriteLine(" *** Properties in String Class ***");

            //PropertyInfo[] properties = stringType.GetProperties();
            //foreach (var property in properties)
            //{
            //    Console.WriteLine(property);
            //}
            //Console.ReadKey();

            Type objType = typeof(DateTime);
            Console.WriteLine("TypeName: \t" + objType.FullName);
            Console.WriteLine("Full Name: \t" + objType.FullName);
            Console.WriteLine("Assembly: \t" + objType.Assembly);
            Console.WriteLine("NameSpace: \t" + objType.Namespace);
            Console.WriteLine("Base: \t" + objType.BaseType);
            Console.WriteLine($" *** Methods in {objType.Name} String class ***");

            MethodInfo[] methods = objType.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method);
            }
            Console.WriteLine("*********************************");
            Console.WriteLine("\n");
            Console.WriteLine(" *** Properties in String Class ***");

            PropertyInfo[] properties = objType.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property);
            }
            Console.ReadKey();
        }
    }
}
