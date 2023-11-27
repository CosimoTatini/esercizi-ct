Console.WriteLine("Inserisci quattro variabili");
int w= Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z= Convert.ToInt32(Console.ReadLine());
bool nSpecial = true;
nSpecial = true;
nSpecial = ((w + x) * (y - z)) == 42;
Console.WriteLine(nSpecial);