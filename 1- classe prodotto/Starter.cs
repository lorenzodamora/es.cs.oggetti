using System;
using System.Threading.Tasks;
using static System.Console;

namespace _19_09_23
{
	internal class Starter
	{
		/*
		 * Creare la classe prodotto contenente:
		 * - gli attributi nome e prezzo
		 * - costruttore senza parametri e con parametri
		 * - metodi che restituiscano il valore degli attributi
		 * 
		 * Creare il main che istanzia due oggetti di tipo prodotto e ne stampi il valore degli attributi
		*/

		static void Main()
		{
			Write("Nome prodotto: ");
			string name = ReadLine();
			Write("Prezzo prodotto: ");
			float price = float.Parse(ReadLine());

			/*
			while(!float.TryParse($"{ReadLine()}", out price) || price < 0.0f)
			{//bad input
				Task.Delay(300).Wait();
				SetCursorPosition(2, 2);
				Write($"numero intero positivo");
				SetCursorPosition(0, 1);
				Write(" ");
				CursorLeft--;
			}
			Task.Delay(500).Wait();
			*/

			Prodotto pro1 = new Prodotto(name, price);

			Write("Nome prodotto: ");
			name = ReadLine();
			Write("Prezzo prodotto: ");
			price = float.Parse(ReadLine());

			Prodotto pro2 = new Prodotto(name, price);
			Prodotto pro0 = new Prodotto();

			Write(Environment.NewLine);
			WriteLine("Nome prodotto1: " + pro1.GetNome() + "\nPrezzo: " + pro1.GetPrezzo());
			WriteLine("Nome prodotto2: " + pro2.GetNome() + "\nPrezzo: " + pro2.GetPrezzo());
			WriteLine("Nome prodotto2: " + pro0.GetNome() + "\nPrezzo: " + pro0.GetPrezzo());

			if(pro0.SetProdotto("testo di esempio", 99.99f))
				WriteLine("Nome prodotto2: " + pro0.GetNome() + "\nPrezzo: " + pro0.GetPrezzo());
			else
				WriteLine("error");
		}
	}
}
