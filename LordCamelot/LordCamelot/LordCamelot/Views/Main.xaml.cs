using System;
using LordCamelot.Services;
using LordCamelot.ViewModels;
using Syncfusion.SfRangeSlider.XForms;
using Xamarin.Forms;

namespace LordCamelot.Views
{
    public partial class Main : TabbedPage
	{
        public Main()
        {
            InitializeComponent();
        }

		protected override bool OnBackButtonPressed()
		{
			Device.BeginInvokeOnMainThread(async () =>
			{
				var result = await DisplayAlert("提示", "是否退出？", "确定", "取消");
				if (result)
				{
					DependencyService.Get<ISystem>().CloseApp();
				}
			});

			return true;
		}

		private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			var s = (MainViewModel)this.BindingContext;
			s.Quest_OnSelectedIndexChanged();
		}

		private void QuestType_OnSelectedIndexChanged(object sender, EventArgs e)
		{
			var s = (MainViewModel) this.BindingContext;
			s.QuestType_OnSelectedIndexChanged(((Picker) sender).SelectedItem.ToString());
		}
	}
}
