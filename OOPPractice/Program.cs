namespace OOPPractice
{
    // OOP(은닉성/상속성/다항성)

    class Player // 부모 or 기반
    {
        // 필드
        static public int counter = 1; // 오로지 1개만 존재!
        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            Console.WriteLine("Player 생성자 호출!");
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    class Mage : Player
    {

    }

    class Archer : Player
    {
        
    }

    class Knight : Player // 자식 or 파생
    {

    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Move(); // 일반

        }
    }
}
