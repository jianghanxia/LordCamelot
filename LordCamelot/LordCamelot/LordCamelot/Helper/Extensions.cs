using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using LordCamelot.Models;
using LordCamelot.Services;
using LordCamelot.ViewModels;
using Newtonsoft.Json;
using Xamarin.Forms.Internals;

namespace LordCamelot.Helper
{
	public static class Extensions
    {
	    public static void UpdateData(Game game, string json)
	    {
		    var ho = JsonConvert.DeserializeObject<ActionResponse>(json);

		    if (ho.userItem != null)
		    {
			    foreach (var item in ho.userItem)
			    {
				    if (game.Item.Any(i => i.itemId == item.itemId))
				    {
					    var it = game.Item.Single(i => i.itemId == item.itemId);
					    it.num = item.num;
				    }
				    else
				    {
					    game.Item.Add(item);
				    }
			    }
		    }

		    if (ho.userSvt != null)
		    {
			    foreach (var item in ho.userSvt)
			    {
				    if (game.Svt.Any(i => i.id == item.id))
				    {
					    var it = game.Svt.Single(i => i.id == item.id);
					    it.limitCount = item.limitCount;
						it.lv = item.lv;
						it.exp = item.exp;
						it.adjustHp = item.adjustHp;
						it.adjustAtk = item.adjustAtk;
						it.status = item.status;
						it.equipTargetId1 = item.equipTargetId1;
						it.isLock = item.isLock;
						it.hp = item.hp;
						it.atk = item.atk;
					}
				    else
				    {
					    game.Svt.Add(item);
				    }
			    }
			}

		    if (ho.userDeck != null)
		    {
				game.Deck = new ObservableCollection<UserDeck>(ho.userDeck);
			    game.Deck.ForEach(i => i.Svt.ForEach(w => w.Servant = game.Svt.Single(t => t.id == w.userSvtId)));
			}

		    if (ho.userQuest != null)
		    {
				game.Quest = new ObservableCollection<UserQuest>(ho.userQuest);
			}

		    if (ho.userPresentBox != null)
		    {
				game.PresentBox = new ObservableCollection<UserPresentBox>(ho.userPresentBox);
			}

		    if (ho.userFollower != null)
		    {
				game.Follower = new ObservableCollection<FollowerInfo>(ho.userFollower.First().followerInfo);
			}

		    if (ho.userGame != null)
		    {
			    game.UserGame = ho.userGame.First();
		    }

			if (ho.tblUserGame != null)
		    {
			    game.UserGame.friendPoint = ho.tblUserGame.First().friendPoint;
		    }
		}

	    public static void ReplacedData(Game game, string json)
	    {
		    var ho = JsonConvert.DeserializeObject<ActionResponse>(json);

		    if (ho.userItem != null)
		    {
			    game.Item = new ObservableCollection<UserItem>(ho.userItem);
		    }

		    if (ho.userSvt != null)
		    {
			    game.Svt = new ObservableCollection<UserServant>(ho.userSvt);
		    }

		    if (ho.userDeck != null)
		    {
			    game.Deck = new ObservableCollection<UserDeck>(ho.userDeck);
			    game.Deck.ForEach(i => i.Svt.ForEach(w => w.Servant = game.Svt.Single(t => t.id == w.userSvtId)));
		    }

		    if (ho.userQuest != null)
		    {
			    game.Quest = new ObservableCollection<UserQuest>(ho.userQuest);
		    }

		    if (ho.userGame != null)
		    {
			    game.UserGame = ho.userGame.First();
		    }

		    if (ho.tblUserGame != null)
		    {
			    game.UserGame.friendPoint = ho.tblUserGame.First().friendPoint;
		    }

			if (ho.userGacha != null)
		    {
			    game.Gacha = new ObservableCollection<UserGacha>(ho.userGacha);
		    }

		    if (ho.userPresentBox != null)
		    {
			    game.PresentBox = new ObservableCollection<UserPresentBox>(ho.userPresentBox);
		    }

		    if (ho.userFollower != null)
		    {
			    game.Follower = new ObservableCollection<FollowerInfo>(ho.userFollower.First().followerInfo);
		    }
	    }

	    public static string GetItemName(string itemkey)
	    {
		    if (Runtime.Config.MstItem.Any(i => i.Id.ToString() == itemkey))
		    {
			    return Runtime.Config.MstItem.Single(i => i.Id.ToString() == itemkey).Name;

		    }
		    else if (Runtime.Config.MstSvt.Any(i => i.Id.ToString() == itemkey))
		    {
			    return Runtime.Config.MstSvt.Single(i => i.Id.ToString() == itemkey).Name;
		    }
		    else
		    {
			    return itemkey.ToString();
		    }
	    }

	    public static string ToSvtClassName(this int type)
	    {
		    var name = new[] {"", "SABER", "ARCHER", "LANCER", "RIDER", "CASTER", "ASSASSIN", "BERSERKER", "Shielder", "Ruler", "", "Avenger"};
		    return name[type];
	    }
    }
}
