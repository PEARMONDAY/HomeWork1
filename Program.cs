using System;

namespace HomeWork_oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //user
            user jame = new user();
            jame.name = "jame watson";
            Console.Write(jame.name);
            jame.email = "jame.W@gmail.com";
            Console.Write(jame.email);
            //shirt1
            shirtpay_1 = new shirt();
            pay_shirt1.size = "L";
            pay_shirt1.color = "red";
            pay_shirt1.price = 500;
            //shirt2
            shirtpay_2 = new shirt();
            pay_shirt2.size = "M";
            pay_shirt2.color = "black";
            pay_shirt2.price = 750;
            //shirt3
            shirtpay_3 = new shirt();
            pay_shirt3.size = "S";
            pay_shirt3.color = "blue";
            pay_shirt3.price = 625;
            //shopping
            shopping_price_shirt = new shopping(pay_shirt1.price, pay_shirt2.price = 750, pay_shirt3.price = 625);
        }
    }
    class shirt
    {
        public string size;
        public string color;
        public string price;
        public string image;
    }
    class user
    {
        public string name;
        public string email;
    }
    class Address
    {
        public string street;
        public string city;
        public string code;
    }
    class shopping
    {
        public float[] ordershirt = new float[3];
        public shopping(float price_shirt1, float price_shirt2, float price_shirt3);
        {
            ordershirt[0] = price_shirt1;
            Console.WriteLine("price_shirt1 = "+ordershirt[0]);
            ordershirt[1] = price_shirt2;
            Console.WriteLine("price_shirt2 = "+ordershirt[1]);
            ordershirt[2] = price_shirt3;
            Console.WriteLine("price_shirt3 = "+ordershirt[2]);

            Address Address_jame = new Address();
            Address_jame.street = "\n ที่อยู่ 131/75,ถ.พุทธมณฑล";
            Console.WriteLine(Address_jame.street);
            Addess_jame.city = "นครปฐม";
            Console.WriteLine(Addess_jame.city);
            Addess_jame.code = "10180";
            Console.WriteLine(Addess_jame.code);
    }
}
