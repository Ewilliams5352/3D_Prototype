using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDownTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountDownTimer()
    {
        yield return new WaitForSeconds(waitTime);

        Die();
    }


    void Die()
    {
        Destroy(gameObject);
    }
}
