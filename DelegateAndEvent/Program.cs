namespace DelegateAndEvent
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome Delegate and Event program");
            Console.WriteLine("Enter a Number \n 1.single cast delegate\n 2.MultiplecastDelegate\n 3.ArrayDelegate");
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
                case 3:
                    Calculation[] array = { new Calculation(creat.Add1),new Calculation(creat.Sub1)};
                    for (int i = 0; i<array.Length; i++)
                    {
                        array[i](100, 60);
                        array[i](30, 6);
                        array[i](50, 4);
                        array[i](70, 6);
                    }
                    break;
            }
        }
    }
}