using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform kamera;
    public void CameraYPlus()
    {
        Vector3 position = kamera.position;
        position.y -= 10;
        position.z += 10;
        kamera.position = position;
    }
    public void CameraYMinus()
    {
        Vector3 position = kamera.position;
        position.y += 10;
        position.z -= 10;
        kamera.position = position;
    }
}
