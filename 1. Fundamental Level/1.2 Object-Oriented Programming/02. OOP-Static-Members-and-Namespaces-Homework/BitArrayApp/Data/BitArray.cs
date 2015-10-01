namespace BitArrayApp.Data
{
    using System;

    public class BitArray
    {
        private byte[] _bitArray;
        private int _length;

        /// <summary>
        /// Initializes a new instance of the <see cref="BitArray"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        public BitArray(int length)
        {
            Length = length;
            _bitArray = new byte[Length];
            InitializeArray();
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Length should be in range[1..100 000]!</exception>
        public int Length
        {
            get { return _length; }
            protected set
            {
                if (value < 1 || 100000 < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Length should be in range[1..100 000]!");
                }

                _length = value;
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Byte"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.Byte"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Inserted value shoul be 0 or 1!</exception>
        public byte this[int index]
        {
            get { return _bitArray[index]; }
            set
            {
                if (1 < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Inserted value should be 0 or 1!");
                }

                _bitArray[index] = value;
            }
        }

        /// <summary>
        /// Initializes the array.
        /// </summary>
        private void InitializeArray()
        {
            for (var i = 0; i < Length; i++)
            {
                _bitArray[i] = 0;
            }
        }

        /// <summary>
        /// Converts to decimal.
        /// </summary>
        /// <returns></returns>
        private int ConvertToDecimal()
        {
            var result = 0;

            for (var i = 0; i < Length; i++)
            {
                result += (int)(_bitArray[i] * Math.Pow(2, i));
            }

            return result;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return ConvertToDecimal().ToString();
        }
    }
}
