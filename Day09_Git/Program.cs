namespace Day09_Git
{
    internal class Program
    {

        struct Player
        {
            public string name;
            public int level;
        }

        struct Monster
        {
            public string name;
            public int hp;
        }


        static void Main(string[] args)
        {
            Player player = new Player() { name = "김전사", level = 1 };
            Monster slime = new Monster() { name = "슬라임", hp = 8 };

        }


    }


}
