// See https://aka.ms/new-console-template for more information
Source source = new Source ("None Were with Him", "http://www.churchofjesuschrist.org");

Console.WriteLine(source.Stringify());

Quote holland = new Quote("Elder Holland", "Because Jesus...");

Console.WriteLine(holland.GetQuote());

Board quoteboard = new Board();
quoteboard.AddQuote(holland);
quoteboard.ShowQuotes();
quoteboard.FindQuotesByAuthor("holland");

//_board.GetRandomQuote();

Menu menu = new Menu(_board);
_menu.Display();