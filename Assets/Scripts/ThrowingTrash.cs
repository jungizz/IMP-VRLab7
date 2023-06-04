using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingTrash : MonoBehaviour
{
    public string recycleType;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(recycleType))
        {
            GameObject.Find("Trashes").GetComponent<TrashesManager>().score += 1;
            Debug.Log("Score: " + GameObject.Find("Trashes").GetComponent<TrashesManager>().score);
            Destroy(collision.gameObject);            
        }
    }
}
