using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillThePlayer : MonoBehaviour
{
    public Vector3 respawn = Vector3.zero;
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("GroundChecker"))
    {
        Destroy(transform.parent.gameObject);
        other.transform.parent.transform.position = respawn;
    }
    else if (other.CompareTag("Player"))
    {
        Destroy(transform.parent.gameObject);
        other.transform.position = respawn;
    }

}
}
