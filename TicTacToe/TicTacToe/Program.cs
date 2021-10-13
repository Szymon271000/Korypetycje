using System;

class Program
{
    private char winChar;

    public char winPerson
    {
        get { return winChar; }
        set { winChar = value; }
    }

    private bool hasWon;

    public bool isWin
    {
        get { return hasWon; }
        set { hasWon = value; }
    }

    private bool isX;

    public bool isY
    {
        get { return isX; }
        set { isX = value; }
    }
    //tutaj!!
    //private char boxone, boxtwo, boxthree, boxfour, boxfive, boxsix, boxseven, boxeight, boxnine;

    public char[,] MyBoxes = new char[3, 3];
    // tutaj sie powinno skasowac
    /*public char box1
    {
        get { return boxone; }
        set { boxone = value; }
    }

    public char box2
    {
        get { return boxtwo; }
        set { boxtwo = value; }
    }

    public char box3
    {
        get { return boxthree; }
        set { boxthree = value; }
    }

    public char box4
    {
        get { return boxfour; }
        set { boxfour = value; }
    }

    public char box5
    {
        get { return boxfive; }
        set { boxfive = value; }
    }

    public char box6
    {
        get { return boxsix; }
        set { boxsix = value; }
    }

    public char box7
    {
        get { return boxseven; }
        set { boxseven = value; }
    }

    public char box8
    {
        get { return boxeight; }
        set { boxeight = value; }
    }

    public char box9
    {
        get { return boxnine; }
        set { boxnine = value; }
    }*/

    public void WriteBoard()
    {
        /*Console.WriteLine(" {0} | {1} | {2} ", boxone, boxtwo, boxthree);
        Console.WriteLine(" --------- ");
        Console.WriteLine(" {0} | {1} | {2} ", boxfour, boxfive, boxsix);
        Console.WriteLine(" --------- ");
        Console.WriteLine(" {0} | {1} | {2} ", boxseven, boxeight, boxnine);*/
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" " + MyBoxes[i, j] + " ");
                if (j < 2)
                {
                    Console.Write("|");
                }
            }
            if (i < 2)
            {
                Console.Write("\n");
                Console.Write("------------");
            }
            Console.WriteLine();
        }
    }

    public void CheckWin()
    {
        // 123 (i + j <= 2), 456, 789 (i + j >= 2), 147 (i + j <= 2), 258, 369 (i + j >= 2), 159 (i ==j), 357 (i + j == 2)
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if ((i == j) && (MyBoxes[i, j] == 'X'))
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                else if ((i + j == 2) && (MyBoxes[i, j] == 'X'))
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                else if ((i + j <= 2) && (MyBoxes[i, j] == 'X'))
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                else if ((i + j >= 2) && (MyBoxes[i, j] == 'X'))
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                else if ((i == 1) && (MyBoxes[i, j] == 'X'))//niepewne
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                else if ((j == 1) && (MyBoxes[i, j] == 'X'))//niepewne
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                if ((i == j) && (MyBoxes[i, j] == 'Y'))
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                else if ((i + j == 2) && (MyBoxes[i, j] == 'Y'))
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                else if ((i + j <= 2) && (MyBoxes[i, j] == 'Y'))
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                else if ((i + j >= 2) && (MyBoxes[i, j] == 'Y'))
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                else if ((i == 1) && (MyBoxes[i, j] == 'Y'))//niepewne
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
                else if ((j == 1) && (MyBoxes[i, j] == 'Y'))//niepewne
                {
                    isWin = true;
                    winPerson = 'X';
                    return;
                }
            }
        }//tutaj dodalem
         //tutaj!!
        /*if ((box1 == 'X') && (box2 == 'X') && (box3 == 'X'))
        {
            isWin = true;
            winPerson = 'X';
            return;
        }
        if ((box4 == 'X') && (box5 == 'X') && (box6 == 'X'))
        {
            isWin = true;
            winPerson = 'X';
            return;
        }
        if ((box7 == 'X') && (box8 == 'X') && (box9 == 'X'))
        {
            isWin = true;
            winPerson = 'X';
            return;
        }
        if ((box1 == 'X') && (box4 == 'X') && (box7 == 'X'))
        {
            isWin = true;
            winPerson = 'X';
            return;
        }
        if ((box2 == 'X') && (box5 == 'X') && (box8 == 'X'))
        {
            isWin = true;
            winPerson = 'X';
            return;
        }
        if ((box3 == 'X') && (box6 == 'X') && (box9 == 'X'))
        {
            isWin = true;
            winPerson = 'X';
            return;
        } // 159, 357
        if ((box1 == 'X') && (box5 == 'X') && (box9 == 'X'))
        {
            isWin = true;
            winPerson = 'X';
            return;
        }
        if ((box3 == 'X') && (box5 == 'X') && (box7 == 'X'))
        {
            isWin = true;
            winPerson = 'X';
            return;
        }
        if ((box1 == 'Y') && (box2 == 'Y') && (box3 == 'Y'))
        {
            isWin = true;
            winPerson = 'Y';
            return;
        }
        if ((box4 == 'Y') && (box5 == 'Y') && (box6 == 'Y'))
        {
            isWin = true;
            winPerson = 'Y';
            return;
        }
        if ((box7 == 'Y') && (box8 == 'Y') && (box9 == 'Y'))
        {
            isWin = true;
            winPerson = 'Y';
            return;
        }
        if ((box1 == 'Y') && (box4 == 'Y') && (box7 == 'Y'))
        {
            isWin = true;
            winPerson = 'Y';
            return;
        }
        if ((box2 == 'Y') && (box5 == 'Y') && (box8 == 'Y'))
        {
            isWin = true;
            winPerson = 'Y';
            return;
        }
        if ((box3 == 'Y') && (box6 == 'Y') && (box9 == 'Y'))
        {
            isWin = true;
            winPerson = 'Y';
            return;
        } // 159, 357
        if ((box1 == 'Y') && (box5 == 'Y') && (box9 == 'Y'))
        {
            isWin = true;
            winPerson = 'Y';
            return;
        }
        if ((box3 == 'Y') && (box5 == 'Y') && (box7 == 'Y'))
        {
            isWin = true;
            winPerson = 'Y';
            return;
        }
    }*/
    }

    public void NotVacantError()
    {
        _error = true;
        Console.WriteLine();
        Console.WriteLine("Error: box not vacant!");
        Console.WriteLine("Press any key to try again..");
        Console.ReadKey();
        return;
    }

    public void DisplayLoss()
    {
        Console.WriteLine();
        Console.WriteLine("No one won.");
        Console.ReadKey();
        Environment.Exit(1);
    }

    private bool hasError;

    public bool _error
    {
        get { return hasError; }
        set { hasError = value; }
    }

    static void Main()
    {
        int moveCount = 0; // check loss
        char askMove; // display X or Y in question
        int selTemp;
        Program prog = new Program();
        prog._error = false;
        //
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                prog.MyBoxes[i, j] = ' ';
            }
        }
        /*prog.box1 = ' ';
        prog.box2 = ' ';
        prog.box3 = ' ';
        prog.box4 = ' ';
        prog.box5 = ' ';
        prog.box6 = ' ';
        prog.box7 = ' ';
        prog.box8 = ' ';
        prog.box9 = ' ';
        prog.isY = true;*/
        Console.WriteLine(" -- Tic Tac Toe -- ");
        Console.Clear();
        //tutaj zmienilem
        while (!prog.isWin)
        {
            if (moveCount == 9)
            {
                prog.DisplayLoss();
            }
            if ((prog.isY) == true) // if is X
            {
                askMove = 'X';
            }
            else
            {
                askMove = 'Y';
            }
            Console.Clear();
            prog.WriteBoard();
            Console.WriteLine();
            Console.WriteLine("What box do you want to place {0} in? (1-9)", askMove);
            Console.Write("> ");
            selTemp = int.Parse(Console.ReadLine());
            int a = selTemp - 1;
            int b = a / 3;
            int c = a % 3;

            if (prog.MyBoxes[b, c] == ' ')
            {
                prog.MyBoxes[b, c] = askMove;
                moveCount++;
            }
            else if (prog.MyBoxes[b, c] != ' ')
            {
                prog.NotVacantError();
            }
            /*else
            {
                Console.WriteLine("Wrong selection entered!");
                Console.WriteLine("Press any key to try again..");
                Console.ReadKey();
                prog._error = true;
                break;
            }*/
            if (prog._error)
            {
                prog.CheckWin(); // if error, just check win
                prog._error = !prog._error;
            }
            else
            {
                prog.isY = !prog.isY; // flip boolean
                prog.CheckWin();
            }
            //tutaj skasowac!!
            /*switch (selTemp)
            {
                case 1:

                    break;
                case 2:
                    if (prog.box2 == ' ')
                    {
                        prog.box2 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 3:
                    if (prog.box3 == ' ')
                    {
                        prog.box3 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 4:
                    if (prog.box4 == ' ')
                    {
                        prog.box4 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 5:
                    if (prog.box5 == ' ')
                    {
                        prog.box5 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 6:
                    if (prog.box6 == ' ')
                    {
                        prog.box6 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 7:
                    if (prog.box7 == ' ')
                    {
                        prog.box7 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 8:
                    if (prog.box8 == ' ')
                    {
                        prog.box8 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;
                case 9:
                    if (prog.box9 == ' ')
                    {
                        prog.box9 = askMove;
                        moveCount++;
                    }
                    else
                    {
                        prog.NotVacantError();
                    }
                    break;*/
            //default:
            /*Console.WriteLine("Wrong selection entered!");
            Console.WriteLine("Press any key to try again..");
            Console.ReadKey();
            prog._error = true;
            break;*/
            /* }
                 if (prog._error)
                 {
                     prog.CheckWin(); // if error, just check win
                     prog._error = !prog._error;
                 }
                 else
                 {
                     prog.isY = !prog.isY; // flip boolean
                     prog.CheckWin();
                 }
             }*/
            Console.Clear();
            prog.WriteBoard();
            Console.WriteLine();
            Console.WriteLine("The winner is {0}!", prog.winPerson);
            Console.ReadKey();
        }
    }
}