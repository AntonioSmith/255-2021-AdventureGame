using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedastal : MonoBehaviour
{
    void OnMouseDown() // When clicked...
    {
        if (Inventory.main.hasLog) // If player has log...
        {
            Inventory.main.pedastalActive = true; // pedastalActive is true
            if (Inventory.main.pedastalActive) // if pedastalActive is true...
            {
                Inventory.main.boulderMoved = true; // boulderMoved is true
                Destroy(gameObject); // Destroy the pedastal

            }
        }        
    }
}
