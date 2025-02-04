
Console.WriteLine("vložte závorky");
string zavorky = Console.ReadLine();
char[] poleZnaku = zavorky.ToCharArray();
Stack<char> zasobnik = new Stack<char>();

void chyba()
{
	Console.WriteLine("závorky nejsou v pořádku");
	Environment.Exit(1);
}

foreach (char znak in poleZnaku)
{
	if (znak == '(' || znak == '[' || znak == '{')
	{
		zasobnik.Push(znak);
	}
	else
	{
		if (znak == ')' || znak == '}' || znak == ']')
		{
			if (zasobnik.Count == 0)
			{
				chyba();
			}
			char top = zasobnik.Pop();
			if ((znak == ')' && top != '(')
				|| (znak == ']' && top != '[')
				|| (znak == '}' && top != '{')
				) { chyba(); }
		}
		else { chyba(); }

	}
}
if (zasobnik.Count != 0)
{
	chyba();
}

Console.WriteLine("závorky v pořádku");
