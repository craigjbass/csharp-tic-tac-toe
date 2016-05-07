using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TicTacToe;
using Should;
using static TicTacToe.WinDetector;
using static TicTacToe.WinDetector.BoardCellState;
using static TicTacToe.WinDetector.WinState;

namespace TicTacToeTest
{

    [TestFixture]
    public class WinDetectorTest
    {

        private WinState WinStateWithEmptyBoard()
        {
            return WinStateWithBoard(new[] {
                _, _, _,
                _, _, _,
                _, _, _
            });
        }
        
        private WinState WinStateWithBoard(BoardCellState[] board)
        {
            return winDetector.Execute(board);
        }

        private WinDetector winDetector;
        
        [SetUp]
        public void Init()
        {
            winDetector = new WinDetector();
        }

        [Test]
        public void GivenEmptyBoard_ThenWinStateShouldBeUndecided()
        {
            WinStateWithEmptyBoard().ShouldEqual( Undecided );
        }
        
        [Test]
        public void GivenThreeCrossesInSequenceOnTopRow_ThenWinStateShouldBeCrossesWon()
        {
            WinStateWithBoard(new[] {
                X, X, X,
                _, _, _,
                _, _, _
            }).ShouldEqual( CrossesWon );
        }

    }
}
