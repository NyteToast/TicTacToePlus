using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{

    private int[,] grid;
    private int boardSize = 3;
    private int movesTaken = 0;

    // Use this for initialization
    void Start()
    {
        grid = new int[boardSize, boardSize];

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void addPiece(int x, int y, int piece)
    {
        if (grid[x, y] == 0)
        {
            grid[x, y] = piece;
            Debug.Log("PIECE: " + x + " : " + y);
            movesTaken++;
            checkWin(x,y,piece);
            
        }
    }
    private void checkWin(int x, int y, int piece)
    {
        if (piece == 1) { checkPlayer1Win(x, y); }
        else if (piece == 2) { checkPlayer2Win(x,y); }
        if (movesTaken == boardSize * boardSize) { checkDraw(); }
        
    }
    private void checkPlayer1Win(int x, int y) {
        int v2 = y - 1;
        int h2 = x - 1;
        if (x == 0) { h2 = 0; }
        if (y == 0) { v2 = 0; }

        for (int v = v2; v <= y + 1; v++) {
            for (int h = h2; h <= x + 1; h++) {
                if (grid[h, v] == 1 && grid[(h-(x-h)),(v-(y-v))] == 1) {
                    Debug.Log("X wins");
                }
            }
        }
    }
    private void checkPlayer2Win(int x, int y) {
        int v2 = y - 1;
        int h2 = x - 1;
        if (x == 0) { h2 = 0; }
        if (y == 0) { v2 = 0; }

        for (int v = v2; v <= y + 1; v++)
        {
            for (int h = h2; h <= x + 1; h++)
            {
                if (grid[h, v] == 2 && grid[(h - (x - h)), (v - (y - v))] == 2)
                {
                    Debug.Log("O wins");
                }
            }
        }
    }
    private void checkDraw() { }
}
