using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    public GameObject spike;
    public Transform spikePos;
    public float waitTime;
    Vector3 spikeVector;

    void FixedUpdate()
    {
        StartCoroutine(spikePop());
    }

    IEnumerator spikePop()
    {
        GameObject spikes = GameObject.FindGameObjectWithTag("spike");
        Destroy(spikes);
        yield return new WaitForSeconds(waitTime);
        Instantiate(spike, spikePos.position, Quaternion.identity);
    }
}
