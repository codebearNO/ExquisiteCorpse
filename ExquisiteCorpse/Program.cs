using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomMode2();
        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    MonsterHead();
                    break;
                case 2:
                    GhostHead();
                    break;
                case 3:
                    BugHead();
                    break;
                default:
                    break;
            }
            switch (body)
            {
                case 1:
                    MonsterBody();
                    break;
                case 2:
                    GhostBody();
                    break;
                case 3:
                    BugBody();
                    break;
                default:
                    break;
            }
            switch (feet)
            {
                case 1:
                    MonsterFeet();
                    break;
                case 2:
                    GhostFeet();
                    break;
                case 3:
                    BugFeet();
                    break;
                default:
                    break;
            }
        }

        static int TranslateToNumber(string creature)
        {
            switch (creature.ToLower())
            {
                case "monster": return 1;
                    break;
                case "ghost": return 2;
                    break;
                case "bug": return 3;
                    break;
                default: return 1;
            }
        }

        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);
            SwitchCase(headNum, bodyNum, feetNum);
        }

        static void RandomMode2()
        {
            while (true)
            {
                Console.Clear();
                RandomMode();
                Thread.Sleep(1423);
            }
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　   (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
