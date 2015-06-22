using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

struct Object
{
    public int x;
    public int y;
    public string s;
    public ConsoleColor color;
}


class FallingRocks
{

    #region play music

    // Play the notes in a song. 
    protected static void Play(Note[] tune)
    {
        foreach (Note n in tune)
        {
            if (n.NoteTone == Tone.REST)
                Thread.Sleep((int)n.NoteDuration);
            else
                Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
        }
    }

    // Define the frequencies of notes in an octave, as well as  
    // silence (rest). 
    protected enum Tone
    {
        REST = 0,
        GbelowC = 196,
        A = 220,
        Asharp = 233,
        B = 247,
        C = 262,
        Csharp = 277,
        D = 294,
        Dsharp = 311,
        E = 330,
        F = 349,
        Fsharp = 370,
        G = 392,
        Gsharp = 415,
    }

    // Define the duration of a note in units of milliseconds. 
    protected enum Duration
    {
        WHOLE = 1600,
        HALF = WHOLE / 2,
        QUARTER = HALF / 2,
        EIGHTH = QUARTER / 2,
        SIXTEENTH = EIGHTH / 2,
    }

    // Define a note as a frequency (tone) and the amount of  
    // time (duration) the note plays. 
    protected struct Note
    {
        Tone toneVal;
        Duration durVal;

        // Define a constructor to create a specific note. 
        public Note(Tone frequency, Duration time)
        {
            toneVal = frequency;
            durVal = time;
        }

        // Define properties to return the note's tone and duration. 
        public Tone NoteTone { get { return toneVal; } }
        public Duration NoteDuration { get { return durVal; } }
    }

    #endregion

    // prints dwarf and rocks
    static void PrintOnPosition(int x, int y, string s, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(s);
    }

    static void Main()
    {
        int counter = 15000;
        int flowerCount = 0;
        int grassCount = 0;
        int brickCount = 0;
        int playfieldWidth = 40;
        int livesCount = 5;
        int money = 0;
        int score = 0;
        int playMary = 0;

        Console.BufferWidth = Console.WindowWidth = 90;
        Console.BufferHeight = Console.WindowHeight = 22;
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine();
        string intro = @"This is a Falling Good and Bad Rocks game

The dwarf has to:
* buld a house (by catching red bricks #(1) and &&(2))
* grow a garden 
(by catching the red flowers @, cyan grass !, and blue rain ;; = 2 flowers + 2 grass stalks
flowers will bloom only after you have all the 9 grass stalks ready)
* listen to music (by catching # magenta - gives you plus 600 points!)
* increase lives count (by catching + yellow);
* avoid hitting the gray rocks (% are 10% taxes, - is minus 1 life, . is death)
* earn money (by catching: yellow $ (+ $100), * (doubles money if you have any)
* and score high. 
(building a house and growing a garden both double the score)

The dwarf can move in all 4 directions with the arrow keys,
and hits the rocks with its O char.

The game ends in case of death, lives = 0, or count down = 0;

If you are ready to Start - press [enter]!";
        Console.WriteLine(intro);

        // start the game after intro
        Console.ReadKey();
        while (Console.KeyAvailable) // bool, checks whether any key has been pressed, if no key is pressed - go to next code
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey(true);
            if (pressedKey.Key == ConsoleKey.Enter)
            {
                goto Start;
            }
        }

    Start:
        // create the dwarf
        Object dwarf = new Object();
        dwarf.x = 20;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.s = "(O)";
        dwarf.color = ConsoleColor.Red;
        Random randomGenerator = new Random();
        List<Object> objects = new List<Object>();

        while (true)
        {

            bool hitted = false;
            {
                // chance generator
                int chance = randomGenerator.Next(0, 100);

                // generate "^" bricks
                if (chance <= 30)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Red;
                    newObject.s = "^";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate "@" flowers
                else if (chance > 30 && chance <= 35)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Red;
                    newObject.s = "@";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate "*" (multiplies money by 2)
                else if (chance > 35 && chance <= 40)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Yellow;
                    newObject.s = "*";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate "&" = 2 "^" bricks
                else if (chance > 40 && chance <= 45)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Red;
                    newObject.s = "&&";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate "+" (plus 1 life)
                else if (chance > 45 && chance <= 55)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Yellow;
                    newObject.s = "+";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate "%" (10% taxes on money)
                else if (chance > 55 && chance <= 60)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Gray;
                    newObject.s = "%";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate "$" (plus $100)
                else if (chance > 60 && chance <= 70)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Yellow;
                    newObject.s = "$";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate "#" (plays music and adds 600 points to your score)
                else if (chance > 70 && chance <= 75)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Magenta;
                    newObject.s = "#";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate "!" (grows 1 grass stalk)
                else if (chance > 75 && chance <= 85)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Cyan;
                    newObject.s = "!";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate "." (death and end of game)
                else if (chance > 85 && chance <= 86)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Gray;
                    newObject.s = ".";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate ":" (rain = 2 flowers = 2 grass stalks)
                else if (chance > 86 && chance <= 95)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Blue;
                    newObject.s = ";;";
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                // generate "-" ( minus 1 life)
                else
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Gray;
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    newObject.s = "-";
                    objects.Add(newObject);

                }
            }
            while (Console.KeyAvailable) // bool, checks whether any key has been pressed, if no key is pressed - go to next code
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                // moves dwarf in all 4 directtions with arrow keys
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    while (Console.KeyAvailable) Console.ReadKey(true); // speeds up dwarf; cleans buffer of waiting available keys

                    if (dwarf.y - 1 >= 0)
                    {
                        dwarf.y--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    while (Console.KeyAvailable) Console.ReadKey(true);

                    if (dwarf.y + 1 < Console.WindowHeight)
                    {
                        dwarf.y++;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    while (Console.KeyAvailable) Console.ReadKey(true);

                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    if (dwarf.x + 1 <= playfieldWidth)
                    {
                        dwarf.x++;
                    }
                }
            }
            // adds new and new rocks
            List<Object> newList = new List<Object>();
            for (int i = 0; i < objects.Count; i++)
            {
                counter--;
                Object oldRock = objects[i];
                Object newObject = new Object();
                newObject.x = oldRock.x;
                newObject.y = oldRock.y + 1;
                newObject.s = oldRock.s;
                newObject.color = oldRock.color;

                // gives hit instructions
                if (newObject.s == "^" && newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                {
                    brickCount++;
                }
                else if (newObject.s == "@" && newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                {
                    flowerCount++;
                }
                else if (newObject.s == "*" && newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                {
                    money *= 2;
                }
                else if (newObject.s == "&&" && newObject.y == dwarf.y && newObject.x <= dwarf.x + 2)
                {
                    brickCount += 2;
                }
                else if (newObject.s == "+" && newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                {
                    livesCount++;
                }
                else if (newObject.s == "%" && newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                {
                    money -= money / 10;
                }
                else if (newObject.s == "$" && newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                {
                    money += 100;
                }
                else if (newObject.s == "#" && newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                {
                    Note[] Mary = 
        {
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.GbelowC, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.B, Duration.HALF),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.A, Duration.HALF),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.D, Duration.QUARTER),
        new Note(Tone.D, Duration.HALF)
        };
                    // Play the song
                    Play(Mary);
                    playMary += 600;
                }
                else if (newObject.s == "!" && newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                {
                    grassCount++;
                }
                else if (newObject.s == "." && newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                {
                    livesCount = 0;
                    hitted = true;
                    PrintOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Yellow);
                    PrintOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Yellow);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (newObject.s == ";;" && newObject.y == dwarf.y && newObject.x <= dwarf.x + 2)
                {
                    grassCount += 2;
                    flowerCount += 2;
                }
                else if (newObject.s == "-" && newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                {
                    livesCount--;
                    hitted = true;

                    // game over if lives count = 0
                    if (livesCount <= 0)
                    {
                        PrintOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Yellow);
                        PrintOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Yellow);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }

                // you win if counter = 0
                else if (counter <= 0)
                {

                    PrintOnPosition(8, 10, "YOU WIN!!!", ConsoleColor.Yellow);
                    PrintOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Yellow);
                    Note[] Mary = 
                        {
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.GbelowC, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.B, Duration.HALF),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.A, Duration.HALF),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.D, Duration.QUARTER),
        new Note(Tone.D, Duration.HALF)
        };
                    // play song
                    Play(Mary);

                    Console.ReadLine();
                    Environment.Exit(0);
                }
                if (newObject.y < Console.WindowHeight)
                {
                    newList.Add(newObject);
                }
            }
            objects = newList;

            // Redraw playfield
            Console.Clear();

            // Print rocks
            foreach (Object rock in objects)
            {
                PrintOnPosition(rock.x, rock.y, rock.s, rock.color);
            }
            // print dwarf
            if (hitted)
            {
                objects.Clear();
                PrintOnPosition(dwarf.x, dwarf.y, "X", ConsoleColor.White);
            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.s, dwarf.color);
            }

            // Draw info
            score = flowerCount + grassCount + brickCount + livesCount + money + playMary;

            if (brickCount >= 20 && grassCount >= 9 && flowerCount >= 4)
            {
                score *= 4;
            }
            else if (brickCount >= 20)
            {
                score *= 2;
            }
            else if (grassCount >= 9 && flowerCount >= 4)
            {
                score *= 2;
            }
            else
            {
                score = flowerCount + grassCount + brickCount + livesCount + money + playMary;
            }
            PrintOnPosition(44, 1, "Cont Down: " + (counter - 10), ConsoleColor.Yellow);
            PrintOnPosition(44, 3, "Lives: " + livesCount, ConsoleColor.Yellow);
            PrintOnPosition(44, 5, "Money: " + money.ToString("C"), ConsoleColor.Yellow);
            PrintOnPosition(44, 7, "Score: " + score, ConsoleColor.Yellow);

            /* Please, note that if I want to build a house and grow a garden - I have to re-draw them along with the playfield
             * as the playfield gets continously redrawn here.
             This means that every single earned house brick or garden stalk has to be redrawn at every step:
             that is why below I cannot use an if/else structure, I need my program to visit every single if
             and redraw every single earned element - that is why below you will only find IFs*/

            // grow garden
            if (grassCount >= 9 && flowerCount >= 4)
            {
                PrintOnPosition(63, 18, "@", ConsoleColor.Red);
            }

            if (grassCount >= 9 && flowerCount >= 3)
            {
                PrintOnPosition(67, 18, "@", ConsoleColor.Red);
            }

            if (grassCount >= 9 && flowerCount >= 2)
            {
                PrintOnPosition(71, 18, "@", ConsoleColor.Red);
            }

            if (grassCount >= 9 && flowerCount >= 1)
            {
                PrintOnPosition(75, 18, "@", ConsoleColor.Red);
            }

            if (grassCount >= 9)
            {
                PrintOnPosition(77, 19, "!", ConsoleColor.Cyan);
            }

            if (grassCount >= 8)
            {
                PrintOnPosition(75, 19, "!", ConsoleColor.Cyan);
            }

            if (grassCount >= 7)
            {
                PrintOnPosition(73, 19, "!", ConsoleColor.Cyan);
            }

            if (grassCount >= 6)
            {
                PrintOnPosition(71, 19, "!", ConsoleColor.Cyan);
            }

            if (grassCount >= 5)
            {
                PrintOnPosition(69, 19, "!", ConsoleColor.Cyan);
            }

            if (grassCount >= 4)
            {
                PrintOnPosition(67, 19, "!", ConsoleColor.Cyan);
            }

            if (grassCount >= 3)
            {
                PrintOnPosition(65, 19, "!", ConsoleColor.Cyan);
            }

            if (grassCount >= 2)
            {
                PrintOnPosition(63, 19, "!", ConsoleColor.Cyan);
            }

            if (grassCount >= 1)
            {
                PrintOnPosition(61, 19, "!", ConsoleColor.Cyan);
            }

            // build a house
            if (brickCount >= 20)
            {
                PrintOnPosition(59, 15, "^", ConsoleColor.Red);
            }

            if (brickCount >= 19)
            {
                PrintOnPosition(57, 13, "^", ConsoleColor.Red);
            }

            if (brickCount >= 18)
            {
                PrintOnPosition(55, 11, "^", ConsoleColor.Red);
            }

            if (brickCount >= 17)
            {
                PrintOnPosition(53, 9, "^", ConsoleColor.Red);
            }

            if (brickCount >= 16)
            {
                PrintOnPosition(51, 11, "^", ConsoleColor.Red);
            }

            if (brickCount >= 15)
            {
                PrintOnPosition(49, 13, "^", ConsoleColor.Red);
            }

            if (brickCount >= 14)
            {
                PrintOnPosition(57, 15, "^", ConsoleColor.Red);
            }

            if (brickCount >= 13)
            {
                PrintOnPosition(55, 15, "^", ConsoleColor.Red);
            }

            if (brickCount >= 12)
            {
                PrintOnPosition(53, 15, "^", ConsoleColor.Red);
            }

            if (brickCount >= 11)
            {
                PrintOnPosition(51, 15, "^", ConsoleColor.Red);
            }

            if (brickCount >= 10)
            {
                PrintOnPosition(49, 15, "^", ConsoleColor.Red);
            }

            if (brickCount >= 9)
            {
                PrintOnPosition(47, 15, "^", ConsoleColor.Red);
            }

            if (brickCount >= 8)
            {
                PrintOnPosition(58, 17, "^", ConsoleColor.Red);
            }

            if (brickCount >= 7)
            {
                PrintOnPosition(48, 17, "^", ConsoleColor.Red);
            }

            if (brickCount >= 6)
            {
                PrintOnPosition(48, 19, "^", ConsoleColor.Red);
            }

            if (brickCount >= 5)
            {
                PrintOnPosition(50, 19, "^", ConsoleColor.Red);
            }

            if (brickCount >= 4)
            {
                PrintOnPosition(52, 19, "^", ConsoleColor.Red);
            }

            if (brickCount >= 3)
            {
                PrintOnPosition(54, 19, "^", ConsoleColor.Red);
            }

            if (brickCount >= 2)
            {
                PrintOnPosition(56, 19, "^", ConsoleColor.Red);
            }

            if (brickCount >= 1)
            {
                PrintOnPosition(58, 19, "^", ConsoleColor.Red);
            }

            // constant speed
            Thread.Sleep(150);
        }

    }

}


