using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    public GameObject spike;
    public Transform spikePos;
    public float waitTime;
    Vector3 spikeVector;


    void Update()
    {
        StartCoroutine(wait());
    }

    void spikePop()
    {
        GameObject spikes = GameObject.FindGameObjectWithTag("Spike");
        Destroy(spikes);
        Debug.Log("Destroy Spike");
        GameObject newspike = Instantiate(spike, spikePos.position, Quaternion.identity);
        Debug.Log("Spawn spike");
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(waitTime);
        spikePop();
    }
}