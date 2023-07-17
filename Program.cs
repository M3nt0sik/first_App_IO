using System.Text;
class Program
{
    private static void Main(string[] args)
    {
        using (var ms = new MemoryStream()) { 
            using (var sw = new StreamWriter(ms))
            {
                sw.WriteLine("Wartosc wynosi {0:0.00}", 123.456789);
                
            }
            Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
        }
    }
}