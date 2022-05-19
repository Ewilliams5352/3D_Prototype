using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyscript : MonoBehaviour
{
    public bool HasKey1 = false;
    public bool HasKey2 = false;
    public bool HasKey3 = false;
    public bool HasExitKey = false;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Key1"))
        {
            HasKey1 = true;
            Destroy(other.gameObject);
            Debug.Log("key1 aquired");
        }
        if (other.gameObject.CompareTag("Key2"))
        {
            HasKey2 = true;
            Destroy(other.gameObject);
            Debug.Log("key2 aquired");
        }
        if (other.gameObject.CompareTag("Key3"))
        {
            HasKey3 = true;
            Destroy(other.gameObject);
            Debug.Log("key3 aquired");
        }
        if (other.gameObject.CompareTag("ExitKey"))
        {
            HasExitKey = true;
            Destroy(other.gameObject);
            Debug.Log("can exit");
        }
        if (other.gameObject.CompareTag("Door1") && HasKey1 == true)
        {
            HasKey1 = false;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Door2") && HasKey2 == true)
        {
            HasKey2 = false;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Door3") && HasKey3 == true)
        {
            HasKey3 = false;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("ExitDoor") && HasExitKey == true)
        {
            HasExitKey = false;
            Destroy(other.gameObject);
        }
    }
}
