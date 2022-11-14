using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;

    private void OnTriggerEnter2D(Collider2D Enemy)
    {
        if (Enemy.tag == "Enemy1")
        {
            Enemy2.SetActive(true);
        }
        if (Enemy.tag == "Enemy2")
        {
            Enemy3.SetActive(true);
            Enemy4.SetActive(true);
        }
    }

}
