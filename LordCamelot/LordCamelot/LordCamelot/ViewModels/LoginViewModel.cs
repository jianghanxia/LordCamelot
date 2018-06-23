using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using LordCamelot.Models;
using LordCamelot.Services;
using Prism.Navigation;
using Prism.Services;

namespace LordCamelot.ViewModels
{
	public class LoginViewModel : BindableBase, INavigationAware
	{
		private INavigationService NavigationService { get; }
		private IPageDialogService PageDialogService { get; }

		public string UserName { get; set; }
		public string Password { get; set; }
		public bool IOS { get; set; }

		public List<User> UserList { get; set; }

		public DelegateCommand AddCommand { get; }
		public DelegateCommand AddAllCommand { get; }
		public DelegateCommand SaveUserCommand { get; }

		public LoginViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
	        NavigationService = navigationService;
	        PageDialogService = pageDialogService;

			AddCommand = new DelegateCommand(async () =>
	        {
		        Runtime.Environment.Game.Add(new Game {UserName = UserName, Password = Password, IsiOS = IOS});
				if (UserList.All(i => i.Name != UserName))
				{
					Runtime.Database.GetCollection<User>().Upsert(new User { Name = UserName, Password = Password, IsIOS = IOS });
				}
				await NavigationService.GoBackAsync();
	        });

	        AddAllCommand = new DelegateCommand(async () =>
	        {
		        Runtime.Environment.Game.Clear();

				var li = Runtime.Database.GetCollection<User>().FindAll();
		        foreach (var l in li)
		        {
			        Runtime.Environment.Game.Add(new Game {UserName = l.Name, Password = l.Password, IsiOS = l.IsIOS});
		        }

		        await NavigationService.GoBackAsync();
	        });

			SaveUserCommand = new DelegateCommand(async () =>
	        {
		        var li = Runtime.Database.GetCollection<User>().FindAll().Select(i => i.Name).ToArray();
		        var ss = await PageDialogService.DisplayActionSheetAsync("", null, null, li);
		        if (ss != null)
		        {
			        var se = UserList.Single(i => i.Name == ss);
			        UserName = se.Name;
			        Password = se.Password;
			        IOS = se.IsIOS;
		        }
	        });

	        UserList = Runtime.Database.GetCollection<User>().FindAll().ToList();
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
		}
	}
}
