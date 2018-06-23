using System;
using System.Collections.Generic;
using System.Text;
using LiteDB;

namespace LordCamelot.Models
{
    public class User
    {
	    public ObjectId Id { get; set; } = ObjectId.NewObjectId();

		public string Name { get; set; }
	    public string Password { get; set; }
	    public bool IsIOS { get; set; }
    }
}
