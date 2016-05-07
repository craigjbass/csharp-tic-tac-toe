using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicTacToe.WinDetector.BoardCellState;

namespace TicTacToe
{
    public class WinDetector
    {
        public WinState Execute( BoardCellState[] board )
        {
            if (board[0].Equals(X))
            {
                return WinState.CrossesWon;
            }
            return WinState.Undecided;
        }

        public enum BoardCellState
        {
            _,X,O
        }

        public enum WinState
        {
            Undecided,
            CrossesWon,
            NoughtsWon,
            Draw
        }
    }
}
