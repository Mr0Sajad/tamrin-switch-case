var res = "";
var i = 1;
var j = 1;

while (i <= 5)
{
    Console.WriteLine("Question " + j + " (y or n) :");
    var key = Console.ReadKey().KeyChar;
    Console.WriteLine();


    switch (key)
    {
        case 'y':
            Console.WriteLine("You selected (y).");
            j = (j * 2) + 1;
            res = res + key;
            i++;
            break;

        case 'n':
            Console.WriteLine("You selected (n).");
            j = j * 2;
            res = res + key;
            i++;
            break;

        default:
            Console.WriteLine("The character entered is not valid");
            break;
    }
}
res = res.ToLower();
Console.WriteLine(res);

/*
       (1)
    n /    \ y
   (2)     (3)
  /   \   /   \
(4)  (5) (6)  (7)

 */
