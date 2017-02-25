using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControll : MonoBehaviour {

    //gameobjects to store the blacksquare and greensquare
    public GameObject cross, naught;

    //used to show the state of the cell
    public enum cellState { empty, cross, naught };

    //keeps track of whos turn it is
    public cellState playerTurn;

    //public cellState[][] grid = new cellState[][];

    //stores who turn is next
    public Text turn;

    void Awake()
    {
        turn.text = playerTurn.ToString();
    }

    //it recieves the tile it need to change and changes it based off whos turn it currently is
    public void SpawnPiece(GameObject clickedCell)
    {

        if (playerTurn == cellState.cross)
        {
            Instantiate(cross, clickedCell.transform.position, Quaternion.identity);
            playerTurn = cellState.naught;
        }
        else
        {
            Instantiate(naught, clickedCell.transform.position, Quaternion.identity);
            playerTurn = cellState.cross;
        }

        turn.text = playerTurn.ToString();
        Destroy(clickedCell.gameObject);
    }
}







