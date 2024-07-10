using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    // GameObject loaderObject;
    // LevelLoader loaderScript;

    void Start() { 
    //    loaderObject = GameObject.Find("LevelLoader");
    //    loaderScript = loaderObject.GetComponent<LevelLoader>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {       
        if (other.CompareTag("Bullet"))
        {
            print("wewe2");
            Application.Quit();
        }
    }
}
