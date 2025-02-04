Console.WriteLine("napiš slovo");
string slovo = Console.ReadLine();
char[] poleZnaku = slovo.ToCharArray();
Stack<char> zasobnik = new Stack<char>();

foreach (char znak in poleZnaku)
{
	zasobnik.Push(znak);
}
for (int i = 0; i < poleZnaku.Length; i++)
{
	Console.Write(zasobnik.Pop());
}
