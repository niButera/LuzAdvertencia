internal class Program
{   
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(@$"    --= Luz de Advertência =--

Sensor [A]tivado ou [D]esativado");

        Console.WriteLine();
        Console.Write("Sensor de temperatura...: ");

        string temperatura = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

        bool tpa = temperatura == "A";
        bool tpd = temperatura == "D";
        bool tpad = tpa || tpd;

        if (!tpad)
        {
            Console.WriteLine();
            Console.WriteLine("Informe somente [A]tivado ou [D]esativado");
            return;
        }

        if (tpd)
        {
                Console.WriteLine();
                Console.Write("A luz de advertência está ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Desativada"); 
                Console.ResetColor(); 
                Console.WriteLine();
        }

        else
        {
            Console.Write("Sensor de pressão.......: ");

            string pressao = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

            bool pa = pressao == "A";
            bool pd = pressao == "D";
            bool pda = pa || pd;

                    if (!pda)
                {
                    Console.WriteLine("Informe somente [A]tivado ou [D]esativado");
                    return;
                }

            Console.Write("Sensor de rotação.......: ");

            string rotacao = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

            bool rta = rotacao == "A";
            bool rtd = rotacao == "D";
            bool rtad = rta || rtd;

                    if (!rtad)
                {
                    Console.WriteLine();
                    Console.WriteLine("Informe somente [A]tivado ou [D]esativado");
                    return;
                }

            if (pa || rtd)
            {
                Console.WriteLine();
                Console.Write("A luz de advertência está ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ativada"); 
                Console.ResetColor(); 
            }


            else
            {
                Console.WriteLine();
                Console.Write("A luz de advertência está ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Desativada"); 
                Console.ResetColor(); 
            }
        }
    }
}