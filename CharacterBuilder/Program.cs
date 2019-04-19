using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Character.Decorators;
using Character.Interfaces;
using Character;

namespace CharacterBuilder
{
    class Program
    {
        // Base character has no decorations. Just outputs character outline.
        static ICharacter _character = new BaseCharacter();

        static void Main(string[] args)
        {
            Console.WriteLine("-- Welcome to the character builder application --\n");

            SelectCharacterType();
        }

        static void SelectCharacterType()
        {
            Console.WriteLine("Select your type of character by typing the number and pressing enter.");
            Console.WriteLine("1. Knight");
            Console.WriteLine("2. Viking");
            Console.WriteLine("3. Robot");

            string choice = "";
            bool validChoice = false;
            do
            {
                Console.Write("> ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        // Decorate base character with KnightDecorator
                        _character = new KnightDecorator(_character);
                        validChoice = true;
                        break;
                    case "2":
                        // Decorate base character with VikingDecorator
                        _character = new VikingDecorator(_character);
                        validChoice = true;
                        break;
                    case "3":
                        // Decorate base character with RobotDecorator
                        _character = new RobotDecorator(_character);
                        validChoice = true;
                        break;

                    default:
                        Console.WriteLine("Unknown choice. Try again.");
                        break;
                }
            } while (!validChoice);

            Console.WriteLine();

            SelectWeapon();
        }

        static void SelectWeapon()
        {
            Console.WriteLine("Select your characters weapon by typing the number and pressing enter.");
            Console.WriteLine("1. Axe");
            Console.WriteLine("2. Sword");
            Console.WriteLine("3. Railgun");
            Console.WriteLine("4. Shotgun");

            string choice = "";
            bool validChoice = false;
            do
            {
                Console.Write("> ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        // Decorate selected character type with AxeDecorator
                        _character = new AxeDecorator(_character);
                        validChoice = true;
                        break;
                    case "2":
                        // Decorate selected character type with SwordDecorator
                        _character = new SwordDecorator(_character);
                        validChoice = true;
                        break;
                    case "3":
                        // Decorate selected character type with RailgunDecorator
                        _character = new RailgunDecorator(_character);
                        validChoice = true;
                        break;
                    case "4":
                        // Decorate selected character type with ShotgunDecorator
                        _character = new ShotgunDecorator(_character);
                        validChoice = true;
                        break;

                    default:
                        Console.WriteLine("Unknown choice. Try again.");
                        break;
                }
            } while (!validChoice);

            Console.WriteLine();

            SelectSidekick();
        }

        static void SelectSidekick()
        {
            Console.WriteLine("Select your characters sidekick by typing the number and pressing enter.");
            Console.WriteLine("1. No sidekick");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Horse");
            Console.WriteLine("4. Lion");
            Console.WriteLine("5. Owl");

            string choice = "";
            bool validChoice = false;
            do
            {
                Console.Write("> ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        // No further decoration
                        validChoice = true;
                        break;
                    case "2":
                        // Decorate selected character type (with weapons decoration) with DogDecorator
                        _character = new DogDecorator(_character);
                        validChoice = true;
                        break;
                    case "3":
                        // Decorate selected character type (with weapons decoration) with HorseDecorator
                        _character = new HorseDecorator(_character);
                        validChoice = true;
                        break;
                    case "4":
                        // Decorate selected character type (with weapons decoration) with LionDecorator
                        _character = new LionDecorator(_character);
                        validChoice = true;
                        break;
                    case "5":
                        // Decorate selected character type (with weapons decoration) with OwlDecorator
                        _character = new OwlDecorator(_character);
                        validChoice = true;
                        break;

                    default:
                        Console.WriteLine("Unknown choice. Try again.");
                        break;
                }
            } while (!validChoice);

            Console.WriteLine();

            Render();
        }

        static void Render()
        {
            Console.WriteLine("Your character is complete. Rendering...");
            // Render character. Look at sequence diagram to get an overview of how this works.
            _character.Render();
        }
    }
}
