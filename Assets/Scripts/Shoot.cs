using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private Transform muzzle;

    private AudioSource audioSource;
    private bool shoot = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if (shoot)
        {
            GameObject spawnedBullet = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
            spawnedBullet.GetComponent<Rigidbody>().AddForce(speed * muzzle.forward, ForceMode.Impulse);
            audioSource.Play();

            Destroy(spawnedBullet, 2);

            shoot = false;
        }
    }

    public void Fire()
    {
        shoot = true;
    }
}
