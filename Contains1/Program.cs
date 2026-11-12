string testo;
string sottostringa;
bool trovata = false;
Console.Write("Inserisci il testo principale: ");
testo = Console.ReadLine();

Console.Write("Inserisci la parola da cercare: ");
sottostringa = Console.ReadLine();


int i = 0;
while (i <= testo.Length - sottostringa.Length && !trovata)
{
    int j = 0;


    while (j < sottostringa.Length && testo[i + j] == sottostringa[j])
    {
        j++;
    }


    if (j == sottostringa.Length)
    {
        trovata = true;
    }

    i++;
}


if (trovata)
{
    Console.WriteLine("TRUE - La stringa è contenuta!");
}
else
{
    Console.WriteLine("FALSE - La stringa NON è contenuta.");
}
