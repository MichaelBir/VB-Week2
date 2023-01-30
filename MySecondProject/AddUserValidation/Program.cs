// goto label vigase soo puhul
label2:
//rakendus küsib, et sisestaksid oma soo m/n
Console.WriteLine("Vali oma sugu: m/n");

//loeb konsoolist maha stringi (sõne) formaadis
char userGender = Char.Parse(Console.ReadLine());

//Küsi nime
Console.WriteLine("Sisesta oma perenimi");

//loeb konsoolist stringi
string userLastName = Console.ReadLine();

//kui kasutaja sugu =m siis ervita Tere Mees
if (userGender == 'm')
{
    Console.WriteLine($"Tere, Mees!",(userLastName));
}

//kui sisestab f siis tervita Tere Naine
else if(userGender =='n')
{
    Console.WriteLine($"Tere, Naine!",(userLastName));
}

//Muul juhul teata Vigane valik
else
{
    Console.WriteLine($"Vigane valik!",(userLastName));
    //kui täht on vigane viska algusesse tagasi
    goto label2;
}

//rakendus vastab 
//Console.WriteLine($"Tere,{userGender}");





