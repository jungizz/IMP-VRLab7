using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GetCabbage : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        if(transform.localScale.x <= 0.6f)
        {
            transform.localScale *= 1.01f;

        }
        else
        {
            transform.GetComponent<XRGrabInteractable>().enabled = true;
        }
    }
}
