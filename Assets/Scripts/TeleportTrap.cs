using UnityEngine;

public class TeleportTrap : MonoBehaviour
{
    public Transform teleportTarget; // Miejsce docelowe teleportacji

    void OnTriggerEnter(Collider other)
    {
        // Sprawdzenie, czy obiekt, który wszed³ w pu³apkê, to gracz
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other);
        }
    }

    void TeleportPlayer(Collider granpa)
    {
        // Teleportacja gracza do wybranego miejsca
        granpa.transform.position = teleportTarget.position;
        // Mo¿esz dodaæ tu dodatkowe efekty, np. dŸwiêk, efekt wizualny itp.
    }
}
