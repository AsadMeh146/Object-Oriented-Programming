using System;

namespace Card_Game
{
    class Card
    {
        int value = 0;
        string name = "";
       public Card(int v,string n)
       {
            value  = v;
            name = n;
       }
       public void getName(string n)
       {
           name  = n;
       }
       public void getValue(int v)
       {
           value  = v;
       }
       public int setValue()
       {
           return value;
       }

       public void toString()
       {
         if(value == 1)
         {
             Console.WriteLine("Ace of "+name);
         }
         else if(value == 11)
         {
             Console.WriteLine("Jack of "+name);
         }
         else if(value == 12)
         {
             Console.WriteLine("Queen of "+name);
         }
         else if(value == 13)
         {
             Console.WriteLine("King of "+name);
         }
         else
         {
             Console.WriteLine(value+" of "+name); 
         }
       }

    }
    class Deck 
    {
        Card [] deck = new Card[52];
        int cLeft = 52;
        public Deck()
        {
          for(int x=0;x<4;x++)
           {
             for(int y=0;y<13;y++)
           {
             if(x==0)
             {
                 deck[y] = new Card(y+1 , "Clubs");
             }
             if(x==1)
             {
                 deck[y + 13] = new Card(y+1 , "Spades");
             }      
             if(x==2)
             {
                 deck[y + 13 + 13] = new Card(y+1 , "Diamods");
             }
             if(x==3)
             {
                 deck[y + 13 + 13 + 13] = new Card(y+1 , "Hearts");
             }    
           }
           }

        }
        public void shuffle()
        {
            Random rng = new Random();
            for(int i=0;i<52;i++)
            {
                deck[i].toString();
                if(i == 12)
                {
                    Console.WriteLine("-------------------------");                   
                }
                if(i == 25)
                {
                    Console.WriteLine("-------------------------");      
                }
                if(i == 38)
                {
                    Console.WriteLine("-------------------------");    
                }
                if(i == 52)
                {
                    Console.WriteLine("-------------------------");
                }
            }
            int n = deck.Length;
            while(n>1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card temp = deck[k];
                deck[k] = deck[n];
                deck[n] = temp;     
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Now shuffled cards are below");
            for(int j=0;j<52;j++)
            {
                deck[j].toString();
            }
        }
        public int cardsLeft()
        {
            int Left = cLeft;
            return Left;  
        }
        public void dealcard()
        {
            int score = 0;
            int get = 0;
            int idx = 0;
            get = cardsLeft();
            string guessWord;
            bool isGameOver = true;
            Console.WriteLine("---------------------");
            deck[idx].toString();
            while(isGameOver != false)
            {   
                int previousNum = deck[idx].setValue();
                int NextNum = deck[idx+1].setValue();
                Console.WriteLine("Guess the next number will be (Higher/Lower) ");
                guessWord = Console.ReadLine();
                if(guessWord == "Higher")
                {
                    if(NextNum >= previousNum)
                    {
                    
                    get = get - 1;
                    Console.WriteLine("No of cards left : "+get);
                    for(int j=0;j<get;j++)
                    {
                        deck[j] = deck[j+1];
                        if(j==get)
                        {
                            deck[j] = deck[j+2];
                        }    
                    }
                    previousNum = deck[idx].setValue();
                    NextNum = deck[idx+1].setValue();
                    score = score + 10;
                    deck[idx].toString(); 
                    }
                    else if(NextNum < previousNum)
                    {
                      Console.WriteLine("You guessed wrong......");
                      Console.WriteLine("Your score is : "+score);
                      isGameOver = false;
                    } 
                }
                else if(guessWord == "Lower")
                {
                    if(NextNum <= previousNum)
                    {
                    
                    get = get - 1; 
                    Console.WriteLine("No of cards left : "+get);
                    for(int j=0;j<get;j++)
                    {
                        deck[j] = deck[j+1];
                        if(j==get)
                        {
                            deck[j] = deck[j+2];
                        }    
                    }
                    previousNum = deck[idx].setValue();
                    NextNum = deck[idx+1].setValue();
                    score = score + 10;
                    deck[idx].toString();
                    }
                    else if(NextNum > previousNum)
                    {  
                      Console.WriteLine("You guessed wrong......");
                      Console.WriteLine("Your score is : "+score);
                      isGameOver = false;
                      break;
                    }
                }
            }   
        }        
    }
    class Driver
    {
        static void Main(string[] args)
        {            
           Card s = new Card(5,"Diamonds");
           Deck s1 = new Deck();
           s1.shuffle();
           s1.dealcard();         
        }
    }
}
