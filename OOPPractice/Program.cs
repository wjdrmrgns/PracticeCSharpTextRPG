using System.Runtime.CompilerServices;

namespace OOPPractice
{
    // OOP(은닉성/상속성/다항성)

    class Player
    {
        protected int hp;
        protected int attack;
    }

    class Knight : Player
    {

    }

    class Mage : Player
    {
        public int mp;
    }

    internal class Program
    {
        static void EnterGame(Player player)
        {
            //bool isMage = player is Mage;
            Mage mage = (player as Mage);
            if (mage != null)
            {
                //Mage mage = (Mage)player;
                mage.mp = 10;
            }
            
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            //EnterGame(knight);
            EnterGame(mage);
        }
    }
}
