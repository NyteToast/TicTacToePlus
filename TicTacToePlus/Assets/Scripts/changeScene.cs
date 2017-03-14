using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{ 
    //changes the scene 
    public void goToScene(int scene)
    {
        Application.LoadLevel(scene);
    }

}
