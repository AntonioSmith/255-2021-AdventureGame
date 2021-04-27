using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeadTurn : MonoBehaviour
{
    /// <summary>
    /// Variable that sets the turn speed of the player
    /// </summary>
    public float turnSpeed = 70;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime; // sets the horizontal rotation speed
        float vertical = Input.GetAxis("Vertical") * turnSpeed / -1 * Time.deltaTime; // sets the vertical rotation speed
        transform.Rotate(vertical, horizontal, 0); // rotates the player
    }
}
