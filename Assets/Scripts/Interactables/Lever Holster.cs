using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverHolster : MonoBehaviour
{
    void OnMouseDown()
    {
        if (Inventory._main.hasLever)
        {
            print("holster active");
            Inventory._main.holsterActive = true;
            if (Inventory._main.holsterActive)
            {
                print("lever interactable");
                Inventory._main.leverVisible = true;
            }
        }
    }
}
