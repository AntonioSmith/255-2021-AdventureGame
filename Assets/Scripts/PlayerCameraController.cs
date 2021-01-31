using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    #region Variables
    float pitch = 0; // Tilt of camera VERTICAL
    float targetPitch = 0;
    float yaw = 0; // Yaw angle of camera HORIZONTAL
    float targetYaw = 0;
    public float mouseSensitivityX = 1; // scales veritcal mouse input
    public float mouseSensitivityY = 1; // scales horizontal mouse input

    private Camera cam;
    #endregion

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
            //float mouseY = Input.GetAxis("Mouse Y");
            float mouseX = Input.GetAxis("Mouse X");

            targetYaw += mouseX * mouseSensitivityX;
            //targetPitch += mouseY * mouseSensitivityY;

        //targetPitch = Mathf.Clamp(targetPitch, -.75f, 4); // Vertical Camera Clamp
        targetYaw = Mathf.Clamp(targetYaw, -10, 10); // Horizontal Camera Clamp

        //pitch = AnimMath.Slide(pitch, targetPitch, .10f); // EASE
        yaw = AnimMath.Slide(yaw, targetYaw, .10f); // EASE

        transform.rotation = Quaternion.Euler(pitch, yaw, 0);
        print ("Pitch: " + pitch);
        print ("Yaw: " + yaw);
    }
}
