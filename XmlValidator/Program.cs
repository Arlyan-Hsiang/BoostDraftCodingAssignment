using System;

namespace XmlValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    Console.WriteLine("Usage: XmlValidator <xml-string>");
                    return;
                }

                string xml = args[0];
                string result = SimpleXmlValidator.DetermineXml(xml);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
