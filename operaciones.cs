using System;

public class Operaciones
{
	public static void Main()
	{
		int numero1;
		int numero2;
		int mult;
		
		int suma;
		int resta;
		int division;
		int resto;
		
		Console.Write("Introduzca primer numero:");
		numero1 = Convert.ToInt32(System.Console.ReadLine());
		
		Console.Write("Introduzca el segundo numero:");
		numero2 = Convert.ToInt32(System.Console.ReadLine());

		mult = numero1 * numero2;

		suma = numero1 + numero2;
		resta = numero1 - numero2;
		division = numero1 / numero2;
		resto = numero1 % numero2;

		Console.WriteLine("La multiplicacion es:");
		Console.WriteLine(mult);
		
		Console.WriteLine("La suma es:");
		Console.WriteLine(suma);
		
		Console.WriteLine("La resta es:");
		Console.WriteLine(resta);
		
		Console.WriteLine("La division es:");
		Console.WriteLine(division);
		
		Console.WriteLine("El resto es:");
		Console.WriteLine(resto);
	}
}
