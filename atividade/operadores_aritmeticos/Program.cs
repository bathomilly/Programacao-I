class Program
{
    static void Main()
    {
        while (true)
        {
            WriteLine("Selecione o operador (+ - * /) ou digite 'x' para sair:");
            char selectedOperator = ReadKey().KeyChar;

            if (selectedOperator == 'x')
            {
                WriteLine("\nPrograma encerrado.");
                break;
            }

            if (selectedOperator == '+' || selectedOperator == '-' || selectedOperator == '*' || selectedOperator == '/')
            {
                WriteLine($"\nTabuada do operador {selectedOperator}:");

                for (int i = 1; i <= 9; i++)
                {
                    WriteLine($"{i} {selectedOperator} 9 = {Calculadora.CalcOperation(selectedOperator, i, 9)}");
                }
            }
            else
            {
                WriteLine("\nInválido. Escolha +, -, * ou /.");
            }
        }
    }
}
