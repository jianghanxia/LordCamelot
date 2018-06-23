using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using LordCamelot.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prism.Mvvm;
using ProtoBuf;
using Xamarin.Forms;

namespace LordCamelot.Services
{
	public class Environment : BindableBase
	{
		public bool IsSvrStart { get; set; }
		public string Log { get; set; }
		public ObservableCollection<Game> Game { get; set; } = new ObservableCollection<Game>();
		public ObservableCollection<BattleTask> BattleTask { get; set; } = new ObservableCollection<BattleTask>();

		public Environment()
		{
			MessagingCenter.Subscribe<LogMessage>(this, "Log", message =>
			{
				if (message.Game == null)
				{
					Log += $"{DateTime.Now:T} {message.Content}\n";
				}
				else
				{
					Log += $"{DateTime.Now:T} {message.Game.UserName}:{message.Content}\n";
				}
			});
		}
	}

	/// <summary>
	/// 游戏运行时
	/// </summary>
	public sealed class Runtime
	{
		static Runtime()
		{
			Environment = new Environment();
			Config = new MstConfig();
			Database = new LiteDatabase($"Filename={DependencyService.Get<ISystem>().GetLocalFilePath("Data.db")};Journal=false;Password=SwitchGo;");
		}

		public static Environment Environment { get; }
		public static MstConfig Config { get; }
		public static LiteDatabase Database { get; }


		public static void StartService()
		{
			Environment.IsSvrStart = true;
			MessagingCenter.Send(new ServiceMessage("Start"), "Service");
			MessagingCenter.Send(new LogMessage("开始后台服务"), "Log");
		}

		public static void StopService()
		{
			Environment.IsSvrStart = false;
			MessagingCenter.Send(new ServiceMessage("Stop"), "Service");
			MessagingCenter.Send(new LogMessage("停止后台服务"), "Log");
		}

		public static async Task LoadConfig()
		{
			await Remote.fgo_member();
			MessagingCenter.Send(new LogMessage($"服务器获取成功 [{Constant.DataVer}]"), "Log");

			var mstc = Database.GetCollection("Config").FindOne(Query.EQ("name", "mst"));
			if (mstc == null || mstc["ver"] != Constant.DataVer)
			{
				Database.GetCollection("Config").Delete(Query.All());
				Database.GetCollection("Config").Insert(new BsonDocument { ["_id"] = ObjectId.NewObjectId(), ["name"] = "mst", ["ver"] = Constant.DataVer });

				await Network.GetBZip2FileAsync($"https://line3-patch-fate.bilibiligame.net/1200/MasterDataCachesOutput/{Constant.DataVer}/data.bin", "MstData");
			}

			using (var file = File.OpenRead(DependencyService.Get<ISystem>().GetLocalFilePath("MstData")))
			{
				var mst = Serializer.Deserialize<Mst>(file);
				Config.MstClass = Serializer.Deserialize<MstClassArray>(new MemoryStream(mst.items.MstClass)).Items;
				Config.MstEquip = Serializer.Deserialize<MstEquipArray>(new MemoryStream(mst.items.MstEquip)).Items;
				Config.MstEventQuest = Serializer.Deserialize<MstEventQuestArray>(new MemoryStream(mst.items.MstEventQuest)).Items;
				Config.MstItem = Serializer.Deserialize<MstItemArray>(new MemoryStream(mst.items.MstItem)).Items;
				Config.MstQuestPhase = Serializer.Deserialize<MstQuestPhaseArray>(new MemoryStream(mst.items.MstQuestPhase)).Items;
				Config.MstQuestPhaseDetail = Serializer.Deserialize<MstQuestPhaseDetailArray>(new MemoryStream(mst.items.MstQuestPhaseDetail)).Items;
				Config.MstSvt = Serializer.Deserialize<MstSvtArray>(new MemoryStream(mst.items.MstSvt)).Items;
				Config.MstSvtLimit = Serializer.Deserialize<MstSvtLimitArray>(new MemoryStream(mst.items.MstSvtLimit)).Items;
				Config.MstWar = Serializer.Deserialize<MstWarArray>(new MemoryStream(mst.items.MstWar)).Items;
				Config.MstSpot = Serializer.Deserialize<MstSpotArray>(new MemoryStream(mst.items.MstSpot)).Items;
				Config.MstQuest = Serializer.Deserialize<MstQuestArray>(new MemoryStream(mst.items.MstQuest)).Items;

				Config.MstQuest.ForEach(i => i.Spot = Config.MstSpot.Single(e => e.Id == i.SpotId));
				Config.MstQuest.ForEach(i => i.WarName = Config.MstWar.Single(e => e.Id == i.Spot.WarId).Name);
			}
		}

		public static async Task RunTask()
		{
			if (Environment.BattleTask.Any())
			{
				var task = Environment.BattleTask.First();
				Environment.BattleTask.RemoveAt(0);

				var qu = Config.MstQuest.Single(i => i.Id == task.QuestID);
				if (qu.ActConsume == 0 || Config.MstQuestPhaseDetail.SingleOrDefault(i => i.QuestId == task.QuestID && i.Phase == task.QuestPhase)?.ActConsume == 0)
				{
					await task.Game.fgo_battlescenario(task.QuestID.ToString(), task.QuestPhase.ToString());

					await Task.Delay(new Random().Next(5 * 1000, 10 * 1000));

					await task.Game.fgo_home();
					MessagingCenter.Send(new LogMessage("完成战斗"), "Log");
					return;
				}

				var bi = await task.Game.fgo_battlesetup(task.QuestID.ToString(), task.QuestPhase.ToString(), task.DeckID, task.Game.Follower.First().userId.ToString(), 1);

				if (bi.battleResCode != "00")
				{
					var jo = JObject.Parse(bi.battleExtra);
					//if (jo["detail"].ToString().Contains("AP不足"))
					//{
					//	return;
					//}
					//if (jo["detail"].ToString().Contains("从者数量"))
					//{
					//	return;
					//}

					MessagingCenter.Send(new LogMessage(task.Game, jo["detail"].ToString()), "Log");
					return;
				}

				MessagingCenter.Send(new LogMessage(task.Game, "战斗" + bi.battleId + "掉落："), "Log");
				foreach (var dic in bi.dropInfo)
				{
					MessagingCenter.Send(new LogMessage($"{Helper.Extensions.GetItemName(dic.Key)} x {dic.Value}"), "Log");
				}

				await Task.Delay(new Random().Next(90 * 1000, 120 * 1000));

				await task.Game.fgo_battleresult(bi);

				await task.Game.fgo_home();
				MessagingCenter.Send(new LogMessage(task.Game, $"完成战斗{bi.battleId}"), "Log");
			}
		}
	}
}