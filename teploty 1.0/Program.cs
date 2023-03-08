
using Spectre.Console;
int[] pole = new int[31];
var mesic = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Zvol si [red]měsíc[/]")
        .PageSize(12)
        .AddChoices(new[] {
            "Leden", "Únor", "Březen", "Duben", "Květen", "Červen,", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec",
        }));


for (int i = 1; i <= 31; i++)
{
    AnsiConsole.Markup("Zapiš teplotu na den [red]" + i + "[/]" );
    Console.WriteLine();
    pole[i - 1] = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine("Maximální teplota byla "+ pole.Max());
Console.WriteLine("Průměrná teplota dne byla " + pole.Average());
Console.WriteLine("Minimální teplota byla " + pole.Min());


