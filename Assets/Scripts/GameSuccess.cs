using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSuccess : MonoBehaviour
{
    public Text TomatoCnt;
    public Text CabbageCnt;
    public GameObject SuccessUI;
    public AudioSource SuccessSound;

    private bool isSuccess = true;

    private void Update()
    {
        if (isSuccess && TomatoCnt.text == "9" && CabbageCnt.text == "9")
        {
            SuccessUI.SetActive(true);
            SuccessSound.Play();
            isSuccess = false;
        }
    }
}
