using System;

namespace Variable_type
{
    class main
    {//Variable 8 bit
        static void Main(string[] args)
        {
            byte _byte = 255;             //byte: хранит целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte
            Console.WriteLine(_byte);     //byte: stores an integer from 0 to 255 and takes up 1 byte. Represented by the System type System.Byte

            sbyte _sbyte = -128;
            Console.WriteLine(_sbyte);

            Console.ReadKey(); 
        }
    }
}
