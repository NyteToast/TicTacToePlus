using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class GameControll : MonoBehaviour {

    public AudioClip[] audioclip;
    private AudioSource source;
    public int trackNumber = 0;

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
        Debug.Log(audioclip.Length);
        source = GetComponent<AudioSource>();
        turn.text = playerTurn.ToString();
    }

    void Update()
    {
            if (trackNumber == audioclip.Length-1)
            {
                trackNumber = 0;
            }
            else
            {
                trackNumber++;
            }
    }

    //it recieves the tile it need to change and changes it based off whos turn it currently is
    public void SpawnPiece(GameObject clickedCell)
    {
        
        if (playerTurn == cellState.cross)
        {
           PlaySound(0);
            cross = Instantiate(cross, clickedCell.transform.position, Quaternion.identity);
            cross.transform.parent = GameObject.Find("Game").transform;
            playerTurn = cellState.naught;
        }
        else
        {
            PlaySound(1);
            naught = Instantiate(naught, clickedCell.transform.position, Quaternion.identity);
            naught.transform.parent = GameObject.Find("Game").transform;
            playerTurn = cellState.cross;
        }

        turn.text = playerTurn.ToString();
        Destroy(clickedCell.gameObject);
    }


    public void PlaySound(int clip) {
        source.clip = audioclip[clip];
        source.Play();
    }
}







