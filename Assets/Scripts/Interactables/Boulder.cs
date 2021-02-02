using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    void Update()
    {
        if (Inventory._main.boulderMoved)
        {
            Destroy(gameObject);
        }
    }
}
