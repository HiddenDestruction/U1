using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TpDoor : MonoBehaviour
{
    public Transform teleportDestination;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<granpa>() != null)
        {
            collision.transform.position = teleportDestination.position;
        }
    }
}