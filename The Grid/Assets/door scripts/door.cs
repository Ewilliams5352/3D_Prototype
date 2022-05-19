using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public Transform camera;
    public Transform cameraposition;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && camera != cameraposition)
        {
            camera.transform.position = cameraposition.transform.position;
            camera.transform.rotation = cameraposition.transform.rotation;
            Physics2D.SyncTransforms();
        }
    }
}
