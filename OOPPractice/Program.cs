using System.Runtime.CompilerServices;

namespace OOPPractice
{
    // OOP(은닉성/상속성/다항성)
    
    // 자동차
    // 핸들 페달 차문
        // 전기장치 엔진 기름 <-> 외부 노출??

    class Knight
    {
        // 접근 한정자
        // public private protected
        protected int hp;

        public void SetHP(int hp)
        {
            this.hp = 20;
        }
    }

    class SuperKnight : Knight
    {
        void Test()
        {
            hp = 10;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            
            knight.SetHP(100);
        }
    }
}
