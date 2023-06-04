using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Can") || collision.gameObject.CompareTag("Glass") || collision.gameObject.CompareTag("Paper"))
        {
            GameObject.Find("Trashes").GetComponent<TrashesManager>().score += 1;
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                Debug.Log("Score: " +  GameObject.Find("Trashes").GetComponent<TrashesManager>().score);
            }
            else
            {
                Debug.Log("Left Enemies: " + (6 - GameObject.Find("Trashes").GetComponent<TrashesManager>().score));
            }
            audioSource.Play();
            Destroy(collision.gameObject);
        }
    }
}
