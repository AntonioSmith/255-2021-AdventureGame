using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverInstall : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    private void OnMouseDown()
    {
        if (Inventory._main.leverVisible)
        {
            print("lever moved");
            Inventory._main.roomRotated = true;
        }
    }
}
