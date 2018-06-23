using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using LordCamelot.Models;
using LordCamelot.Services;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace LordCamelot.Droid.Services
{
	[Service]
	public class BackService_Android : Service
	{
		private string _lastError;
		private bool _isError;
		private bool _isRunning;
		private Task _task;

		public override IBinder OnBind(Intent intent)
		{
			return null;
		}

		public override void OnCreate()
		{
			_isRunning = false;
			_task = new Task(DoWork, TaskCreationOptions.LongRunning);
		}

		public override void OnDestroy()
		{
			var notificationManager = (NotificationManager)GetSystemService(NotificationService);
			notificationManager.Cancel((int)NotificationFlags.ForegroundService);

			_isRunning = false;
			StopForeground(true);
			StopSelf();
		}

		public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
		{
			if (!_isRunning)
			{
				_isRunning = true;
				_task.Start();

				var notification = new Notification.Builder(this)
					.SetContentTitle("LordCamelot")
					.SetSmallIcon(Resource.Drawable.icon)
					.SetContentIntent(BuildIntentToShowMainActivity())
					.SetOngoing(true)
					.Build();

				StartForeground((int)NotificationFlags.ForegroundService, notification);
			}

			return StartCommandResult.Sticky;
		}

		PendingIntent BuildIntentToShowMainActivity()
		{
			var notificationIntent = new Intent(this, typeof(MainActivity));
			notificationIntent.SetFlags(ActivityFlags.SingleTop | ActivityFlags.ClearTask);
			var pendingIntent = PendingIntent.GetActivity(this, 0, notificationIntent, PendingIntentFlags.UpdateCurrent);
			return pendingIntent;
		}

		private async void DoWork()
		{
			while (_isRunning)
			{
				try
				{
					await Runtime.RunTask();

					await Task.Delay(10000);
				}
				catch (Exception e)
				{
					MessagingCenter.Send(new LogMessage(e.Message), "Log");
				}
			}

			Runtime.StopService();
		}
	}
}