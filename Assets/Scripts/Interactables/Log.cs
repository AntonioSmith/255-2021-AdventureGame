using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    void OnMouseDown() // When clicked...
    {
        if (Inventory.main.hasAxe) // if player has axe...
        {
            Inventory.main.hasLog = true; // hasLog is true
            Destroy(gameObject); // destroy log in scene
        }        
    }
}
