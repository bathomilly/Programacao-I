class Calculadora
{
    public static int CalcOperation(char selectedOperator, int num1, int num2)
    {
        switch (selectedOperator)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return num1 / num2;
            default:
                return 0;
        }
    }
}