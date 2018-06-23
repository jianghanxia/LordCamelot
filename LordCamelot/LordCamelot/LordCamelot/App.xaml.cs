using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LordCamelot.Services;
using LordCamelot.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LordCamelot
{
	public partial class App : PrismApplication
	{
		public App() : this(null) { }

		public App(IPlatformInitializer initializer) : base(initializer)
		{
			Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.MaterialModule());
		}

		protected override async void OnInitialized()
		{
			InitializeComponent();

			await NavigationService.NavigateAsync("Navigation/Main");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterForNavigation<NavigationPage>("Navigation");
			containerRegistry.RegisterForNavigation<Main>();
			containerRegistry.RegisterForNavigation<Login>();
		}
	}
}
