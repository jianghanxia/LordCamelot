using System;
using System.Collections.Generic;
using System.Text;

namespace LordCamelot.Services
{
	public interface ISystem
	{
		void CloseApp();

		string GetLocalFilePath(string filename);

		string GetVersionName();
	}
}
