//For .Net C#:

class NameClass1
{
	public static byte byte_variables { get; set; } = 0;

}

class NameClass2
{
	void Method_variables()
    {
		if (NameClass1.byte_variables == 1)
		{
			System.Console.WriteLine("Before: ", NameClass1.byte_variables);
			NameClass1.byte_variables -= 1;
		}

		System.Console.WriteLine("After: ", NameClass1.byte_variables);
	}

}

//For C# Godot:

class NameClass1
{
	public static byte byte_variables { get; set; } = 0;

}

class NameClass2
{
	void Method_variables()
    {
		if (NameClass1.byte_variables == 1)
		{
			GD.Print("Before: ", NameClass1.byte_variables);
			NameClass1.byte_variables -= 1;
		}

		GD.Print("After: ", NameClass1.byte_variables);
	}

}
