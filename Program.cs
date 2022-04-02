double numerador, denominador, quociente;

Console.Write("Digite o numerador......: "); 
    numerador = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("Digite o denominador......: ");
    denominador = Convert.ToDouble(Console.ReadLine()); 

    if (denominador == 0)
    {
        Console.WriteLine ("Não pode ser dividido por zero.");
    }

    else 
    {
    quociente = numerador / denominador;

    Console.WriteLine($"{numerador:N1} diSvidido por {denominador:N1} é {quociente:N1}.");
    }
