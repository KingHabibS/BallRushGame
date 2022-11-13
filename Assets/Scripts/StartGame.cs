using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    public GameObject TheStartButton;


    public void StartButton()
    {
        Time.timeScale = 1;
        TheStartButton.SetActive(false);
    }
}
