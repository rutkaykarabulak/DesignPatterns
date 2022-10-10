// See https://aka.ms/new-console-template for more information


// FACTORY PATTERN

//using DesignPatterns.CreationalPatterns.Factory;

//BMWFactory bmwFacotry = new();

//VolkswagenFactory volkswagenFactory = new();

//ICar bmw320d = bmwFacotry.ProduceCar();

//bmw320d.Drive();

//ICar polo = volkswagenFactory.ProduceCar();

//polo.Drive();


// ADAPTER PATTERN

using DesignPatterns.Structural_Patterns.Adapter;

RoundHole roundHole = new(10);
RoundPeg roundPeg = new(8);

Console.WriteLine(roundHole.Fits(roundPeg)); // it will be true, everything is expected

SquarePeg squarePeg = new(5);

// Console.WriteLine(roundHole.Fits(squarePeg)); // it won't be acceptable since roundhole accepts only and only round peg

SquareAdapter adapter = new(squarePeg);

Console.WriteLine(adapter.GetRadius());

Console.WriteLine(roundHole.Fits(adapter));

