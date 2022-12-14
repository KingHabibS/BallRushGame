using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBurst : MonoBehaviour
{
    
    public ParticleSystem collisionParticleSystem;
    public SpriteRenderer sr;
    public bool once = true;


    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && once)
        {

            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;

            em.enabled = true;
            collisionParticleSystem.Play();

            once = false;
            Destroy(sr);
            Invoke(nameof(DestroyObj), 0.2f);
            
        }
    }

    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
