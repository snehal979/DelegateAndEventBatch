namespace DelegateAndEvent
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome Delegate and Event program");
            Console.WriteLine("Enter a Number \n 1.single cast delegate");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    SingleCastDelegate creat = new SingleCastDelegate();//Object
                    Calculation del = new Calculation(creat.Add1);//delegate
                    del(100, 40);
                    Calculation del1 = new Calculation(creat.Sub1);//delegate
                    del1(100, 40);
                    break;
            }
        }
    }
}