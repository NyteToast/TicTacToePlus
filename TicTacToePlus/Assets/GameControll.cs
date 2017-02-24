using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControll : MonoBehaviour {

    public int turn = 1;
    private int[][] grid = new int[][];
        { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            castRay();
        }
    }
    private void castRay()
    {
        
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);


        if (hit.collider != null)
        {
            //Detect Object Clicked Using Raycast
            switch (hit.transform.name)
            {
                case "TopLeft":
                    { Debug.Log("TL"); break; }
                case "TopMid":
                    { Debug.Log("TM"); break; }
                case "TopRight":
                    { Debug.Log("TR"); break; }
                case "MidLeft":
                    { Debug.Log("ML"); break; }
                case "MidMid":
                    { Debug.Log("MM"); break; }
                case "MidRight":
                    { Debug.Log("MR"); break; }
                case "BotLeft":
                    { Debug.Log("BL"); break; }
                case "BotMid":
                    { Debug.Log("BM"); break; }
                case "BotRight":
                    { Debug.Log("BR"); break; }
                default:
                    { Debug.Log("NO HIT"); break; }

            }
        }
    }

}
