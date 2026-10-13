namespace OOPPractice
{
    // 객체(OOP Object Oriente Programming)

    // Knight

    // 속성: hp, attack, pos, etc...
    // 기능: Move, Attack, Die, etc...
    
    class Knight
    {
        public int hp;
        public int attack;

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();

            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();
        }
    }
}
