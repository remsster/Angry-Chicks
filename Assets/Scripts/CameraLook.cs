using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float LookSpeed = 3f;
    public Transform Body;
    public Camera LookCamera;
    private Vector2 Rotation = Vector2.zero;

    private void Update()
    {
        Rotation.y += Input.GetAxis("Mouse X");
        Rotation.x -= Input.GetAxis("Mouse Y");

        Vector2 RotThisSetp = Rotation * LookSpeed;
        Body.eulerAngles = new Vector2(0, RotThisSetp.y);
        LookCamera.transform.localRotation = Quaternion.Euler(RotThisSetp.x, 0, 0);

    }
}
