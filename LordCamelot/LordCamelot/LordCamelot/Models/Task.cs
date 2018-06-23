using System;
using System.Collections.Generic;
using System.Text;
using LordCamelot.Services;

namespace LordCamelot.Models
{
    public class BattleTask
    {
	    public Game Game { get; set; }

	    public int QuestID { get; set; }

	    public int QuestPhase { get; set; }

	    public string DeckID { get; set; }
    }
}
