using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    public AudioSource clip;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.CompareTag("Player"))
        {
            clip.Play();
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }

}
