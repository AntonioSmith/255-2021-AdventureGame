using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeadTurn : MonoBehaviour
{
    public float turnSpeed = 60;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
        transform.Rotate(vertical, 0, 0);
    }
}
