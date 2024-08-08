using UnityEngine;

public class TeleportTrap : MonoBehaviour
{
    public Transform teleportTarget; // Miejsce docelowe teleportacji

    void OnTriggerEnter(Collider other)
    {
        // Sprawdzenie, czy obiekt, kt�ry wszed� w pu�apk�, to gracz
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other);
        }
    }

    void TeleportPlayer(Collider granpa)
    {
        // Teleportacja gracza do wybranego miejsca
        granpa.transform.position = teleportTarget.position;
        // Mo�esz doda� tu dodatkowe efekty, np. d�wi�k, efekt wizualny itp.
    }
}
