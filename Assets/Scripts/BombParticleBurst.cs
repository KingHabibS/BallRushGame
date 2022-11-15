using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombParticleBurst : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;
    public ParticleSystem deathParticleSystem;
    public SpriteRenderer sr;
    public SpriteRenderer sr2;
    public bool once = true;
    public GameObject Player;
    public GameObject GameOverScreen;


    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && once)
        {
            //bomb death
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;

            em.enabled = true;
            collisionParticleSystem.Play();

            //player death
            var em1 = deathParticleSystem.emission;
            var dur2 = deathParticleSystem.duration;

            em1.enabled = true;
            deathParticleSystem.Play();


            once = false;
            Destroy(sr);
            Destroy(sr2);
            Invoke(nameof(DestroyObj), 0.15f);
            Invoke(nameof(GameOver), 0.05f);


        }
    }

    void DestroyObj()
    {
        Destroy(gameObject);
        Destroy(Player.gameObject);
    }

    void GameOver()
    {
        Time.timeScale = 0;
        GameOverScreen.SetActive(true);
    }
}

