using System;

namespace Variable_type
{
    class main
    {//Variable 16 bit
        static void Main(string[] args)
        {
            char _char = '\x5A';   //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char. 
            Console.WriteLine(_char);    //char: stores a single Unicode character and takes up 2 bytes. Represented by the System type System.Char.

            ushort _ushort = 65535;     //ushort: хранит целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16
            Console.WriteLine(_ushort); //ushort: stores an integer from 0 to 65535 and takes up 2 bytes. Represented by the System type System.UInt16

            short _short = -32768;      //short: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16
            Console.WriteLine(_short);  //short: stores an integer from -32768 to 32767 and takes up 2 bytes. Represented by the System type System. Int16

            Console.ReadKey(); 
        }
    }
}
