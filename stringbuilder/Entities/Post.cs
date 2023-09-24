using System;
using System.Text;

namespace Stringbuilder.Entities
{
	public class Post
	{
		public Post()
		{
		}

		public DateTime Moment { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public int Likes { get; set; }
		public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

		public void AddComment(Comment comment)
		{
			Comments.Add(comment);
		}

		public void RemoveComment(Comment comment)
		{
			Comments.Remove(comment);
		}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
			sb.AppendLine(Title);
			sb.Append(Likes);
			sb.Append(" Likes - ");
			sb.AppendLine(Moment.ToString("dd/MM/yyyy"));
			sb.AppendLine(Content);
			sb.AppendLine("Comments: ");

			foreach(var comment in Comments)
			{
				sb.AppendLine(comment.Text);
			}


            return sb.ToString();
        }
    }
}

