using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private float setTime = 60;

    private bool isGameOver = false;

    void Update()
    {
        if (!isGameOver)
        {
            setTime -= Time.deltaTime;
            if (setTime <= 0)
            {
                Debug.Log("Times UP! Game Over!");
                isGameOver = true;
            }
        }
    }
}
