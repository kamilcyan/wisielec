using System;

namespace wisielec
{
    public class Word
    {
        public static string Fraze { get; set; }="fraze";
        public static int length = Fraze.Length;
        public char[] Password =  new char[length];
        

       

        public void Checking()
        {
            var game = new Game();
            int hitCounter = 0;
            int tryCounter = 0;
            
            {
                for(int i=0; i<length; i++)
                {
                    Password[i] = '-';
                    Console.Write(Password[i]);
                }
            }
            
            do
            {
                    char guessed = game.guess().ToCharArray()[0];
                    Console.Clear();
                    char[] charArray = Fraze.ToCharArray();

                    for (int i = 0; i < length; i++)
                    {
                        if (charArray[i]==guessed)
                        {
                            if(Password[i]=='-')
                            {
                                Password[i] = guessed;
                                hitCounter ++;
                            }
                        }
                        else
                        {
                            if(Password[i]=='-')
                            {
                                Password[i] = '-';
                            }
                        }
                        Console.Write(Password[i]);
                    }
                tryCounter++;
                int counter = hitCounter;
                if(counter == length){
                    Console.Write("\nWell done.");
                    return;
                }
                Console.WriteLine($"\nYou have {10 - tryCounter} chances left");
            }while(tryCounter<10);

        }
    }
}