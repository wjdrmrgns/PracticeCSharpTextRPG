using System.Runtime.CompilerServices;

namespace OOPPractice
{
    // OOP(은닉성/상속성/다항성)

    class Player
    {
        protected int hp;
        protected int attack;

        // 오버로딩(함수 이름의 재사용) / 오버라이딩(다형성)
        public virtual void Move()
        {
            Console.WriteLine("Player 이동");
        }
    }

    class Knight : Player
    {
        public sealed override void Move()
        {
            base.Move();

            Console.WriteLine("Knight 이동");
        }
    }

    class SuperKnight : Knight
    {
        //public override void Move()
        //{
        //    Console.WriteLine("SK 이동");
        //}
    }

    class Mage : Player
    {
        public int mp;
        public override void Move()
        {
            Console.WriteLine("Mage 이동!");
        }
    }

    internal class Program
    {
        static void EnterGame(Player player)
        {
            player.Move();

        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            EnterGame(knight);
            EnterGame(mage);
        }
    }
}
