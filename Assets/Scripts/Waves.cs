using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Bomb;

    private void OnTriggerEnter2D(Collider2D Enemy)
    {
        if (Enemy.tag == "Enemy1")
        {
            Enemy2.SetActive(true);
        }
        if (Enemy.tag == "Enemy2")
        {
            Enemy3.SetActive(true);
            Bomb.SetActive(true);
        }
        if (Enemy.tag == "Enemy3")
        {
            Enemy4.SetActive(true);
        }
        if (Enemy.tag == "Enemy4")
        {
            Enemy5.SetActive(true);
            Bomb.SetActive(false);
        }

    }

}
