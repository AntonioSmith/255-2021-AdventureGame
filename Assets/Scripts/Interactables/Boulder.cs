using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    void Update()
    {
        if (Inventory.main.boulderMoved) // if player moved the boulder...
        {
            Destroy(gameObject); // destroy boulder in scene
        }
    }
}
