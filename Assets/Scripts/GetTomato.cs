using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTomato : MonoBehaviour
{
    private GameObject tomato;
    void Start()
    {
        tomato = transform.GetChild(2).gameObject;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            tomato.SetActive(true);
        }
    }
}
