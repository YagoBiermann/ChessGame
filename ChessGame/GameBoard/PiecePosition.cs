using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    internal class PiecePosition
    {
        public int row { get; set; } 
        public int column { get; set; }

        public PiecePosition(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public override string ToString()
        {
            return $"Row: {row}, Column: {column}";
        }
    }
}
