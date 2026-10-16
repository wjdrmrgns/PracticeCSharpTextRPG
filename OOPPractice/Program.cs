using System.Runtime.CompilerServices;

namespace OOPPractice
{
    // OOP(은닉성/상속성/다항성)

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";

            // 1. 찾기
            bool found = name.Contains("Harry");
            int index = name.IndexOf('z');

            // 2. 변형
            name = name + " Junior";
            string lowerCaseName = name.ToLower();
            string upperCaseName = name.ToUpper();
            string newName = name.Replace('r', 'l');


            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(5);
        }
    }
}
