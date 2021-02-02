using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    void OnMouseDown()
    {
        if (Inventory._main.hasAxe)
        {
            print("got log");
            Inventory._main.hasLog = true;
            Destroy(gameObject);
            print(Inventory._main.hasLog);
        }        
    }
}
