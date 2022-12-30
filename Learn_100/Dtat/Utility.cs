namespace Dtat;

// **************************************************
//public class Utility : object
//{
//	public Utility() : base()
//	{
//	}

//	public string FixText(string? text)
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

//	public string FixText(string? text)
//	{
//		if (text == null)
//		{
//			return string.Empty;
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

//	public string FixText(string? text)
//	{
//		if (text == null)
//		{
//			return string.Empty;
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

//	public string FixText(string? text)
//	{
//		if (text == null)
//		{
//			return string.Empty;
//		}

//		text =
//			text.Trim();

//		text = text.Replace
//			(oldValue: "  ", newValue: " ");

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

	public string FixText(string? text)
	{
		if (text == null)
		{
			return string.Empty;
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
