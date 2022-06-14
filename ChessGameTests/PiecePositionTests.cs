using System;
using GameBoard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessGameTests
{
    [TestClass]
    public class PiecePositionTests
    {
        [TestMethod]
        public void Check_PiecePosition_ReturnsCorrectPosition()
        {
            PiecePosition piece = new(3, 4);
            Assert.AreEqual(4, piece.column);
            Assert.AreEqual(3, piece.row);
        }
    }
}