using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountCrobs : MonoBehaviour
{
    public Text crobText;
    public string crobName;

    private int crobCnt = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(crobName))
        {
            if(crobCnt < 9)
            {
                collision.gameObject.tag = "Untagged";
                crobCnt += 1;
                crobText.text = crobCnt.ToString();
            }
        }
    }
}
