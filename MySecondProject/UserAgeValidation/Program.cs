//küsib vanust

//goto label
label:

Console.WriteLine("Sisesta oma vanus");

//consool loeb stringi ja parsib 
int userAge = Int32.Parse (Console.ReadLine());

//kui kasutaja on noorem kui siis tere tulemast
if(userAge >= 13)
{
    Console.WriteLine("Tere Tulemast!!");
}

//kui ei ole siis teavita,et pead veel kasvama
else 
{
    Console.WriteLine("Pead veel kasvama!");
    //prooviks,et viskaks algusesse tagasi
    goto label;
}




