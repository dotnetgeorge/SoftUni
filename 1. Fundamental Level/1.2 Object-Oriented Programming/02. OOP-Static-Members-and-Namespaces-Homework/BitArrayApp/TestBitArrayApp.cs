using System;
using BitArrayApp.Data;

namespace BitArrayApp
{
    internal class TestBitArrayApp
    {
        private static void Main(string[] args)
        {
            var bits = new BitArray(8);

            bits[7] = 1;

            Console.WriteLine(bits.ToString());
        }
    }
}