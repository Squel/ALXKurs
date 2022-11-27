using System;

public class OwnExepction: Exception
{
	public OwnExepction()
	{
	}

	public OwnExepction(string? message): base(message)
	{

	}

	public OwnExepction(string? message, Exception? innerException): base(message, innerException)
	{

	}
}
