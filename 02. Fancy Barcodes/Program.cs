using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string barcodePattern = @"@#+[A-Z][a-zA-Z\d]{4,}[A-Z]@#+";
            int numberOfBarcodes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfBarcodes; i++)
            {
                string currBarcode = Console.ReadLine();
                if (Regex.IsMatch(currBarcode, barcodePattern))
                {
                    char[] digits = currBarcode.Where(char.IsDigit).ToArray();
                    string barcodeGroup = digits.Length == 0 ? "00" : string.Join("", digits);
                    Console.WriteLine($"Product group: {barcodeGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
