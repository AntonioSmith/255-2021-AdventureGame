using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeadTurn : MonoBehaviour
{
    public float turnSpeed = 70;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * turnSpeed / -1 * Time.deltaTime;
        transform.Rotate(vertical, horizontal, 0);
    }
}
