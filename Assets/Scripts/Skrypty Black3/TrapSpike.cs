using UnityEngine;

public class TrapSpike : MonoBehaviour
{
    public Transform teleportDestination; // Punkt, do którego gracz zostanie teleportowany

    void OnCollisionEnter(Collision collision)
    {
        // Sprawdzenie, czy obiekt, który wszed³ w pu³apkê, to gracz
        if (collision.gameObject.name == "granpa")
        {
            // Teleportowanie gracza do wyznaczonego miejsca
            collision.gameObject.transform.position = teleportDestination.position;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            // Teleportowanie gracza do wyznaczonego miejsca
            collision.gameObject.transform.position = teleportDestination.position;
        }
    }
}
