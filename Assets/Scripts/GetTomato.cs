using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTomato : MonoBehaviour
{
    public AudioSource sliceSound;
    private GameObject tomato;
    void Start()
    {
        tomato = transform.GetChild(2).gameObject;
    }

    public void dropTomato()
    {
        tomato.SetActive(true);
        sliceSound.Play();
    }
}
