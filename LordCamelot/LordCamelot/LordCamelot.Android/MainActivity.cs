using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using LordCamelot.Droid.Services;
using LordCamelot.Models;
using Xamarin.Forms;

namespace LordCamelot.Droid
{
    [Activity(Label = "LordCamelot", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
	        MessagingCenter.Subscribe<ServiceMessage>(this, "Service", ServiceAction);

			LoadApplication(new App());
		}

	    public void ServiceAction(ServiceMessage message)
	    {
		    if (message.Action == "Start")
		    {
			    var intent = new Intent(this, typeof(BackService_Android));
			    StartService(intent);
		    }
		    if (message.Action == "Stop")
		    {
			    var intent = new Intent(this, typeof(BackService_Android));
			    StopService(intent);
		    }
	    }
	}
}

