using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    void OnMouseDown()
    {
        print("got axe");
        Inventory._main.hasAxe = true;
        Destroy(gameObject);
        print(Inventory._main.hasAxe);
    }
}
