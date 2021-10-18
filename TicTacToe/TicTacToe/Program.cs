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

    public char[,] MyBoxes = new char[3, 3];
    
    public void WriteBoard()
    {
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
        int licznikX;
        int licznikY;
        for (int i = 0; i < 3; i++)
        {
            licznikX = 0;
            licznikY = 0;
            for (int j = 0; j < 3; j++)
            {
                if(MyBoxes[i, j] == 'X')
                {
                    licznikX++;
                }
                else if(MyBoxes[i, j] == 'Y')
                {
                    licznikY++;
                }
            }
            if(licznikX == 3)
            {
                isWin = true;
                winPerson = 'X';
                return;
            }
            else if(licznikY == 3)
            {
                isWin = true;
                winPerson = 'Y';
                return;
            }
        }

        for (int i = 0; i < 3; i++)
        {
            licznikX = 0;
            licznikY = 0;
            for (int j = 0; j < 3; j++)
            {
                if (MyBoxes[j, i] == 'X')
                {
                    licznikX++;
                }
                else if (MyBoxes[j, i] == 'Y')
                {
                    licznikY++;
                }
            }
            if (licznikX == 3)
            {
                isWin = true;
                winPerson = 'X';
                return;
            }
            else if (licznikY == 3)
            {
                isWin = true;
                winPerson = 'Y';
                return;
            }
        }

        licznikX = 0;
        licznikY = 0;
        for(int i = 0; i < 3; i++)
        {
            if(MyBoxes[i, i] == 'X')
            {
                licznikX++;
            }
            else if(MyBoxes[i, i] == 'Y')
            {
                licznikY++;
            }
        }
        if (licznikX == 3)
        {
            isWin = true;
            winPerson = 'X';
            return;
        }
        else if (licznikY == 3)
        {
            isWin = true;
            winPerson = 'Y';
            return;
        }

        licznikX = 0;
        licznikY = 0;
        for (int i = 0; i < 3; i++)
        {
            if (MyBoxes[i, 2 - i] == 'X')
            {
                licznikX++;
            }
            else if (MyBoxes[i, 2 - i] == 'Y')
            {
                licznikY++;
            }
        }
        if (licznikX == 3)
        {
            isWin = true;
            winPerson = 'X';
            return;
        }
        else if (licznikY == 3)
        {
            isWin = true;
            winPerson = 'Y';
            return;
        }
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

        Console.WriteLine(" -- Tic Tac Toe -- ");
        Console.Clear();
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
            Console.Clear();
            prog.WriteBoard();
            if(prog.isWin)
            {
                Console.WriteLine("The winner is {0}!", prog.winPerson);
                Console.ReadKey();
                return;
            }    
        }
    }
}