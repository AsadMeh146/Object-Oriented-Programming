using System;
using static System.Console;
namespace Card_Game
{
    class card
    {
        int number1=0;
        int number2=0;
        int number3=0;
        string card1 = "Hearts";
        string card2 = "Diamonds";
        string card3 = "Clubs";
        static void main_menu()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("        Welcome to card game       ");
            Console.WriteLine("***********************************");
            Console.WriteLine("Card on Left"+"\t"+"Card on middle"+"\t"+"Card on right");
        }
        static void Main(string[] args)
        {
            System.Random random = new System.Random();
            card s1 = new card();
            s1.number1 = random.Next(2,10);
            s1.number2 = random.Next(2,10);
            s1.number3 = random.Next(2,10);
            int counter = 0;
            int Loop_index = random.Next(2,10);
            bool isPlay = true;
            bool isFound = true;
            string card_1;
            string card_2;
            string card_3;
            int num_1;
            int num_2;
            int num_3;
            string card__1;
            string card__2;
            string card__3;
            int num__1;
            int num__2;
            int num__3;
            string guess_left;
            string guess_right;
            string guess_middle;
            int guess_left_num;
            int guess_middle_num;
            int guess_right_num;
            main_menu();  
            while(isFound)
            {
              Console.WriteLine(s1.number1+" of "+s1.card1+"\t"+s1.number2+" of "+s1.card2+"\t"+s1.number3+" of "+s1.card3);
              counter++;
              Console.ReadLine();
              Console.Clear();
              main_menu();
              if(Loop_index == counter)
              {
                if(counter == 4 || counter == 7 )
                {
                Console.ReadLine();
                Console.WriteLine(s1.number1+" of "+s1.card1+"\t"+s1.number2+" of "+s1.card2+"\t"+s1.number3+" of "+s1.card3);
                Console.ReadLine();
                Console.Clear();    
                Console.WriteLine("Enter the name of card on left : (Hearts/Diamonds/Clubs)");
                guess_left = Console.ReadLine();
                Console.WriteLine("Enter number on card : ");
                guess_left_num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of card on middle : (Hearts/Diamonds/Clubs)");
                guess_middle = Console.ReadLine();
                Console.WriteLine("Enter number on card : ");
                guess_middle_num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of card on right : (Hearts/Diamonds/Clubs)");
                guess_right = Console.ReadLine();
                Console.WriteLine("Enter number on card : ");
                guess_right_num = int.Parse(Console.ReadLine());
                if((guess_left == s1.card1 && guess_left_num == s1.number1) && (guess_middle == s1.card2 && guess_middle_num == s1.number2) && (guess_right == s1.card3 && guess_right_num == s1.number3))
                {
                        isPlay = true;
                }
                    else
                {
                        isPlay = false;
                }
                if(isPlay == false)
                {
                    Console.WriteLine("You Lose. You failed to guess");
                    isFound = false;
                    break;
                }
                else if(isPlay == true)
                {
                    Console.WriteLine("You Won. You successfully guessed all cards");
                    isFound = false;
                    break;
                }
            
              }  
              }
              card_1 = s1.card2;
              num_1 = s1.number2;
              card_2 = s1.card3;
              num_2 = s1.number3;
              card_3 = s1.card1;
              num_3 = s1.number1;
              Console.WriteLine(num_1+" of "+card_1+"\t"+num_2+" of "+card_2+"\t"+num_3+" of "+card_3);
              counter++;
              Console.ReadLine();
              Console.Clear();
               main_menu();
              if(Loop_index == counter)
              {
                if(counter == 5 || counter == 8 )
                {
                Console.ReadLine();
                Console.WriteLine(num_1+" of "+card_1+"\t"+num_2+" of "+card_2+"\t"+num_3+" of "+card_3);
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the name of card on left : (Hearts/Diamonds/Clubs)");
                guess_left = Console.ReadLine();
                Console.WriteLine("Enter number on card : ");
                guess_left_num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of card on middle : (Hearts/Diamonds/Clubs)");
                guess_middle = Console.ReadLine();
                Console.WriteLine("Enter number on card : ");
                guess_middle_num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of card on right : (Hearts/Diamonds/Clubs)");
                guess_right = Console.ReadLine();
                Console.WriteLine("Enter number on card : ");
                guess_right_num = int.Parse(Console.ReadLine());
                if((guess_left == card_1 && guess_left_num == num_1) && (guess_middle == card_2 && guess_middle_num == num_2) && (guess_right == card_3 && guess_right_num == num_3))
                {
                        isPlay = true;
                }
                else
                {
                        isPlay = false;
                }
                if(isPlay == false)
                {
                    Console.WriteLine("You Lose. You failed to guess");
                    isFound = false;
                    break;
                }
                else if(isPlay == true)
                {
                    Console.WriteLine("You Won. You successfully guessed all cards");
                    isFound = false;
                    break;
                }
                } 
                } 
                card__1 = card_2;
                num__1 = num_2;
                card__2 = card_3;
                num__2 = num_3;
                card__3 = card_1;
                num__3 = num_1;
                Console.WriteLine(num__1+" of "+card__1+"\t"+num__2+" of "+card__2+"\t"+num__3+" of "+card__3);
                counter++;
                Console.ReadLine();
                Console.Clear();
                main_menu();
              if(Loop_index == counter)
              {
                if(counter == 3 || counter == 6 || counter == 9 )
                {
                Console.ReadLine();
                Console.WriteLine(num__1+" of "+card__1+"\t"+num__2+" of "+card__2+"\t"+num__3+" of "+card__3);
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the name of card on left : (Hearts/Diamonds/Clubs)");
                guess_left = Console.ReadLine();
                Console.WriteLine("Enter number on card : ");
                guess_left_num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of card on middle : (Hearts/Diamonds/Clubs)");
                guess_middle = Console.ReadLine();
                Console.WriteLine("Enter number on card : ");
                guess_middle_num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of card on right : (Hearts/Diamonds/Clubs)");
                guess_right = Console.ReadLine();
                Console.WriteLine("Enter number on card : ");
                guess_right_num = int.Parse(Console.ReadLine());
                if((guess_left == card__1 && guess_left_num == num__1) && (guess_middle == card__2 && guess_middle_num == num__2) && (guess_right == card__3 && guess_right_num == num__3))
                    {
                        isPlay = true;
                    }
                    else
                    {
                        isPlay = false;
                    }
                if(isPlay == false)
                {
                    Console.WriteLine("You Lose. You failed to guess");
                    isFound = false;
                    break;
                }
                else if(isPlay == true)
                {
                    Console.WriteLine("You Won. You successfully guessed all cards");
                    isFound = false;
                    break;
                }
                }
                }
                Console.Clear();
                main_menu();  
                } 
             
            }
              
        }
    }

