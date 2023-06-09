﻿using API.Entities;

namespace API
{
	public partial class Board
	{
		public Board()
		{
			Comment = new HashSet<Comment>();
		}

		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public string Content { get; set; } = null!;
		public string Register { get; set; } = null!;
		public DateTime RegisterDate { get; set; }

		public virtual Member RegisterNavigation { get; set; } = null!;
		public virtual ICollection<Comment> Comment { get; set; }
	}
}
