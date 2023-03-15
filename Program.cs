
using Spectre.Console;
HERE:
int[] pole = new int[31];
var mesic = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Zvol si [red]měsíc[/]")
        .PageSize(12)
        .AddChoices(new[] {
            "Leden", "Únor", "Březen", "Duben", "Květen", "Červen,", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec",              //měsíce
        }));


for (int i = 1; i <= 31; i++)
{
    AnsiConsole.Markup("Zapiš teplotu na den [red]" + i + "[/]");
    Console.WriteLine();                                                                                                                        //Cyklus
    pole[i - 1] = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("Maximální teplota byla " + pole.Max());
Console.WriteLine("Průměrná teplota dne byla " + pole.Average());                                                                              //vypisování průměru
Console.WriteLine("Minimální teplota byla " + pole.Min());


Console.WriteLine($"\nChceš pokračovat ?   (True/False)");
string next;                                                                                                                                  //Otázka na pokračování
next = Console.ReadLine();
if (next == "True")
{
    goto HERE;
}
else
{
    Console.WriteLine("Konec");
}




/*
if (pole[] = 0)
{
    for (int i = 1; i <= 31; i++)
    {
        AnsiConsole.Markup("Zapiš teplotu na den [red]" + i + "[/]");
        Console.WriteLine();
        pole[i - 1] = Convert.ToInt32(Console.ReadLine());

    }
}
if (pole[] = 1)
{
    for (int i = 1; i <= 28; i++)
    {
        AnsiConsole.Markup("Zapiš teplotu na den [red]" + i + "[/]");
        Console.WriteLine();
        pole[i - 1] = Convert.ToInt32(Console.ReadLine());

    }
}
*/