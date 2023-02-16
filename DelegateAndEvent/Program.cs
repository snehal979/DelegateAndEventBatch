namespace DelegateAndEvent
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome Delegate and Event program");
            Console.WriteLine("Enter a Number \n 1.single cast delegate\n 2.MultiplecastDelegate");
            TypeCastDelegate creat = new TypeCastDelegate();//Object
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Calculation del = new Calculation(creat.Add1);//single cast delegate
                    del(100, 40);
                    Calculation del1 = new Calculation(creat.Sub1);//multi cast delegate
                    del1(100, 40);
                    break;
                case 2:
                   Calculation obj = creat.Add1;
                   obj += creat.Sub1;
                   obj(100, 60);
                   //obj(100, 60);
                   break;
            }
        }
    }
}