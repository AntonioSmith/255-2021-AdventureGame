using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedastal : MonoBehaviour
{
    void OnMouseDown()
    {
        if (Inventory._main.hasLog)
        {
            print("pedastal active");
            Inventory._main.pedastalActive = true;
            if (Inventory._main.pedastalActive)
            {
                print("boulder moved");
                Inventory._main.boulderMoved = true;
                Destroy(gameObject);

            }
        }        
    }
}
