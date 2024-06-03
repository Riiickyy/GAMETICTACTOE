using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMETICTACTOE
{
    using System;

    abstract class GameDeterminer
    {
        protected char[,] table;

        public GameDeterminer(char[,] initialTable)
        {
            table = initialTable;
        }

        public abstract char CheckWinner();
    }

    class TicTacToeDeterminer : GameDeterminer
    {
        public TicTacToeDeterminer(char[,] initialTable) : base(initialTable) { }
        public override char CheckWinner()
        {
            // Check rows
            for (int v = 0; v < 3; v++)
            {
                if (table[v, 0] != '-' && table[v, 0] == table[v, 1] && table[v, 1] == table[v, 2])
                {
                    return table[v, 0];
                }
            }

            // Check columns
            for (int b = 0; b < 3; b++)
            {
                if (table[0, b] != '-' && table[0, b] == table[1, b] && table[1, b] == table[2, b])
                {
                    return table[0, b];
                }
            }

            // Check diagonals
            if (table[1, 1] != '-')
            {
                if (table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2])
                {
                    return table[1, 1];
                }
                if (table[0, 2] == table[1, 1] && table[1, 1] == table[2, 0])
                {
                    return table[1, 1];
                }
            }

            return '-';
        }
    }

    internal class GameDeerminer
    {
    }
}
