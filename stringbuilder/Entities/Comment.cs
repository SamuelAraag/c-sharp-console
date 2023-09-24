using System;
namespace Stringbuilder.Entities
{
	public class Comment
	{
		public Comment()
		{
		}

		public string Text { get; set; }

        public Comment(string text)
        {
            Text = text;
        }
    }
}

