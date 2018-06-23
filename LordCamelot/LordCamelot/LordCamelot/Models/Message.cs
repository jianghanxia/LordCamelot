using LordCamelot.Services;

namespace LordCamelot.Models
{
	public class LogMessage
	{
		public string Content { get; set; }
		public Game Game { get; set; }

		public LogMessage(string message)
		{
			Content = message;
		}

		public LogMessage(Game game, string message)
		{
			Game = game;
			Content = message;
		}
	}

	public class ServiceMessage
	{
		public string Action { get; set; }

		public ServiceMessage()
		{
		}

		public ServiceMessage(string action)
		{
			Action = action;
		}
	}
}
