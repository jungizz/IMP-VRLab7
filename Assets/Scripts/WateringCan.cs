using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WateringCan : MonoBehaviour
{
    private ParticleSystem water;

    void Start()
    {
        water = transform.GetChild(0).GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.x > 30 && transform.eulerAngles.x < 70)
        {
            water.Play();
        }
        else
        {
            water.Stop();
        }
    }
}
