using System;
using System.Collections.Generic;
using System.Text;

namespace LordCamelot.Models
{
	public class ActionResponse
	{
		public List<TblUserGame> tblUserGame { get; set; }
		public List<UserItem> userItem { get; set; }
		public List<UserServant> userSvt { get; set; }
		public List<UserDeck> userDeck { get; set; }
		public List<UserQuest> userQuest { get; set; }
		public List<UserGame> userGame { get; set; }
		public List<UserGacha> userGacha { get; set; }
		public List<UserPresentBox> userPresentBox { get; set; }
		public List<UserFollower> userFollower { get; set; }
	}
}
