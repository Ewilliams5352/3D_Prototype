using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{

    public GameObject spike;
    public Transform spikePos;
    bool activated;

    public float waitTime;
    void FixedUpdate()
    {
        if (activated == false)
        {
            StartCoroutine(popUp());
        }
    }



    IEnumerator popUp()
    {
        activated = true;
        yield return new WaitForSeconds(waitTime);

        GameObject newSpike = Instantiate(spike, spikePos.position, Quaternion.identity);

        activated = false;
    }


















}