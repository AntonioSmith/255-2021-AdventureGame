using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    void OnMouseDown()
    {
        print("got lever");
        Inventory._main.hasLever = true;
        Destroy(gameObject);
        print(Inventory._main.hasLever);
    }
}
