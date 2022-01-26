using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpike : MonoBehaviour
{
    private const int V = 8;
    public AudioSource clip;


    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.CompareTag("Player"))
        {
            clip.Play(); //sonido de daño por enemigo
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }
}
