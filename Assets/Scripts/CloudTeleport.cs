using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloudTeleport : MonoBehaviour
{
    public bool CloudShot = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (CloudShot)
        {
            LoadCloudsLevel();
            CloudShot = false;
        }
    }

    public void LoadCloudsLevel()
    {
        StartCoroutine(LoadScene("Clouds"));
    }

    IEnumerator LoadScene(string sceneName)
    {
        yield return null;

        SceneManager.LoadScene(sceneName);
     }
}