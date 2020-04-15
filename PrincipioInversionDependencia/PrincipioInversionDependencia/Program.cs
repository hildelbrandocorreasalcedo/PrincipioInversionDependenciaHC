using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace PrincipioInversionDependencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFormato formato = new FormatoPDFService();
            IFormato formato2 = new FormatoExcelService();
            ImpresionService impresion = new ImpresionService(formato2);
            Console.WriteLine(impresion.Imprimir());
            Console.ReadKey();

        }
    }
}
