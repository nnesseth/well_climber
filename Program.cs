/*
 * Nick Nesseth
 * Console Game: WellClimber
 * IMDM 101
 * 3/3/2023
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellClimber
{
    class Program
    {

        // All the choices the character will make
        string[] choices = new string[20];

        // Representation of power ups
        int experience = 0;
        private bool grit, bitOfRope, stick, dirt, leatherGrips, woolenSocks, rubberShoes;

        // is the player stuck in a well or not
        private bool stuck = true;

        private bool lookedRecently = false;

        static void Main(string[] args)
        {


            Console.WriteLine("Press enter to play.");
            Console.ReadLine();

            Program climber = new Program();
            climber.Introduction();
            climber.GatherResolve();
            climber.StuckInAWell();
            climber.Credits();




            // Terminal hang screen
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }

        // Sense of place is set, character introduced.
        private void Introduction()
        {
            // Introduction
            Console.WriteLine(
                "You fall into a pit. It hurt. You hit your head and scraped your knee. Your skull\n" +
                "is going to pop soon, you think. You sit there for a while, letting the pain wash\n" +
                "over you.\n");
            bool notBetter = false;

            while (notBetter)
            {
            Console.WriteLine(
                "Press enter when you're feeling better.\n");
            Console.ReadLine();
            Console.WriteLine(
                "A slumped pile of flesh and bone at the bottom of somewhere deep and dark, stirs.\n");
            Console.WriteLine(
                "H: Open eyes.");
            Console.WriteLine(
                "G: Get up.\n");

            // Choice One
            try
            {
                choices[0] = Console.ReadLine().Trim().Substring(0, 1).ToLower();
            } catch(Exception ex)
            {
                Console.WriteLine("It's okay, this is hard I know. Keep at it.");
            }
            if(choices[0] == "h")
            {
                Console.WriteLine("Your eyes open slowly, the weight of being knocked unconscious\n" +
                    "makes them flutter heavily as they peel themselves from the slick surface of\n" +
                    "your eyeball. You take stock of your body, feeling for broken bones. There\n" +
                    "aren't any. Your knee is bruised. Your hair feels sticky-wet around the spot\n" +
                    "you identify as the epicenter of your headache. You stand up shakily, bracing\n" +
                    "yourself against the cold rounded stone that forms the boundary of your dark\n" +
                    "prison. Your eyes haven't adjusted to the dimness and your feet bump into\n" +
                    "objects scattered on the floor.\n");
                    notBetter = false;

            } else if(choices[0] == "g")
            {
                Console.WriteLine(
                    "You take stock of your body, feeling for broken bones. There aren't any. Your\n" +
                    "knee is bruised. Your hair feels sticky-wet around the spot you identify as the\n" +
                    "epicenter of your headache. You stand up shakily, bracing yourself against the cold\n" +
                    "rounded stone that form the boundaries of a dark prison. Your eyes haven't adjusted\n" +
                    "to the hazy dim and your feet bump into objects scattered on the uneven floor.\n");
                    notBetter = false;
            }
        }

            }

        // First autonomy given to the player.
        private void GatherResolve()
        {
            // Wait until the player wants to leave
            bool noResolve = true;
            while (noResolve)
            {
                Console.WriteLine("H: Climb.");
                Console.WriteLine("G: Give up.\n");

                try {
                    choices[1] = Console.ReadLine().Trim().Substring(0, 1).ToLower();
                } catch(Exception e)
                {
                    Console.WriteLine("Hm..");
                }

                if (choices[1] == "h")
                {
                    Console.WriteLine("You can do it. You can escape. You just have to try.\n");
                    noResolve = false;
                }
                else if (choices[1] == "g")
                {
                    Console.WriteLine("You just can't bring yourself to try, but the question hangs there as you slump against the wall.\n");
                    // TODO: Would be fun to have a few tiers of this

                } else
                {
                    Console.WriteLine(
                        "You search your soul for an answer, but come up short. Your fingers fish up\n" +
                        "an inkling of resolve in your threadbare pocket. Enough to try again, you think.\n");
                }
            }

        }

        // Main game sequence. Includes Climb(), Fall(), Look(), and Escape().
        // The player explores, finding things that help them climb higher.
        private void StuckInAWell()
        {
            while (stuck)
            {
                try
                {
                    //Try to get out of the well.
                    Console.WriteLine(
                        "You look upward resolutely. A great star of light makes you blink and squint,\n" +
                        "but you do not shield yourself from it. The starlight illuminates an old stone\n" +
                        "well, a crumbling shadow of itself. Your pain ebbs at the thought of a way out.\n");
                    Console.WriteLine("H: Look around");
                    Console.WriteLine("G: Climb\n");

                    choices[2] = Console.ReadLine().Trim().ToLower().Substring(0, 1);

                    if (choices[2] == "h")
                    {
                        Look();

                    }
                    else if (choices[2] == "g")
                    {
                        Climb();

                    }
                    else
                    {
                        Console.WriteLine("Stuck in a hole. Unintelligible. Incoherent. What a life.\n");
                        Console.WriteLine("(Press enter to continue.)");
                        Console.ReadLine();
                    }
                } catch (Exception e)
                {
                        Console.WriteLine("Uh, no. That wasn't quite it.");
                } 
            }
                    choices[2] = "";
        }

        private void Climb()
        {
            if(experience >= 10)
            {
                Console.WriteLine("(Press enter to climb.)");
                Console.ReadLine();
                Console.WriteLine("Ten Feet.");
            }
            else
            {
                Fall();
                return;
            }

            if (experience >= 20)
            {
                Console.WriteLine("(Press enter to climb.)");
                Console.ReadLine();
                Console.WriteLine("Twenty Feet.");
            }
            else
            {
                Fall();
                return;
            }

            if (experience >= 30)
            {
                Console.WriteLine("(Press enter to climb.)");
                Console.ReadLine();
                Console.WriteLine("Thirty Feet.");
            }
            else
            {
                Fall();
                return;
            }
            
            if (experience >= 40)
            {
                Console.WriteLine("(Press enter to climb.)");
                Console.ReadLine();
                Console.WriteLine("Forty Feet.");
            }
            else
            {
                Fall();
                return;
            }

            if (experience >= 50)
            {
                Console.WriteLine("(Press enter to climb.)");
                Console.ReadLine();
                Console.WriteLine("Fifty Feet.");
            }
            else
            {
                Fall();
                return;
            }

            if (experience >= 60)
            {
                Console.WriteLine("(Press enter to climb.)");
                Console.ReadLine();
                Console.WriteLine("Sixty Feet.");
            }
            else
            {
                Fall();
                return;
            }

            if (experience >= 70)
            {
                Console.WriteLine("(Press enter to climb.)");
                Console.ReadLine();
                Console.WriteLine("Seventy Feet.");
            }
            else
            {
                Fall();
                return;
            }

            if (experience >= 80)
            {
                Console.WriteLine("(Press enter to climb.)");
                Console.ReadLine();
                Console.WriteLine("Eighty Feet.");
            }
            else
            {
                Fall();
                return;
            }

            if (experience >= 90)
            {
                Console.WriteLine("(Press enter to climb.)");
                Console.ReadLine();
                Console.WriteLine("Ninety Feet.");
            }
            else
            {
                Fall();
                return;
            }

            if (experience >= 100)
            {
                Console.WriteLine("(Press enter to climb.)");
                Console.ReadLine();
                Console.WriteLine("One Hundred Feet.");
                Escape();
            }
            else
            {
                Fall();
                return;
            }
        }

        private void Fall()
        {
            Console.WriteLine("(Press enter to climb.)\n"); // The player doesn't know they're in the fall method yet hahaha
            Console.ReadLine();
            experience += 10;
            lookedRecently = false;
            Console.WriteLine(
                "Your heart plummets as you slip and fall. Your hands and feet scrabble for purchase,\n" +
                "finding nothing but bruises and cuts. Time to accept it, you're falling. It doesn't\n" +
                "feel great, but it's happening. You knew this was coming. You accepted the risk,\n" +
                "but that doesn't make the stone floor any softer.\n");
            Console.WriteLine("(Press enter when you're up for another go.)");
            Console.ReadLine();
        }

        private void Look()
        {

            if(experience < 10)
            {
                Console.WriteLine(
                    "Your blink your eyes, willing them to see. It's hard to make anything out.");

            } else if (lookedRecently)
            {
                Console.WriteLine("An updraft blows fresh air across your face.");
            }

            else
            {
                Console.WriteLine(
                    "You look around the room. As you grow accustomed to the low light level, dark\n" +
                    "contours of a few shapes materialize around the cobbled stone floor. You pick\n" +
                    "one up. ");
            }

            if (experience >= 10 && !lookedRecently)
            {

                // if you don't already have the rope, get it.
                if (!bitOfRope)
                {
                    Console.WriteLine("(Press enter to inspect.)");
                    Console.ReadLine();
                    experience += 10;
                    Console.Write(
                        "You hold a bit of rope about thirty centimeters long. It reminds you\n" +
                        "of all the knots you've tied. All the things you've brought together.\n" +
                        "You pull a few strands and tie a knot around your finger. Maybe it will\n" +
                        "hold together one more thing: You.");
                    bitOfRope = true;
                    lookedRecently = true;
                }
            }

            if (experience >= 20 && !lookedRecently)
            {
                    // if you don't have the stick, get it.. etc.
                if (!stick)
                {
                        Console.WriteLine("(Press enter to inspect.)");
                        Console.ReadLine();
                        experience += 10;
                        Console.Write(
                            "Your fingers run across the smooth bark of a young sapling. Sap sticks\n" +
                            "to the tips of your digits, making them tackier.");
                        stick = true;
                        lookedRecently = true;
                }
            }

            if (experience >= 30 && !lookedRecently)
            {
                if (!dirt)
                {
                    Console.WriteLine("(Press enter to inspect.)");
                    Console.ReadLine();
                    experience += 10;
                    Console.Write(
                        "Some dirt rests in your palm. You wash your hands with it to remove moisture.\n" +
                        "Your hands are now dry.");
                    dirt = true;
                    lookedRecently = true;
                }
            }
            
            if(experience >= 40 && !lookedRecently)
            {
                if(!leatherGrips)
                {
                    Console.WriteLine("(Press enter to inspect.)");
                    Console.ReadLine();
                    experience += 10;
                    Console.Write(
                        "Half of a single leather glove. When you slip it on it covers two fingers\n" +
                        "of your left hand.");
                    leatherGrips = true;
                    lookedRecently = true;
                }
            }
            
            if(experience >= 50 && !lookedRecently)
            {
                if(!woolenSocks)
                {
                    Console.WriteLine("(Press enter to inspect.)");
                    Console.ReadLine();
                    experience += 10;
                    Console.Write(
                        "A pair of mud encrusted woolen socks. You place them near the bottom of\n" +
                        "the shaft, where you might fall. Every little bit helps.");
                    woolenSocks = true;
                    lookedRecently = true;
                }
            }
            
            if(experience >= 60 && !lookedRecently)
            {
                if(!rubberShoes)
                {
                    Console.WriteLine("(Press enter to inspect.)");
                    Console.ReadLine();
                    experience += 10;
                    Console.Write(
                        "A pair of rubber climbing shoes is buried under some rubble. You dig it out\n" +
                        "and put them on. They're not your size, but you think they may help.");
                    rubberShoes = true;
                    lookedRecently = true;
                }
            }

            if(experience >= 90 && !lookedRecently)
            {
                if (!grit)
                {

                    Console.WriteLine("(Press enter to inspect.)");
                    Console.ReadLine();
                    experience += 10;
                    Console.Write("You find some grit. Not a lot, just a little really, but enough to get by.");
                    grit = true;
                    lookedRecently = true;
                }
            }

            if(grit == true && 
               rubberShoes == true && 
               woolenSocks == true && 
               leatherGrips == true && 
               dirt == true && 
               stick == true && 
               bitOfRope == true){

                Console.WriteLine("There's nothing left but opportunity.");
            }

            Console.WriteLine("\n");

        }

        private void Escape()
        {
            Console.WriteLine("(Press enter to climb.)"); // the player doesn't know they've escaped :)
            Console.ReadLine();
            Console.WriteLine(
                "Hands pull you up as you reach the last few feet, extracting your body from the\n" +
                "well. People cheer. You are horrified, because you realize they threw you in there.\n" +
                "They knew you would hurt and suffer. They knew you would be lonely and cold. They\n" +
                "knew you were hungry and stressed. They knew and threw you in anyway, kicking and\n" +
                "scratching as the sound of your screams were snuffed out by the depth of darkness\n" +
                "and abandonment laid raw.\n");
            Console.WriteLine("(Press enter to continue.)");
            Console.ReadLine();
            Console.WriteLine("What a great climber, they would say...\n");
            stuck = false;
        }

        private void Credits()
        {
            Console.WriteLine("(Press enter for credits.)");
            Console.ReadLine();
            Console.WriteLine("A moody game by Nick Nesseth.");
            Console.ReadLine();
        }
    }
}
