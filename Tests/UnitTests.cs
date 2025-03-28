namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
	}
}

public class Subtraction
{
	[TestMethod]
	public void Subtract_Valid_Patino()
	{
		Assert.AreEqual(-1, Program.Subtract("1", "2"));
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(0, Program.Subtract("7", "7"));
	}

	[TestMethod]
	public void Subtract_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
	}

	[TestMethod]
	public void Subtract_Null_Patino()
	{
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
	}
}

public class Multiplication
{
	[TestMethod]
	public void Multiply_Valid_Patino()
	{
		Assert.AreEqual(15, Program.Multiply("3", "5"));
		Assert.AreEqual(-6, Program.Multiply("-3", "2"));
		Assert.AreEqual(0, Program.Multiply("7", "7"));
	}

	[TestMethod]
	public void Multiply_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
	}

	[TestMethod]
	public void Multiply_Null_Patino()
	{
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
	}
}

public class Division
{
	[TestMethod]
	public void Divide_Valid_Patino()
	{
		Assert.AreEqual(5, Program.Divide("10", "2"));
		Assert.AreEqual(20, Program.Divide("-100", "-5"));
		Assert.AreEqual(1, Program.Divide("7", "7"));
	}

	[TestMethod]
	public void Divide_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
	}

	[TestMethod]
	public void Divide_Null_Patino()
	{
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
	}
}

public class Exponentiation
{
	[TestMethod]
	public void Power_Valid_Patino()
	{
		Assert.AreEqual(100, Program.Power("10", "2"));
		Assert.AreEqual(16, Program.Power("2", "4"));
		Assert.AreEqual(125, Program.Power("5", "3"));
	}

	[TestMethod]
	public void Power_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
	}

	[TestMethod]
	public void Power_Null_Patino()
	{
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
	}
}
