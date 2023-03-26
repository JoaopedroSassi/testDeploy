using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class Todo
    {
        public int Id { get; set; }
		public string? Title { get; set; }
		public bool IsComplete { get; set; }

		public Todo(int id, string? title, bool isComplete)
		{
			Id = id;
			Title = title;
			IsComplete = isComplete;
		}
	}
}