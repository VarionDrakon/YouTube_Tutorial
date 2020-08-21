using System;

namespace Variable_type
{
    class main
    {//Variable 32 bit
        static void Main(string[] args)
        {
            int _int = 2147483647;      //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32. Все целочисленные литералы по умолчанию представляют значения типа int:
            Console.WriteLine(_int);    //int: stores an integer from -2147483648 to 2147483647 and occupies 4 bytes. It is represented by the System type System. Int32. All integer literals represent int values by default:

            uint _uint = 0x10;    //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32
            Console.WriteLine(_uint);   //uint: stores an integer from 0 to 4294967295 and takes up 4 bytes. Represented by the System type System.UInt32

            Console.ReadKey(); 
        }
    }
}
