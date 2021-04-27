using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    void OnMouseDown() // When clicked...
    {
        Inventory.main.hasAxe = true; // player has axe is true
        Destroy(gameObject); // destroy axe in scene
    }
}
