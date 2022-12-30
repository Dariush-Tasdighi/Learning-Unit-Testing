﻿namespace Dtat.Services;

public class AccountService : object
{
	public AccountService
		(ExternalServices.ISmsService smsService) : base()
	{
		SmsService = smsService;
	}

	protected ExternalServices.ISmsService SmsService { get; }

	public string Login
		(string cellPhoneNumber, string password)
	{
		if (cellPhoneNumber != "09121087461")
		{
			var errorMessage =
				"Invalid Username/Password!";

			throw new System
				.Exception(message: errorMessage);
		}

		if (password != "1234512345")
		{
			var errorMessage =
				"Invalid Username/Password!";

			throw new System
				.Exception(message: errorMessage);
		}

		var sendSmsResult =
			SmsService.SendSms(cellPhoneNumber:
			cellPhoneNumber, message: "Welcome to our site!");

		if (sendSmsResult == false)
		{
			var errorMessage =
				"SMS center is down!";

			throw new System
				.Exception(message: errorMessage);
		}

		var token = "GoogooliMagooli";

		return token;
	}
}