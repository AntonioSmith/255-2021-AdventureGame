using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInstall : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false; // On start, get a reference to the lever renderer
    }

    private void OnMouseDown()
    {
        if (Inventory.main.leverVisible) // If the lever is visible...
        {
            Inventory.main.roomRotated = true; // set roomRotated to true
        }
    }
}
