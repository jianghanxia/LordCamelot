using System;
using System.Collections.Generic;
namespace FGOAutoScript
{
    public struct PlayerStatus
    {
        public string uid;
        public string name;
        public int actRecoverAt;
        public int actMax;
        public int lv;
        public int exp;
        public int qp;
        public int costMax;
        public int freeStone;
        public int chargeStone;
        public Dictionary<string, string> deckList;
        public Dictionary<string, int> itemList;
        public Dictionary<string, string> followerInfo;
        public Dictionary<string, FollowerServant[]> followerList;
        public Dictionary<string, PlayerServant> servantList;
    }

    public struct FollowerServant
    {
        public string equipId;
        public bool equipMax;
    }

    public struct PlayerServant
    {
        public bool isLock;
        public string svtId;
    }

    public struct BattleInfo
    {
        public string battleId;
        public int rewardQp;
        public int rewardExp;
        public Dictionary<string, int> dropInfo;
        public string battleResCode;
        public string battleExtra;
    }
}
