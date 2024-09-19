using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Dodajemy zarz¹dzanie scenami

public class OptionsButton : MonoBehaviour
{
    GameObject loaderObject;
    LevelLoader loaderScript;

    void Start()
    {
        loaderObject = GameObject.Find("LevelLoader");
        loaderScript = loaderObject.GetComponent<LevelLoader>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            print("Opcje zosta³y wybrane");
            loaderScript.startButtonShot = true;

            SceneManager.LoadScene(1);
        }
    }
}
