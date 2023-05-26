// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// namespace was how we organized code - .NET 5 and earlier
// string name = "Jordan"

Book windInTheWillows = new Book("Kenneth Grahame", "The Wind in the Willows");
//brand new empty instance of a book

// windInTheWillows.Author = "Kenneth Grahame";
windInTheWillows.PageNumbers = 272;
windInTheWillows.ISBN = 068971310;
// windInTheWillows.Title = "The Wind in the Willows";

Book theCatInTheHat = new Book ("Dr. Seuss", "The Cat in the Hat");

// theCatInTheHat.Author = "Dr. Seuss";
// theCatInTheHat.Title = "The Cat in the Hat";
theCatInTheHat.PublishedDate = new DateTime(1957, 3, 12);

Book theCuriousIncidentOfTheDogInTheNightTime = new Book("Mark Haddon", "The Curious Incident of the Dog in the Night-Time"){
    // Author = "Mark Haddon",
    PublishedDate = new DateTime(2003, 5, 1)
    // Title = "The Curious Incident of the Dog in the Night-Time"
};

// List<Book> libraryInventory = new List<Book>{
//     windInTheWillows, theCatInTheHat, theCuriousIncidentOfTheDogInTheNightTime
// };
//groups together our 3 separate instances of Book

Library EastLibrary = new Library();

EastLibrary.Address = "123 East Street";
// EastLibrary.LibraryInventory.Add(windInTheWillows);

Library WestLibrary = new Library();

WestLibrary.Address = "789 West Street";
// WestLibrary.LibraryInventory.Add(theCatInTheHat);

EastLibrary.MaxNumberOfBooks = 1;
WestLibrary.MaxNumberOfBooks = 2;

WestLibrary.AddBook(theCuriousIncidentOfTheDogInTheNightTime);
EastLibrary.AddBook(windInTheWillows);
EastLibrary.AddBook(theCatInTheHat);