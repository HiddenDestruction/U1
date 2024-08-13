using UnityEngine;

public class TrapScript : MonoBehaviour
{
    public Transform teleportDestination; // Miejsce, do ktÛrego bÍdzie teleportowany "Grandpa"
    public GameObject grandpa; // Obiekt reprezentujπcy "Grandpa"
    public AudioClip trapSound; // DüwiÍk pu≥apki
    public AudioSource audioSource; // èrÛd≥o düwiÍku

    private void OnTriggerEnter(Collider other)
    {
        // Sprawdza, czy obiekt, ktÛry aktywuje pu≥apkÍ, ma okreúlony tag (np. "Player")
        if (other.CompareTag("Player"))
        {
            ActivateTrap();
        }
    }

    private void ActivateTrap()
    {
        // Odtwarzanie düwiÍku
        if (trapSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(trapSound);
        }

        // Teleportacja "Grandpa"
        if (grandpa != null && teleportDestination != null)
        {
            grandpa.transform.position = teleportDestination.position;
        }
    }
}
