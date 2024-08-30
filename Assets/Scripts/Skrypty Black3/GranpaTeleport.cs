using UnityEngine;

public class GranpaTeleport : MonoBehaviour
{
    public Transform teleportTarget; // Miejsce docelowe teleportacji
    public float fallThreshold = -20.0f; // Poziom Y, poni¿ej którego gracz zostanie teleportowany

    void Update()
    {
        // Sprawdzenie, czy gracz spad³ poni¿ej okreœlonego poziomu
        if (transform.position.y < fallThreshold)
        {
            TeleportPlayer();
        }
    }

    void TeleportPlayer()
    {
        // Teleportacja gracza do wybranego miejsca
        transform.position = teleportTarget.position;
    }
}
