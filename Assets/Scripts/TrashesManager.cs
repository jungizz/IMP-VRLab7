using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashesManager : MonoBehaviour
{
    [HideInInspector]
    public int score = 0;

    private bool isClear = false;

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (GameObject.Find("Trashes").transform.childCount == 0 && !isClear)
            {
                Debug.Log("Level Clear!");
                isClear = true;
            }
        }
        else
        {
            if (score == 6 && !isClear)
            {
                Debug.Log("Level Clear!");
                isClear = true;
            }
        }
        
    }
}
