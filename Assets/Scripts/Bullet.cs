using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Sprawdzamy, czy pocisk trafi� w cel (tarcza)
        if (collision.gameObject.CompareTag("Target"))
        {
            // Pobierz nazw� tarczy i przekszta�� na poziom g�o�no�ci
            string targetName = collision.gameObject.name;

            // Zak�adamy, �e nazwy tarcz to "Target0", "Target1", ..., "Target10"
            if (int.TryParse(targetName.Replace("Target", ""), out int level))
            {
                // Ustaw poziom g�o�no�ci
                MixerAudio.Instance.Volume = level / 10.0f;
            }

            // Zniszcz pocisk po kolizji
            Destroy(gameObject);
        }
    }
}
