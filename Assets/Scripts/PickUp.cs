using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject Pickup;
    //private GameObject HandTorch_Base;
    //private GameObject Gear;
    void OnMouseDown()
    {
        Destroy(Pickup);
        //if (Pickup = HandTorch_Base)
        //{
        //    print("got torch");
        //    Inventory._main.hasTorch = true;
        //    //Destroy(gameObject);
        //}
    }
}
