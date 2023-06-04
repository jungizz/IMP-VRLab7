using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrashes : MonoBehaviour
{
    public GameObject[] ObjectToInstantiates;

    private float waitTime = 1.5f;
    private int randParam;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(1f);
        while (true)
        {
            randParam = Random.Range(0, 3);
            yield return new WaitForSeconds(Random.Range(waitTime, waitTime * 2));

            GameObject temp;
            if (randParam == 0)
            {
                temp = Instantiate(ObjectToInstantiates[0], new Vector3(Random.Range(-2.5f, 2.5f), 0, 62f), Quaternion.identity);
                temp.transform.parent = transform;
            }
            else if (randParam == 1)
            {
                temp = Instantiate(ObjectToInstantiates[1], new Vector3(Random.Range(-2.5f, 2.5f), 0, 62f), Quaternion.identity);
                temp.transform.parent = transform;
            }
            
            else if (randParam == 2)
            {
                temp = Instantiate(ObjectToInstantiates[2], new Vector3(Random.Range(-2.5f, 2.5f), 0, 62f), Quaternion.identity);
                temp.transform.parent = transform;
            }
                
        }
    }
}
