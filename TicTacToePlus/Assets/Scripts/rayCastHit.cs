using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCastHit : MonoBehaviour {

    //calls castRay every frame only if the mouse has been pressed
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            castRay();
        }
    }
    //gameObject for GameController

    //gameobjects for each tile
    public GameObject TL, TM, TR, ML, MM, MR, BL, BM, BR;

    //use to call SpawnPiece in GameControll
    public GameControll GameControl;

    //assign the tiles to the gameobjects created earlier
    void Awake()
    {
        TL = GameObject.Find("TopLeft");
        TM = GameObject.Find("TopMid");
        TR = GameObject.Find("TopRight");
        ML = GameObject.Find("MidLeft");
        MM = GameObject.Find("MidMid");
        MR = GameObject.Find("MidRight");
        BL = GameObject.Find("BotLeft");
        BM = GameObject.Find("BotMid");
        BR = GameObject.Find("BotRight");
    }

    //checks to see if a mouse click is on a tile and calls SpawnPiece in GameControll with that tiles as a parameter
    private void castRay()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);


        if (hit.collider != null)
        {
            //Detect Object Clicked Using Raycast
            switch (hit.transform.name)
            {
                case "TopLeft":
                    {
                        Debug.Log("TL");
                        GameControl.SpawnPiece(TL.gameObject);
                        Debug.Log("SpawnPiece");
                        break;
                    }
                case "TopMid":
                    {
                        Debug.Log("TM");
                        GameControl.SpawnPiece(TM.gameObject);
                        Debug.Log("SpawnPiece");
                        break;
                    }
                case "TopRight":
                    {
                        Debug.Log("TR");
                        GameControl.SpawnPiece(TR.gameObject);
                        Debug.Log("SpawnPiece");
                        break;
                    }
                case "MidLeft":
                    {
                        Debug.Log("ML");
                        GameControl.SpawnPiece(ML.gameObject);
                        Debug.Log("SpawnPiece");
                        break;
                    }
                case "MidMid":
                    {
                        Debug.Log("MM");
                        GameControl.SpawnPiece(MM.gameObject);
                        Debug.Log("SpawnPiece");
                        break;
                    }
                case "MidRight":
                    {
                        Debug.Log("MR");
                        GameControl.SpawnPiece(MR.gameObject);
                        Debug.Log("SpawnPiece");
                        break;
                    }
                case "BotLeft":
                    {
                        Debug.Log("BL");
                        GameControl.SpawnPiece(BL.gameObject);
                        Debug.Log("SpawnPiece");
                        break;
                    }
                case "BotMid":
                    {
                        Debug.Log("BM");
                        GameControl.SpawnPiece(BM.gameObject);
                        Debug.Log("SpawnPiece");
                        break;
                    }
                case "BotRight":
                    {
                        Debug.Log("BR");
                        GameControl.SpawnPiece(BR.gameObject);
                        Debug.Log("SpawnPiece");
                        break;
                    }
                default:
                    { Debug.Log("NO HIT"); break; }

            }
        }
    }
}
