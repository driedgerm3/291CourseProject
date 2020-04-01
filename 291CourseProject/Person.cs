using System;

public class Person
{
	string ID;
	string Name;
	public Person(int ID, string First_Name, string Last_Name)
	{
		this.ID = ID.ToString();
		this.Name = First_Name + " " + Last_Name;
	}

	public override string ToString()
	{
		return this.Name;
	}
	public string getName() { return this.Name; }
	public string getID() { return this.ID;}
}
