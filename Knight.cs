﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_Final {
    internal class Knight : Pieces {

        public Knight (string color, int row, int col) {
            this.Name = "Knight";
            this.PieceWorth = (float)3.0;
            this.Color = color;
            this.CurrentRow = row;
            this.CurrentCol = col;
            this.Image = ((System.Drawing.Image)(color=="White"?Properties.Resources.WKnight:Properties.Resources.BKnight));
        }

        public override int[,] PossibleMoves (Board board) {
            int[,] markArr = new int[8,8];
            int[] offsetI = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] offsetJ = { -1, 1, -2, 2, -2, 2, -1, 1 };
            int i, j, k;

            for (k = 0; k < 8; k++) {
                i = CurrentRow + offsetI[k];
                j = CurrentCol + offsetJ[k];
                if (IsWithinBoard (i, j)) {
                    if (board.PieceAt(i, j).Color != Color) {
                        markArr[i, j] = 1;
                    }
                }
            }

            return markArr;
        }
    }
}
