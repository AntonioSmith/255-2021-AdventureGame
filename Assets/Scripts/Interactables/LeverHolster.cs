using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverHolster : MonoBehaviour
{
    void OnMouseDown()
    {
        if (Inventory.main.hasLever) // If player has the lever...
        {
            Inventory.main.holsterActive = true; // holsterActive is true
            if (Inventory.main.holsterActive) // If holsterActive is true...
            {
                Inventory.main.leverVisible = true; // leverVisible is true
            }
        }
    }
}
