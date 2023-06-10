using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WateringCan : MonoBehaviour
{
    public Slider waterSlider;
    public AudioSource waterSound;

    private ParticleSystem water;
    private bool isReady;

    void Start()
    {
        water = transform.GetChild(0).GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waterSlider.value > 0 && transform.eulerAngles.x > 30 && transform.eulerAngles.x < 70)
        {
            water.Play();
            waterSlider.value -= 0.002f;
        }
        else
        {
            water.Stop();
        }
    }

    public void ReadyToRefill()
    {
        isReady = true;
    }

    public void RefillWater()
    {
        if (isReady)
        {
            waterSound.Play();
            waterSlider.value = 1;
            isReady = false;
        }
        
    }
}
