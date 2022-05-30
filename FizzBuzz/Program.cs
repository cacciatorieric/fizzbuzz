
void funcaoFizzBuzz(int c)
{
    for(int n = 0; n <= c; n++)
    {
        string resultado = "";
        if (n % 3 == 0) resultado = "Fizz";
        if (n % 5 == 0) resultado = resultado + "Buzz";
        if (resultado.Length == 0) resultado = n.ToString();
        Console.WriteLine(resultado);
    }
}

void main() {
    funcaoFizzBuzz(543);
}

main();
