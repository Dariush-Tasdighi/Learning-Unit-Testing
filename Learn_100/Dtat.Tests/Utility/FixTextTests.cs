namespace Dtat.Tests.Utility;

public class FixTextTests : object
{
	public FixTextTests() : base()
	{
	}

	[Fact]
	public void Test_Something()
	{
		// Arrange

		// Act

		// Assert
	}

	[Fact]
	public void Test_01()
	{
		// Arrange
		var utility =
			new Dtat.Utility();

		// Act
		var result =
			utility.FixText(text: null);

		// Assert
		//Assert.Equal
		//	(expected: null, actual: result);

		Assert.Null(@object: result);
	}

	[Fact]
	public void Test_02()
	{
		// Arrange
		var utility =
			new Dtat.Utility();

		// Act
		var result =
			utility.FixText(text: string.Empty);

		// Assert
		Assert.Null(@object: result);
	}

	[Fact]
	public void Test_03()
	{
		// Arrange
		var utility =
			new Dtat.Utility();

		// Act
		var result =
			utility.FixText(text: "     ");

		// Assert
		Assert.Null(@object: result);
	}

	[Fact]
	public void Test_04()
	{
		// Arrange
		var utility =
			new Dtat.Utility();

		// Act
		var result =
			utility.FixText(text: "Dariush Tasdighi");

		// Assert
		Assert.Equal
			(expected: "Dariush Tasdighi", actual: result);
	}

	[Fact]
	public void Test_05()
	{
		// Arrange
		var utility =
			new Dtat.Utility();

		// Act
		var result =
			utility.FixText(text: "     Dariush Tasdighi     ");

		// Assert
		Assert.Equal
			(expected: "Dariush Tasdighi", actual: result);
	}

	[Fact]
	public void Test_06()
	{
		// Arrange
		var utility =
			new Dtat.Utility();

		// Act
		var result =
			utility.FixText(text: "     Dariush  Tasdighi     ");

		// Assert
		Assert.Equal
			(expected: "Dariush Tasdighi", actual: result);
	}

	[Fact]
	public void Test_07()
	{
		// Arrange
		var utility =
			new Dtat.Utility();

		// Act
		var result =
			utility.FixText(text: "     Dariush     Tasdighi     ");

		// Assert
		Assert.Equal
			(expected: "Dariush Tasdighi", actual: result);
	}
}
