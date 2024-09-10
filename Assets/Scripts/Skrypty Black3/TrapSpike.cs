using UnityEngine;

public class TrapSpike : MonoBehaviour
{
    public Transform teleportDestination; // Punkt, do kt�rego gracz zostanie teleportowany

    void OnCollisionEnter(Collision collision)
    {
        // Sprawdzenie, czy obiekt, kt�ry wszed� w pu�apk�, to gracz
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
