using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource dungeonAudioSource;
    public AudioSource skyblockAudioSource;
    public Transform player;
    public Transform dungeonArea;
    public Transform skyblockArea;
    public float activationRadius = 10.0f;
    public float fadeSpeed = 1.0f; // Pr�dko�� przej�cia

    private float dungeonTargetVolume = 0.0f;
    private float skyblockTargetVolume = 0.0f;
    private float globalVolumeMultiplier = 1.0f; // Mno�nik g�o�no�ci (wczytywany z MixerAudio)

    void Start()
    {
        // Ustawienie pocz�tkowej g�o�no�ci na zero
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
            dungeonTargetVolume = 0.1f * globalVolumeMultiplier;
            skyblockTargetVolume = 0.0f;
        }
        else if (distanceToSkyblock < activationRadius)
        {
            dungeonTargetVolume = 0.0f;
            skyblockTargetVolume = 0.1f * globalVolumeMultiplier;
        }
        else
        {
            dungeonTargetVolume = 0.0f;
            skyblockTargetVolume = 0.0f;
        }

        // P�ynne przej�cie g�o�no�ci
        dungeonAudioSource.volume = Mathf.Lerp(dungeonAudioSource.volume, dungeonTargetVolume, fadeSpeed * Time.deltaTime);
        skyblockAudioSource.volume = Mathf.Lerp(skyblockAudioSource.volume, skyblockTargetVolume, fadeSpeed * Time.deltaTime);
    }

    // Funkcja do ustawiania g�o�no�ci z VolumeInitializer
    public void SetVolumes(float masterVolume)
    {
        globalVolumeMultiplier = masterVolume;
        // Mo�esz te� od razu zaktualizowa� bie��ce volume, je�li chcesz:
        dungeonAudioSource.volume = dungeonTargetVolume * globalVolumeMultiplier;
        skyblockAudioSource.volume = skyblockTargetVolume * globalVolumeMultiplier;
    }
}
