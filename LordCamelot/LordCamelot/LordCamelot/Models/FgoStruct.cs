using System;
using System.Collections.Generic;
using System.Linq;
using LordCamelot.Helper;
using LordCamelot.Services;
using Newtonsoft.Json;
using Prism.Mvvm;
using Xamarin.Forms;

namespace LordCamelot.Models
{
	public class Loginbonus
	{
		public int seqLogin { get; set; }
		public string message { get; set; }
		public int totalLogin { get; set; }
	}

	public struct FollowerServant
	{
		public string equipId { get; set; }
		public bool equipMax { get; set; }
	}

	public struct PlayerServant
	{
		public bool isLock { get; set; }
		public string svtId { get; set; }
	}

	public struct BattleInfo
	{
		public string battleId { get; set; }
		public int rewardQp { get; set; }
		public int rewardExp { get; set; }
		public Dictionary<string, int> dropInfo { get; set; }
		public string battleResCode { get; set; }
		public string battleExtra { get; set; }
	}

	public class UserItem
	{
		public int itemId { get; set; }
		public string num { get; set; }

		public string Name => Runtime.Config.MstItem.Single(i => i.Id == itemId).Name;
	}

	public class UserDeck
	{
		public string id { get; set; }
		public string deckNo { get; set; }
		public string name { get; set; }
		public string cost { get; set; }
		public Deckinfo deckInfo { get; set; }

		public List<DeckSvt> Svt => deckInfo.svts.Where(i => i.userSvtId != 0).ToList();
	}

	public class Deckinfo
	{
		public List<DeckSvt> svts { get; set; }
	}

	public class DeckSvt
	{
		public int id { get; set; }
		public int[] userSvtEquipIds { get; set; }
		public int userSvtId { get; set; }
		public bool isFollowerSvt { get; set; }

		public UserServant Servant { get; set; }
		public string Name => Runtime.Config.MstSvt.Single(i => i.Id == Servant.svtId).Name;
		public string ClassName => Runtime.Config.MstSvt.Single(i => i.Id == Servant.svtId).ClassId.ToSvtClassName();

		public ImageSource Pic => ImageSource.FromResource($"LordCamelot.Resources.Face.{Servant.svtId}.png");
	}

	public class UserServant
	{
		public int id { get; set; }
		public int svtId { get; set; }
		public int limitCount { get; set; }
		public int lv { get; set; }
		public int exp { get; set; }
		public int adjustHp { get; set; }
		public int adjustAtk { get; set; }
		public string status { get; set; }
		public string equipTargetId1 { get; set; }
		[JsonConverter(typeof(BoolConverter))]
		public bool isLock { get; set; }
		public int hp { get; set; }
		public int atk { get; set; }

		public int Type => Runtime.Config.MstSvt.Single(i => i.Id == svtId).Type;
		public string Name => Runtime.Config.MstSvt.Single(i => i.Id == svtId).Name;
		public int Rarity => Runtime.Config.MstSvtLimit.First(i => i.SvtId == svtId).Rarity;
	}

	public class UserQuest
	{
		public int questId { get; set; }
		public int questPhase { get; set; }
		public string clearNum { get; set; }
		public bool isEternalOpen { get; set; }
		public string expireAt { get; set; }
		public string keyExpireAt { get; set; }
		public string keyCountRemain { get; set; }
		public string isNew { get; set; }
		public string lastStartedAt { get; set; }
		public string challengeNum { get; set; }
		public string status { get; set; }

		public string Name => Runtime.Config.MstQuest.SingleOrDefault(i => i.Id == questId)?.Name ?? "";
	}

	public class UserGame : BindableBase
	{
		public string id { get; set; }
		public string userId { get; set; }
		public string name { get; set; }
		public string birthDay { get; set; }
		public int actRecoverAt { get; set; }
		public int actMax { get; set; }
		public string lv { get; set; }
		public string exp { get; set; }
		public string qp { get; set; }
		public string costMax { get; set; }
		public string mana { get; set; }
		public string sweepNum { get; set; }
		public int stone { get; set; }
		public int friendKeep { get; set; }
		public int svtKeep { get; set; }
		public int svtEquipKeep { get; set; }
		public int friendPoint { get; set; }

		public int BaseAct => FgoHelper.GetBaseAct(actRecoverAt, actMax);
	}

	public class TblUserGame
	{
		public string userId { get; set; }
		public int friendPoint { get; set; }
	}

	public class UserGacha
	{
		public string gachaId { get; set; }
		public string num { get; set; }
		public string tenNum { get; set; }

		[JsonConverter(typeof(DateTimeConverter))]
		public DateTime freeDrawAt { get; set; }
	}

	public class UserPresentBox
	{
		public string presentId { get; set; }
		public bool isAuto { get; set; }
		public string messageId { get; set; }
		public string message { get; set; }
		public string args { get; set; }
		public string objectId { get; set; }
		public string num { get; set; }
		public string lv { get; set; }
		public string status { get; set; }
	}

	public class UserFollower
	{
		public List<FollowerInfo> followerInfo { get; set; }
		public string isDelete { get; set; }
	}

	public class FollowerInfo
	{
		public long userId { get; set; }
		public int type { get; set; }
		public List<Usersvtleaderhash> userSvtLeaderHash { get; set; }
		public string userName { get; set; }
		public string userLv { get; set; }
	}

	public class Usersvtleaderhash
	{
		public string userId { get; set; }
		public string classId { get; set; }
		public string userSvtId { get; set; }
		public string svtId { get; set; }
		public string limitCount { get; set; }
		public string lv { get; set; }
		public string exp { get; set; }
		public string hp { get; set; }
		public string atk { get; set; }
		public Equiptarget equipTarget1 { get; set; }
	}

	public class Equiptarget
	{
		public string userId { get; set; }
		public string userSvtId { get; set; }
		public string svtId { get; set; }
		public string limitCount { get; set; }
		public string lv { get; set; }
		public int hp { get; set; }
		public int atk { get; set; }
	}

}
