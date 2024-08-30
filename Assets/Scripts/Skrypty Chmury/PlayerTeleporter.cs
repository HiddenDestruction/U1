using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTeleporter : MonoBehaviour
{
    // Nazwa sceny, do której chcesz teleportowaæ gracza
    public string targetScene = "Clouds";

    // Pozycja, w której gracz pojawi siê w nowej scenie
    public Vector3 targetPosition;

    // Funkcja wywo³ywana, gdy gracz wejdzie w strefê teleportacji
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Zapisz pozycjê gracza do u¿ycia w nowej scenie
            PlayerPrefs.SetFloat("PlayerX", targetPosition.x);
            PlayerPrefs.SetFloat("PlayerY", targetPosition.y);
            PlayerPrefs.SetFloat("PlayerZ", targetPosition.z);

            // Za³aduj now¹ scenê
            SceneManager.LoadScene(targetScene);
        }
    }
}
