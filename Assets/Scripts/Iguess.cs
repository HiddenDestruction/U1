using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iguess : MonoBehaviour
{
        void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        StartCoroutine(waiter());
        

    }
}

IEnumerator waiter()
{
    yield return new WaitForSeconds(5);
    gameObject.tag="Ground";
}
}
