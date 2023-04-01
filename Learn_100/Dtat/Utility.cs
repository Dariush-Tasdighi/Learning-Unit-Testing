namespace Dtat;

// **************************************************
//public class Utility : object
//{
//	public Utility() : base()
//	{
//	}

//	public string? FixText(string? text)
//	{
//		return text;
//	}
//}
// **************************************************

// **************************************************
//public class Utility : object
//{
//	public Utility() : base()
//	{
//	}

//	public string? FixText(string? text)
//	{
//		if (string.IsNullOrWhiteSpace(value: text))
//		{
//			return null;
//		}

//		return text;
//	}
//}
// **************************************************

// **************************************************
//public class Utility : object
//{
//	public Utility() : base()
//	{
//	}

//	public string? FixText(string? text)
//	{
//		if (string.IsNullOrWhiteSpace(value: text))
//		{
//			return null;
//		}

//		text =
//			text.Trim();

//		return text;
//	}
//}
// **************************************************

// **************************************************
//public class Utility : object
//{
//	public Utility() : base()
//	{
//	}

//	public string? FixText(string? text)
//	{
//		if (string.IsNullOrWhiteSpace(value: text))
//		{
//			return null;
//		}

//		text =
//			text.Trim();

//		text = text.Replace
//			(oldValue: "  ", newValue: " ");

//		//text = text.Replace
//		//	(oldValue: "   ", newValue: " ");

//		//text = text.Replace
//		//	(oldValue: "   ", newValue: " ");

//		return text;
//	}
//}
// **************************************************

// **************************************************
public class Utility : object
{
	public Utility() : base()
	{
	}

	public string? FixText(string? text)
	{
		if (string.IsNullOrWhiteSpace(value: text))
		{
			return null;
		}

		text =
			text.Trim();

		while (text.Contains(value: "  "))
		{
			text = text.Replace
				(oldValue: "  ", newValue: " ");
		}

		return text;
	}
}
// **************************************************
