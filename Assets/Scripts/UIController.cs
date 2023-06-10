using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject mainUI;
    public GameObject howToUI;
    public GameObject TomatoUI;
    public GameObject CabbageUI;
    public AudioSource startSound;

    public void StartGame()
    {
        mainUI.SetActive(false);
        TomatoUI.SetActive(true);
        CabbageUI.SetActive(true);
        startSound.Play();
    }

    public void HowTo()
    {
        mainUI.SetActive(false);
        howToUI.SetActive(true);
    }

    public void Back()
    {
        mainUI.SetActive(true);
        howToUI.SetActive(false);
    }
}
