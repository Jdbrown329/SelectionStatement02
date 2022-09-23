using System.Dynamic;
{
    Console.WriteLine("what is your favorite school subject?");

    var subject = Console.ReadLine();

    switch (subject.ToLower())
    {
        case "music":
            Console.WriteLine("Music soothes the soul!");
            break;
        case "science":
            Console.WriteLine("I used to want to be a botanist! Follow your dreams");
            break;
        case "history":
            Console.WriteLine("Mr. Peterson was my favorite history teacher ever!, I hope your teacher is good like him. ");
            break;
        case "math":
            Console.WriteLine(  "I used to love Trigonometry! There is so much in math to learn!");
            break;
        case "language":
            Console.WriteLine("Ahhh, We have a polygot on our hands!");
            break;
            default:
            Console.WriteLine("Well that's good but my limited experience with that subject, leaves me with very little to say");
            break;
    }
}


