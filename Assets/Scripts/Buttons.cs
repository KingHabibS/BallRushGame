using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Enemy)
    {
        if (Enemy.tag == "Play")
        {
            StartCoroutine(Timedelay1());
          
        }

        if (Enemy.tag == "Exit")
        {
            StartCoroutine(Timedelay2());
        }
    }

    IEnumerator Timedelay1()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("MainGame");
        Time.timeScale = 0;
    }

    IEnumerator Timedelay2()
    {
        yield return new WaitForSeconds(0.1f);
        Application.Quit();
    }

    IEnumerator Timedelay3()
    {
        yield return new WaitForSeconds(1);
        
    }
}
