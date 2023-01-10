using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTableExt;

namespace EFCorePhonebook
{
    internal class DataVisualizer
    {
        internal static void ShowTable<T>(List<T> tableData) where T : class
        {
            Console.WriteLine("\n\n");

            ConsoleTableBuilder.From(tableData).WithTitle("Phonebook").ExportAndWriteLine();
            Console.WriteLine("\n\n");
        }
    }
}
