using System;

namespace CreationalPatterns.DesignPatterns.Singleton;
/// <summary>
/// Singleton is a creational design patterns that lets you ensure that class has only one instance, and the instance is globally accessible.
/// </summary>
internal class Database
{
	public static Database database;

	private readonly string _name;
	private Database(string connectionString)
	{
		Console.WriteLine("Connection has been created with:" + connectionString);
	}
	public static Database GetInstance(string connectionString)
	{
		if (database == null)
		{
			database = new Database(connectionString);
		}

		return database;
	}
}