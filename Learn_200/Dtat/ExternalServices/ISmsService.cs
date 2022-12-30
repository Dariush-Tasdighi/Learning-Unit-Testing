namespace Dtat.ExternalServices;

public interface ISmsService
{
	bool SendSms(string cellPhoneNumber, string message);
}
