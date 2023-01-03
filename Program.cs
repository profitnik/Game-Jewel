Console.CursorVisible = false;

char[,] map =
{
    {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#','X',' ',' ',' ',' ',' ','X',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ','#',' ','X',' ',' ',' ','#'},
    {'#',' ','#','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
    {'#',' ',' ','#',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#',' ',' ','#',' ','#','#','#','#',' ',' ',' ','#',' ',' ','#','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#'},
    {'#',' ',' ','#',' ',' ','X',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#'},
    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#',' ','X',' ','#'},
    {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#',' ','#'},
    {'#',' ','X',' ',' ',' ',' ',' ',' ','X',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
    {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
};

int userX = 7, userY = 15;
char[] userBag = new char[1];




while (true)
{
    Console.SetCursorPosition(0, 20);
    Console.Write("Bag of player:");
    for (int i = 0; i < userBag.Length; i++)
    {
        Console.Write(" "+userBag[i]);
    }
    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            Console.Write(map[i, j]);
        }
        Console.WriteLine();
    }
    
    Console.SetCursorPosition(userY, userX);
    Console.Write('@');
    ConsoleKeyInfo charKey = Console.ReadKey();
    switch (charKey.Key)
    {
        case ConsoleKey.UpArrow:
            if (map[userX - 1, userY] != '#')
            {
                //map[userX-1, userY] = '@';
                //map[userX, userY] = ' ';
                userX--;
            }
            break;
        case ConsoleKey.DownArrow:
            if (map[userX + 1, userY] != '#')
            {
                //map[userX+1, userY] = '@';
                //map[userX, userY] = ' ';
                userX++;
            }
            break;
        case ConsoleKey.LeftArrow:
            if (map[userX, userY-1] != '#')
            {
                //map[userX, userY-1] = '@';
                //map[userX, userY] = ' ';
                userY--;
            }
            break;
        case ConsoleKey.RightArrow:
            if (map[userX, userY + 1] != '#')
            {
                //map[userX, userY + 1] = '@';
                //map[userX, userY] = ' ';
                userY++;
            }
            break;

    }
    if (map[userX,userY] == 'X')
    {
        map[userX, userY] = 'o';
        char[] tempUserBar = new char[userBag.Length + 1];
        for (int i = 0; i < userBag.Length; i++)
        {
            tempUserBar[i] = userBag[i];
        }
        tempUserBar[userBag.Length - 1] = 'X';
        userBag = tempUserBar;
    }
    //Console.ReadKey();
    Console.Clear();

}