using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLibraryApp
{
    public class SampleClass
    {
        public static int a = 5;
        public static void DoSome()
        {
            Console.WriteLine("Этот статический **** метод выполняется из DomainLibraryApp");
            a++;
        }
    }
}
