using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTeleporter : MonoBehaviour
{
    // Nazwa sceny, do kt�rej chcesz teleportowa� gracza
    public string targetScene = "Clouds";

    // Pozycja, w kt�rej gracz pojawi si� w nowej scenie
    public Vector3 targetPosition;

    // Funkcja wywo�ywana, gdy gracz wejdzie w stref� teleportacji
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Zapisz pozycj� gracza do u�ycia w nowej scenie
            PlayerPrefs.SetFloat("PlayerX", targetPosition.x);
            PlayerPrefs.SetFloat("PlayerY", targetPosition.y);
            PlayerPrefs.SetFloat("PlayerZ", targetPosition.z);

            // Za�aduj now� scen�
            SceneManager.LoadScene(targetScene);
        }
    }
}
