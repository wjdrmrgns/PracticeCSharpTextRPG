namespace OOPPractice
{
    // 객체(OOP Object Oriente Programming)

    // Knight

    // 속성: hp, attack, pos, etc...
    // 기능: Move, Attack, Die, etc...
    
    // Ref 참조
    class Knight
    {
        static public int counter = 1; // 오로지 1개만 존재!

        public int id;
        public int hp;
        public int attack;

        static public void Test()
        {
            counter++;
        }
        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 50;
            return knight;
        }

        public Knight()
        {
            id = counter++;

            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        public Knight(int hp) : this()
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출!");
        }

        public Knight(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
            Console.WriteLine("int int 생성자 호출!");
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
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

    internal class Program
    {

        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight(); // static
            knight.Move(); // 일반

        }
    }
}
