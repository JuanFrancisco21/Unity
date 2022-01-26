using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerRespawn : MonoBehaviour
{
    public GameObject player;
    public Transform SpawnPoint;
    public Animator animator;

    public void PlayerDamaged(){
        animator.Play("hit");
        
        player.transform.position = SpawnPoint.transform.position;
    }
}
