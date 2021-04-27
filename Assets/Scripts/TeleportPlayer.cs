using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    /// <summary>
    /// Variable that references the location of the teleport pad
    /// </summary>
    public Transform teleportTarget;

    /// <summary>
    /// Variable that references the player Game Object
    /// </summary>
    public GameObject Player;

    /// <summary>
    /// Variable that references the players rotation
    /// </summary>
    public Transform playerRotation;

    /// <summary>
    /// Variable that references the players ORIGINAL rotation
    /// </summary>
    private Transform playerOriginalRotation;

    public void Start()
    {
        playerOriginalRotation = playerRotation;
    }

    void OnMouseDown()
    {
        Player.transform.position = teleportTarget.transform.position + (transform.up * 1.1f);
        playerRotation = playerOriginalRotation;
    }
}
