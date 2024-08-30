using UnityEngine;

public class TrapScript : MonoBehaviour
{
    public Transform teleportDestination; // Miejsce, do kt�rego b�dzie teleportowany "Grandpa"
    public GameObject grandpa; // Obiekt reprezentuj�cy "Grandpa"
    public AudioClip trapSound; // D�wi�k pu�apki
    public AudioSource audioSource; // �r�d�o d�wi�ku

    private void OnTriggerEnter(Collider other)
    {
        // Sprawdza, czy obiekt, kt�ry aktywuje pu�apk�, ma okre�lony tag (np. "Player")
        if (other.CompareTag("Player"))
        {
            ActivateTrap();
        }
    }

    private void ActivateTrap()
    {
        // Odtwarzanie d�wi�ku
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
