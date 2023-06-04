using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UTSShoot : MonoBehaviour
{
    public ParticleSystem shootParticle;
    public GameObject TrashParent;

    private AudioSource audioSource;
    private bool shoot = false;
    private Transform[] trashList;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        trashList = TrashParent.GetComponentsInChildren<Transform>();
    }

    void FixedUpdate()
    {
        if (shoot)
        {
            audioSource.Play();
            shootParticle.Play();
            foreach(Transform trash in TrashParent.transform)
            {
                Destroy(trash.gameObject);
            }

            shoot = false;
        }
    }

    public void Fire()
    {
        shoot = true;
    }
}
