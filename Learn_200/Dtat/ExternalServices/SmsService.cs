namespace Dtat.ExternalServices;

public class SmsService : object, ISmsService
{
	public SmsService() : base()
	{
	}

	public bool SendSms(string cellPhoneNumber, string message)
	{
		// Sending SMS!

		return true;
	}
}
