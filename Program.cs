using System;
using Tesseract;

namespace TesteTesseract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--> Start");

            for(int i = 1; i < 19; i++)
            {
                var tesseract = new TesseractEngine("C:\\TesteTesseract\\tessdata", "por", EngineMode.Default);
                tesseract.SetVariable("load_system_dawg", true);
                tesseract.SetVariable("load_freq_dawg", true);
                tesseract.SetVariable("tessedit_write_imag", true);
                var pix = Pix.LoadFromFile($"C:\\TesteTesseract\\TESTE{i}.png");
                var page = tesseract.Process(pix);
                var result = page.GetText();
                Console.WriteLine($"--> TESTE{i}.png");
                Console.WriteLine($"--> {page.GetMeanConfidence()}");
                Console.WriteLine($"--> {result}");
                Console.WriteLine($"-----------------------");
                Console.WriteLine($"");

            }
            Console.ReadLine();
            

            //Cestaoteste.png

            //C:\TesteTesseract\Cestaoteste.png
        }
    }
}
