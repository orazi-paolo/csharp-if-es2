// dichiaro la variabile age e chiedo all'utente di inserire un valore
int age;
Console.WriteLine("Quanti anni hai?");
int.TryParse(Console.ReadLine(), out age);

// se l'età è compresa tra 6 e 10 anni
if (age >= 6 && age <= 10)
{
    Console.WriteLine("Dovresti essere alla scuola elementare");
}
else if (age >= 11 && age <= 13) // se l'età è compresa tra 11 e 13 anni
{
    Console.WriteLine("Dovresti essere alla scuola media");
}
else if (age >= 14 && age <= 18) // se l'età è compresa tra 14 e 18 anni
{
    Console.WriteLine("Dovresti essere alla scuola superiore");
}
else if (age > 18) // se l'età è maggiore di 18 anni
{
    Console.WriteLine("Dovresti essere all'università o lavorare");
}
else // altrimenti
{
    Console.WriteLine("Sei troppo giovane per la scuola");
}