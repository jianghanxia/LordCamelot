using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LordCamelot.Services;
using Xamarin.Forms;
using Environment = System.Environment;

[assembly: Dependency(typeof(LordCamelot.Droid.Services.System_Android))]
namespace LordCamelot.Droid.Services
{
	public class System_Android : ISystem
	{
		public void CloseApp()
		{
			Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
		}

		public string GetLocalFilePath(string filename)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			return Path.Combine(path, filename);
		}

		public string GetVersionName()
		{
			var context = Android.App.Application.Context;
			return context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionName;
		}
	}
}