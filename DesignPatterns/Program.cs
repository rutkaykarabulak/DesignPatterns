// See https://aka.ms/new-console-template for more information

using DesignPatterns.CreationalPatterns.Factory;

BMWFactory bmwFacotry = new();

VolkswagenFactory volkswagenFactory = new();

ICar bmw320d = bmwFacotry.ProduceCar();

bmw320d.Drive();

ICar polo = volkswagenFactory.ProduceCar();

polo.Drive();
