using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    void OnMouseDown() // When clicked
    {
        Inventory.main.hasLever = true; // hasLever is true
        Destroy(gameObject); // Destroy Game Object
    }
}
