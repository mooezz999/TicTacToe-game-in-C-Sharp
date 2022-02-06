using System;

namespace ticTacToe
{
    internal class Program
    {
        public static int a = 0;
        
        static string[,] my2DArray = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        public static void display()
        {
            Console.Clear();
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {

                    Console.Write(" " + my2DArray[i, j] + " |");

                }
                Console.WriteLine();
            }
        }
        static bool bool1=false;
        static bool bool2 = false; 
        public static void changeFirst(int num)
        {
            switch (num)
            {
                case 1: if(int.TryParse(my2DArray[0,0],out a))
                    {
                        my2DArray[0, 0] = "O";
                        bool1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 2:
                    if (int.TryParse(my2DArray[0, 1], out a))
                    {
                        my2DArray[0, 1] = "O";
                        bool1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 3:
                    if (int.TryParse(my2DArray[0, 2], out a))
                    {
                        my2DArray[0, 2] = "O";
                        bool1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 4:
                    if (int.TryParse(my2DArray[1, 0], out a))
                    {
                        my2DArray[1, 0] = "O";
                        bool1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 5:
                    if (int.TryParse(my2DArray[1, 1], out a))
                    {
                        my2DArray[1, 1] = "O";
                        bool1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 6:
                    if (int.TryParse(my2DArray[1, 2], out a))
                    {
                        my2DArray[1, 2] = "O";
                        bool1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 7:
                    if (int.TryParse(my2DArray[2, 0], out a))
                    {
                        my2DArray[2, 0] = "O";
                        bool1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 8:
                    if (int.TryParse(my2DArray[2, 1], out a))
                    {
                        my2DArray[2, 1] = "O";
                        bool1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;

                case 9:
                    if (int.TryParse(my2DArray[2, 2], out a))
                    {
                        my2DArray[2, 2] = "O";
                        bool1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong number submitted");
                    break;

            }
        }

        public static void changeSecond(int num)
        {
            switch (num)
            {
                case 1:
                    if (int.TryParse(my2DArray[0, 0], out a))
                    {
                        my2DArray[0, 0] = "X";
                        bool2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 2:
                    if (int.TryParse(my2DArray[0, 1], out a))
                    {
                        my2DArray[0, 1] = "X";
                        bool2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 3:
                    if (int.TryParse(my2DArray[0, 2], out a))
                    {
                        my2DArray[0, 2] = "X";
                        bool2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 4:
                    if (int.TryParse(my2DArray[1, 0], out a))
                    {
                        my2DArray[1, 0] = "X";
                        bool2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 5:
                    if (int.TryParse(my2DArray[1, 1], out a))
                    {
                        my2DArray[1, 1] = "X";
                        bool2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 6:
                    if (int.TryParse(my2DArray[1, 2], out a))
                    {
                        my2DArray[1, 2] = "X";
                        bool2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 7:
                    if (int.TryParse(my2DArray[2, 0], out a))
                    {
                        my2DArray[2, 0] = "X";
                        bool2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                case 8:
                    if (int.TryParse(my2DArray[2, 1], out a))
                    {
                        my2DArray[2, 1] = "X";
                        bool2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;

                case 9:
                    if (int.TryParse(my2DArray[2, 2], out a))
                    {
                        my2DArray[2, 2] = "X";
                        bool2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Filed is already occupied.");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong number submitted");
                    break;

            }
        }

        
        static bool won = false;
        public static void checkIfWon()
        {
            //check rows
            for(int i = 0; i < my2DArray.GetLength(0); i++)
            {
                int counta = 0;
                int countb = 0;
                for(int j=0;j<my2DArray.GetLength(1); j++)
                {
                    if (my2DArray[i, j] == "O")
                        counta++;
                    if (my2DArray[i, j] == "X")
                        countb++;
                }
                if (counta == 3)
                {
                    won = true;
                    Console.WriteLine("Player 1 won");
                    break;
                }
                if (countb == 3)
                {
                    won = true;
                    Console.WriteLine("Player 2 won");
                    break;
                }
            }

            //check columns
            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                int counta = 0;
                int countb = 0;
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    if (my2DArray[j, i] == "O")
                        counta++;
                    if (my2DArray[j, i] == "X")
                        countb++;
                }
                if (counta == 3)
                {
                    won = true;
                    Console.WriteLine("Player 1 won");
                    break;
                }
                if (countb == 3)
                {
                    won = true;
                    Console.WriteLine("Player 2 won");
                    break;
                }
            }
            int countaa = 0;
            int countbb = 0;
            //check diagonals
            for (int i = 0; i < 3; i++)
            {
                        if (my2DArray[i, i] == "O")
                            countaa++;
                        if (my2DArray[i, i] == "X")
                            countbb++;  
            }
            if (countaa == 3)
            {
                won = true;
                Console.WriteLine("Player 1 won");
                
            }
            if (countbb == 3)
            {
                won = true;
                Console.WriteLine("Player 2 won");
                
            }
            
            int countaaa = 0;
            int countbbb = 0;
            for(int i = 0,j=2;i < 3; i++,j--)
            {
               
                    if (my2DArray[i, j] == "O")
                        countaaa++;
                    if (my2DArray[i, j] == "X")
                        countbbb++;
                
            }
            if (countaaa == 3)
            {
                won = true;
                Console.WriteLine("Player 1 won");
            }
            if (countbbb == 3)
            {
                won = true;
                Console.WriteLine("Player 2 won");

            }
            

        }


        public static void checkDraw()
        {
         

            int count = 0;
            int a;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!int.TryParse(my2DArray[i, j], out a))
                        count++;
                }
            }
            if (count == 9)
            {
                Console.WriteLine("Drew");
                won = true;
            }
        }
            static void Main(string[] args)
        {
        My_label:
            display();
            while (!won)
            {
                while (!bool1)
                {
                    Console.WriteLine("Player 1: choose your field: ");
                    string first = Console.ReadLine();
                    if (int.TryParse(first, out a))
                    {
                        changeFirst(a);
                        display();
                        checkIfWon();
                        checkDraw();
                        bool2 = false;
                       
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid field.");
                    }
                   
                }

                while (!bool2)
                {

                    if (!won)
                    {
                        Console.WriteLine("Player 2: choose your field: ");
                        string second = Console.ReadLine();
                        if (int.TryParse(second, out a))
                        {
                            changeSecond(a);
                            display();
                            checkIfWon();
                            checkDraw();
                            bool1 = false;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid field.");
                        }
                    }
                }

            }
             string[,] my2DArrayF = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            my2DArray = my2DArrayF;
            display();
            won = false;
                bool1 = false;
                bool2 = false;
                goto My_label;
            
            
        }
    }
}
