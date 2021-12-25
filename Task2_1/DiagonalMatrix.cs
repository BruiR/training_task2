using System;

namespace Task2_1
{
    public class DiagonalMatrix
    {
        private readonly int[] _elements;
        public int Size
        {
            get
            {
                return _elements.Length;
            }
        }

        public DiagonalMatrix(params int[] data)
        {
            if (data == null)
            {
                _elements = Array.Empty<int>();
            }
            else
            {
                _elements = new int[data.Length];
                data.CopyTo(_elements, 0);
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (IsCorrectIndex(i,j))
                {
                    return _elements[i];
                }
                else 
                {
                    return 0;
                }
            }

            set
            {
                if (IsCorrectIndex(i,j))
                {
                    _elements[i] = value;
                }
            }
        }

        private bool IsCorrectIndex(int i, int j)
        {
            if ((i == j) && (0 <= i) && (i < Size))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Track()
        {
            int sum = 0;
            for(int i =0; i < Size; i++)
            {
                sum += _elements[i];
            }
            return sum;
        }

        public override bool Equals(object obj)
        {
            if ((obj is DiagonalMatrix matrix) && (Size == matrix.Size))
            {
                for (int i = 0; i < Size; i++)
                {
                    if (_elements[i] != matrix[i, i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            string outputString = string.Empty;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    outputString += $"{this[i,j], -12}";
                }
                outputString += "\n";
            }
            return outputString;
        }
    }
}
