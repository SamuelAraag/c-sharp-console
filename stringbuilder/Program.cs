using Stringbuilder.Entities;
using System.Globalization;

Comment c1 = new Comment("Have a nice trip");
Comment c2 = new Comment("Thats awasome");
DateTime.TryParseExact("21/06/2018", "dd/MM/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out DateTime date);

Post post = new Post(
    date,
    "Traveling to the New Zealand",
    "I'm goin to this city",
    12);

post.AddComment(c1);
post.AddComment(c2);

Console.WriteLine(post);

Console.ReadLine();