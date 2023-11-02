// See https://aka.ms/new-console-template for more information
using BasicMath2023;



//Arrange
BasicMath bm = new BasicMath();

//Act
int addResult = bm.Add(10, 30);

//Assert
if (addResult == 40)
    Console.WriteLine($"Resultatet er {addResult} forventet resultat var 40");
else
    Console.WriteLine("Resultatet er forkert");
