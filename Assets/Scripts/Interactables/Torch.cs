using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    void OnMouseDown()
    {
        Inventory.main.hasTorch = true;
        Destroy(gameObject);
        print(Inventory.main.hasTorch);
    }
}
