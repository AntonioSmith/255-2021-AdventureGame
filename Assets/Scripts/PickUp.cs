using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    /// <summary>
    /// Variable referencing the object that was clicked on
    /// </summary>
    public GameObject Pickup; 

    void OnMouseDown()
    {
        Destroy(Pickup); // Destroys the object when picked up
    }
}
