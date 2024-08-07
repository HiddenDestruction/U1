using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource dungeonAudioSource;
    public AudioSource skyblockAudioSource;
    public Transform player;
    public Transform dungeonArea;
    public Transform skyblockArea;
    public float activationRadius = 10.0f;
    public float fadeSpeed = 1.0f; // Prêdkoœæ przejœcia

    private float dungeonTargetVolume = 0.0f;
    private float skyblockTargetVolume = 0.0f;

    void Start()
    {
        // Ustawienie pocz¹tkowej g³oœnoœci na zero
        dungeonAudioSource.volume = 0.0f;
        skyblockAudioSource.volume = 0.0f;
        dungeonAudioSource.Play();
        skyblockAudioSource.Play();
    }

    void Update()
    {
        float distanceToDungeon = Vector3.Distance(player.position, dungeonArea.position);
        float distanceToSkyblock = Vector3.Distance(player.position, skyblockArea.position);

        if (distanceToDungeon < activationRadius)
        {
            dungeonTargetVolume = 0.2f;
            skyblockTargetVolume = 0.0f;
        }
        else if (distanceToSkyblock < activationRadius)
        {
            dungeonTargetVolume = 0.0f;
            skyblockTargetVolume = 0.2f;
        }
        else
        {
            dungeonTargetVolume = 0.0f;
            skyblockTargetVolume = 0.0f;
        }

        // P³ynne przejœcie g³oœnoœci
        dungeonAudioSource.volume = Mathf.Lerp(dungeonAudioSource.volume, dungeonTargetVolume, fadeSpeed * Time.deltaTime);
        skyblockAudioSource.volume = Mathf.Lerp(skyblockAudioSource.volume, skyblockTargetVolume, fadeSpeed * Time.deltaTime);
    }
}
