using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LordCamelot.Models;
using LordCamelot.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace LordCamelot.ViewModels
{
	public class MainViewModel : BindableBase, INavigationAware
	{
		private INavigationService NavigationService { get; }
		private IPageDialogService PageDialogService { get; }

		public Services.Environment Environment => Runtime.Environment;

		public Game SelectGame { get; set; }
		public UserDeck SelectDeck { get; set; }
		public MstQuest SelectQuest { get; set; }
		public List<MstQuest> QuestList { get; set; }
		public List<string> WarList { get; set; }

		public int MaxQuestPhase { get; set; } = 2;
		public int QuestPhase { get; set; } = 1;
		public int SelectAPFunc { get; set; } = 1;
		public bool IsQuestPhase { get; set; }

		public DelegateCommand AddCommand { get; }
		public DelegateCommand<Game> StartCommand { get; }
		public DelegateCommand<Game> StopCommand { get; }
		public DelegateCommand<Game> HomeCommand { get; }
		public DelegateCommand BeginCommand { get; }
		public DelegateCommand BeginAllCommand { get; }
		public DelegateCommand GachaCommand { get; }
		public DelegateCommand APCommand { get; }
		public DelegateCommand SellCommand { get; }

		public MainViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
		{
			NavigationService = navigationService;
			PageDialogService = pageDialogService;

			BeginCommand = new DelegateCommand(async () =>
			{
				try
				{
					Runtime.Environment.BattleTask.Add(new BattleTask {Game = SelectGame, DeckID = SelectDeck.id, QuestID = SelectQuest.Id, QuestPhase = QuestPhase});
					await PageDialogService.DisplayAlertAsync("成功", "添加任务成功", "OK");
				}
				catch (Exception e)
				{
					await PageDialogService.DisplayAlertAsync("错误", e.Message, "OK");
				}
			});
			BeginAllCommand = new DelegateCommand(async () =>
			{
				try
				{
					var result = await PageDialogService.DisplayAlertAsync("提示", "是否添加到所有账号?", "是", "否");
					if (result)
					{
						foreach (var game in Environment.Game)
						{
							Runtime.Environment.BattleTask.Add(new BattleTask {Game = game, DeckID = game.Deck.First().id, QuestID = SelectQuest.Id, QuestPhase = QuestPhase});
						}

						await PageDialogService.DisplayAlertAsync("成功", "添加任务成功", "OK");
					}
				}
				catch (Exception e)
				{
					await PageDialogService.DisplayAlertAsync("错误", e.Message, "OK");
				}
			});
			GachaCommand = new DelegateCommand(async () =>
			{
				try
				{
					await SelectGame.fgo_gachadraw(1, 10);
					MessagingCenter.Send(new LogMessage(SelectGame, "友情抽取成功."), "Log");
				}
				catch (Exception e)
				{
					await PageDialogService.DisplayAlertAsync("错误", e.Message, "OK");
				}
			});
			APCommand = new DelegateCommand(async () =>
			{
				try
				{
					await SelectGame.RecoverAP(SelectAPFunc);
					await PageDialogService.DisplayAlertAsync("成功", "体力恢复成功", "OK");
				}
				catch (Exception e)
				{
					await PageDialogService.DisplayAlertAsync("错误", e.Message, "OK");
				}
			});
			SellCommand = new DelegateCommand(async () =>
			{
				try
				{
					await SelectGame.Sell();
				}
				catch (Exception e)
				{
					await PageDialogService.DisplayAlertAsync("错误", e.Message, "OK");
				}
			});

			AddCommand = new DelegateCommand(async () => { await NavigationService.NavigateAsync("Login"); });
			StartCommand = new DelegateCommand<Game>(async (game) =>
			{
				game.IsStart = true;
				await game.Login();
			});
			StopCommand = new DelegateCommand<Game>(async (game) =>
			{
				game.IsStart = false;
			});
			HomeCommand = new DelegateCommand<Game>(async (game) =>
			{
				await game.fgo_home();
				MessagingCenter.Send(new LogMessage(game, "刷新成功."), "Log");
			});

			LoadConfig();
		}

		private async void LoadConfig()
		{
			if (!Runtime.Environment.IsSvrStart)
			{
				await Runtime.LoadConfig();
				Runtime.StartService();
			}

			var zt = DateTime.Now.ToString("ddd", new System.Globalization.CultureInfo("zh-cn"));
			QuestList = Runtime.Config.MstQuest.Where(i => i.ChapterId == 24 && i.ChaldeaGateCategory == 1 && i.Name.StartsWith(zt)).ToList();

			WarList = Runtime.Config.MstQuest.Select(i => i.WarName).Distinct().ToList();
			WarList.Insert(0, "日常");
			WarList.Insert(1, "Free");
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

		public void QuestType_OnSelectedIndexChanged(string select)
		{
			if (select == "日常")
			{
				var zt = DateTime.Now.ToString("ddd", new System.Globalization.CultureInfo("zh-cn"));
				QuestList = Runtime.Config.MstQuest.Where(i => i.ChapterId == 24 && i.ChaldeaGateCategory == 1 && i.Name.StartsWith(zt)).ToList();
			}
			else if (select == "Free")
			{
				QuestList = Runtime.Config.MstQuest.Where(i => i.Type == QuestType.Free).ToList();
			}
			else
			{
				QuestList = Runtime.Config.MstQuest.Where(i => i.WarName == select).ToList();
			}
		}

		public void Quest_OnSelectedIndexChanged()
		{
			var p = Runtime.Config.MstQuestPhase.Where(i => i.QuestId == SelectQuest.Id).Max(i => i.Phase);
			if (p > 1)
			{
				MaxQuestPhase = p;
				IsQuestPhase = true;
			}
			else
			{
				QuestPhase = 1;
				IsQuestPhase = false;
			}
		}
	}
}
