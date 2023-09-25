using System;

namespace StringApplication{
    class Program
    {
        public static void Main(string[] args)
        {
            string fname, lname;
            fname = "Roman";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}",fullname);

            char[] letters = new char[] { 'H', 'e', 'l', 'l', 'o' };
            string geetings = new string(letters);
            Console.WriteLine("Message：{0}",geetings);

            string[] sarray = { "Hello", "From", "Tutorials", "Points" };
            string message = string.Join(" ", sarray);
            Console.WriteLine("Message:{0}",message);

            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = string.Format("Message sent at {0:t} on {0:D}",waiting);
            Console.WriteLine("Message:{0}",chat);
        }
    }
}
