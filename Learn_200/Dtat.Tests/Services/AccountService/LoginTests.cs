namespace Dtat.Tests.Services.AccountService;

public class LoginTests : object
{
	public LoginTests() : base()
	{
	}

	//[Fact]
	//public void Test_BadPractice()
	//{
	//	// Arrange
	//	var smsService =
	//		new ExternalServices.SmsService();

	//	var accountService =
	//		new Dtat.Services.AccountService(smsService: smsService);

	//	// Act and Assert
	//	var ex =
	//		Record.Exception(() =>
	//		{
	//			var result = accountService.Login
	//				(cellPhoneNumber: "09123456789", password: "1234567890");
	//		});

	//	Assert.NotNull(@object: ex);
	//	Assert.IsType<System.Exception>(@object: ex);
	//	Assert.Equal(expected: "Invalid Username/Password!", actual: ex.Message);
	//}

	[Fact]
	public void Test_Username()
	{
		// Arrange
		// **************************************************
		var mockSmsService =
			new Moq.Mock<Dtat.ExternalServices.ISmsService>();
		// **************************************************

		var accountService =
			new Dtat.Services.AccountService
			(smsService: mockSmsService.Object);

		// Act
		var ex =
			Record.Exception(() =>
			{
				var result = accountService.Login
					(cellPhoneNumber: "09123456789", password: "1234567890");
			});

		// Assert
		Assert.NotNull(@object: ex);
		Assert.IsType<System.Exception>(@object: ex);
		Assert.Equal(expected: "Invalid Username/Password!", actual: ex.Message);
	}

	[Fact]
	public void Test_Password()
	{
		// Arrange
		// **************************************************
		var mockSmsService =
			new Moq.Mock<Dtat.ExternalServices.ISmsService>();
		// **************************************************

		var accountService =
			new Dtat.Services.AccountService
			(smsService: mockSmsService.Object);

		// Act
		var ex =
			Record.Exception(() =>
			{
				var result = accountService.Login
					(cellPhoneNumber: "09121087461", password: "1234567890");
			});

		// Assert
		Assert.NotNull(@object: ex);
		Assert.IsType<System.Exception>(@object: ex);
		Assert.Equal(expected: "Invalid Username/Password!", actual: ex.Message);
	}

	[Fact]
	public void Test_SmsServiceFailed()
	{
		// Arrange
		// **************************************************
		var mockSmsService =
			new Moq.Mock<Dtat.ExternalServices.ISmsService>();

		mockSmsService.Setup(current =>
			current.SendSms
			(Moq.It.IsAny<string>(), Moq.It.IsAny<string>()))
			.Returns(value: false);
		// **************************************************

		var accountService =
			new Dtat.Services.AccountService
			(smsService: mockSmsService.Object);

		// Act
		var ex =
			Record.Exception(() =>
			{
				var result = accountService.Login
					(cellPhoneNumber: "09121087461", password: "1234512345");
			});

		// Assert
		Assert.NotNull(@object: ex);
		Assert.IsType<System.Exception>(@object: ex);
		Assert.Equal(expected: "SMS center is down!", actual: ex.Message);
	}

	[Fact]
	public void Test_SmsServiceSuccess()
	{
		// Arrange
		// **************************************************
		var mockSmsService =
			new Moq.Mock<Dtat.ExternalServices.ISmsService>();

		mockSmsService.Setup(current => current
			.SendSms(Moq.It.IsAny<string>(), Moq.It.IsAny<string>()))
			.Returns(value: true);
		// **************************************************

		var accountService =
			new Dtat.Services.AccountService
			(smsService: mockSmsService.Object);

		// Act
		var result = accountService.Login
			(cellPhoneNumber: "09121087461", password: "1234512345");

		// Assert
		Assert.Equal(expected: "GoogooliMagooli", actual: result);
	}
}
