using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    void OnMouseDown()
    {
        print("got torch");
        Inventory._main.hasTorch = true;
        Destroy(gameObject);
    }
}
