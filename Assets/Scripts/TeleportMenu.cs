using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportMenu : MonoBehaviour
{
    public int delay = 11;
    public GameObject dead;

    void OnTriggerEnter2D(Collider2D other)
{

    if (other.CompareTag("GroundChecker"))
    {
        other.transform.parent.transform.position = new Vector3 (0, 0, -15);
        GameObject kekw = Instantiate(dead, new Vector3(0, 0, -15), Quaternion.identity);
        Destroy (kekw, delay);
    }
    else if (other.CompareTag("Player"))
    {
        other.transform.position = new Vector3 (0, 0, -15);
        GameObject kekw = Instantiate(dead, new Vector3(0, 0, -15), Quaternion.identity);
        Destroy (kekw, delay);
    }
}

}