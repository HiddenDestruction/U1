using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudTrap : MonoBehaviour
{
     public GameObject Iguess;
     bool neverDone = false;

void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Player") && neverDone == false)
    {
        neverDone = true;
        Instantiate(Iguess, new Vector3(10, 6, -6), Quaternion.identity);

    }
}

}
