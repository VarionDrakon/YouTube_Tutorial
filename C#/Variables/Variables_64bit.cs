using System;

namespace Variable_type
{
    class main
    {//Variable 64 bit
        static void Main(string[] args)
        {
            ulong _ulong = 18446744073709551615;    //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт. Представлен системным типом System.UInt64
            Console.WriteLine(_ulong);                    //ulong: stores a whole number from 0 to 18 446 744 073 709 551 615 and occupies 8 bytes. Represented by the System type System.UInt64

            long _long = 9223372036854775807;       //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт. Представлен системным типом System.Int64
            Console.WriteLine(_long);                    //long: stores an integer from -9 223 372 036 854 775 808 to 9 223 372 036 854 775 807 and occupies 8 bytes. Represented by the System type System.Int64

            float _float = 3000000000000000000;     //float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта. Представлен системным типом System.Single
            Console.WriteLine(_float);                    //float: stores a floating-point number from -3.4*1038 to 3.4*1038 and takes up 4 bytes. Represented by the System type System.Single

            double _double = 3000000000000000000;   //double: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта. Представлен системным типом System.Double
            Console.WriteLine(_double);                    //double: stores a floating-point number from ±5.0*10-324 to ±1.7*10308 and takes up 8 bytes. Represented by the System type System. Double

            decimal _decimal = 3000000000000000000; //decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт. Представлен системным типом System.Decimal
            Console.WriteLine(_decimal);                    //decimal: stores a decimal fractional number. If used without a decimal point, it has a value from ±1.0*10-28 to ±7.9228*1028, can store 28 decimal places, and takes up 16 bytes. Represented by the System type System.Decimal

            Console.ReadKey(); 
        }
    }
}
