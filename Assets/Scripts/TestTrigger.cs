using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger hit by: " + other.gameObject.name);
    }
}
