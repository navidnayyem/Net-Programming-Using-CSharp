using System;
using System.Collections.Generic;
using System.Text;

namespace HangmanGame
{
    class Wordlist
    {
        Random randNumber = new Random();

        private static string[] wordlist = {
         "ant", "baboon", "badger", "bat", "bear", "beaver", "camel", "cat", "clam" ,"cobra" ,"cougar",
         "coyote", "crow", "deer", "dog", "donkey", "duck", "eagle", "ferret", "fox", "frog", "goat",
         "goose", "hawk", "lion", "lizard", "llama", "mole", "monkey", "moose", "mouse", "mule", "newt",
         "otter", "owl", "panda", "parrot", "pigeon", "python", "rabbit", "ram", "rat", "raven",
         "rhino", "salmon", "seal", "shark", "sheep", "skunk", "sloth", "snake", "spider","stork",
         "swan", "tiger" ,"toad" ,"trout" ,"turkey", "turtle", "weasel", "whale", "wolf",
         "wombat", "zebra" };

         List<String> dict = new List<string>(wordlist);
         List<char> temp = new List<char>();
         
         //Pick up a random word from the Dictionary
         public string generateRandomWord()
         {
             return wordlist[randNumber.Next(0, dict.Count)];
         }
        
        //Generate the Game
         ~Wordlist()
         {
             Console.WriteLine("Game Ended");
         }

         public string generateUI()
         {
            string word = generateRandomWord();
            int wordCount = word.Length;
            int userLive = 5;
            Console.WriteLine("*** HANGMAN GAME ***\t\t\tLIVES Remaining: {0}\n", userLive);
            Console.WriteLine("First & Last Character is shown for hints.");
            Console.WriteLine("Here is the hidden {0} Letter Word of Animals.\n", wordCount);
            Console.Write("GUESS THE WORD --> ");

            for (int counter = 0; counter < wordCount; counter++)
            {
                if (counter == 0 || counter == wordCount - 1)
                {
                    Console.Write(" {0} ", word[counter]);
                }
                else
                {
                    Console.Write(" _ ");
                }
            }
            return word;
         }
         
         //Winning logic
         public string getUserInput()
         {
            char userInput;
            string word = generateUI();
            string userWord;
            int wordCount;
            int userLive = 5; //userLive
            wordCount = word.Length;
            int c = 1;

            Console.WriteLine();
            //Console.WriteLine(word);
            Console.WriteLine();
            
            for (int counter = 0; counter < wordCount; counter++)
            {
            comehere:
                Console.Write("Enter Guessed Character of Animal Word {0}: ", c);
                userInput = Convert.ToChar(Console.ReadLine());
                c++;
                
                if (word[counter] == userInput)
                {
                    temp.Add(userInput);
                    continue;
                }
                else if (word[counter] != userInput)
                {
                    userLive--;
                    if (userLive <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("GAME OVER!: Remaining LIVES: 0");
                        Console.WriteLine("THE WORD WAS '{0}'\n", word);
           
                        break;
                    }
                    else if (userLive == 1)
                    {
                        Console.WriteLine("Wrong Try Again, Lives: {0}", userLive);
                        goto comehere;
                    }
                    else if (userLive == 2)
                    {
                        Console.WriteLine("Wrong Try Again, Lives: {0}", userLive);
                        goto comehere;
                    }
                    else if (userLive == 3)
                    {
                        Console.WriteLine("Wrong Try Again, Lives: {0}", userLive);
                        goto comehere;
                    }
                    else if (userLive == 4)
                    {
                        Console.WriteLine("Wrong Try Again, Lives: {0}", userLive);
                        goto comehere;
                    }
                }
            }
            
            userWord = string.Join("", temp.ToArray());
            
            if (isWon(word, userWord))
            {
                Console.WriteLine("\nYou Guessed Right, The Word is {0}", word);
            }
            
            //converts the char list into array of charachter(String)
            Console.WriteLine();
            return userWord;
         }
        
        public bool isWon(String firstWord, String UserWord)
        {
            if (String.Compare(firstWord, UserWord) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}