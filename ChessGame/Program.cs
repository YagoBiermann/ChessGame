using System;
using GameBoard;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PiecePosition piece;
            piece = new PiecePosition(3, 4);
            Console.WriteLine(piece);
        }
    }
}