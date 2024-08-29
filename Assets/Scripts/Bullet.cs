using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Sprawdzamy, czy pocisk trafi³ w cel (tarcza)
        if (collision.gameObject.CompareTag("Target"))
        {
            // Pobierz nazwê tarczy i przekszta³æ na poziom g³oœnoœci
            string targetName = collision.gameObject.name;

            // Zak³adamy, ¿e nazwy tarcz to "Target0", "Target1", ..., "Target10"
            if (int.TryParse(targetName.Replace("Target", ""), out int level))
            {
                // Ustaw poziom g³oœnoœci
                MixerAudio.Instance.Volume = level / 10.0f;
            }

            // Zniszcz pocisk po kolizji
            Destroy(gameObject);
        }
    }
}
