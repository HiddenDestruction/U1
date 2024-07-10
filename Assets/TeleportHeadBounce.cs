using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportHeadBounce : MonoBehaviour
{
    [SerializeField] private Transform teleport;
    public Vector3 respawn = Vector3.zero;
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("GroundChecker"))
    {
        other.transform.parent.transform.position = respawn;
    }
    else if (other.CompareTag("Player"))
    {
        other.transform.position = respawn;
    }
    else{

    }
}
}
