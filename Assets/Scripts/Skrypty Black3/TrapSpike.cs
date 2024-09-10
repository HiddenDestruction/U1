using UnityEngine;

public class Trap : MonoBehaviour
{
    public Transform startPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = startPosition.position;
        }
    }
}
