using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControll : MonoBehaviour {

    //gameobjects to store the balcksquare and greensquare
    public GameObject cross, naught;

    //used to show the state of the cell
    public enum cellState { empty, cross, naught };

    //keeps track of whos turn it is
    public cellState playerTurn;

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
        Destroy(clickedCell.gameObject);

    }






}
