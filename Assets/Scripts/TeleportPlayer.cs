using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform teleportTarget; 
    public GameObject Player;

    void OnMouseDown()
    {
        Player.transform.position = teleportTarget.transform.position;
    }
}
