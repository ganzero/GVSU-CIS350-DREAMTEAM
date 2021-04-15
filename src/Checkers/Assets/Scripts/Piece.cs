using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public bool isWhite;
    public bool isKing;

    public void isAKing(int x1, int y1)
    {
        if (isWhite && ((x1 <= 8) && (y1 == 7))) {
            //board has to be empty and white piece has to be at other end
            isKing = true;
        }
        else if (!isWhite && ((x1 <= 8) && (y1 == 0)))
        {
            //place has to be empty and black piece has to be at other end
            isKing = true;
        }
    }

    public bool ValidMove(Piece[,] board, int x1, int y1, int x2, int y2)
    {
        // Top of another piece
        if (board[x2, y2] != null)
            return false;

        int moveX = Mathf.Abs(x1 - x2);
        int moveY = y2 - y1;
        // Normal Move
        isAKing(x2, y2);
        if (isWhite || isKing)
        {
            if (moveX == 1)
            {
                if (moveY == 1)
                    return true;

            }
            // Capture Move
            else if (moveX == 2)
            {
                if (moveY == 2)
                {
                    Piece p = board[(x1 + x2) / 2, (y1 + y2) / 2];
                    if (p != null && p.isWhite != isWhite)
                        return true;
                }
            }
        }

        // Black checks different on Y axis
        if (!isWhite || isKing)
        {
            if (moveX == 1)
            {
                if (moveY == -1)
                    return true;

            }
            // Capture Move
            else if (moveX == 2)
            {
                if (moveY == -2)
                {
                    Piece p = board[(x1 + x2) / 2, (y1 + y2) / 2];
                    if (p != null && p.isWhite != isWhite)
                        return true;
                }
            }
        }


        return false;
    }
}