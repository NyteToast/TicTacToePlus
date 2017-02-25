using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{

    public void openMenu(int menu)
    {
        Application.LoadLevel(menu);
    }
}
