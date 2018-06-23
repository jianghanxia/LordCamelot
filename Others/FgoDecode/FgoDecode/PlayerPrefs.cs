using System;
using System.Runtime.CompilerServices;
//using UnityEngine.Internal;

public sealed class PlayerPrefsException : Exception
{
	public PlayerPrefsException(string error)
		: base(error)
	{
	}
}