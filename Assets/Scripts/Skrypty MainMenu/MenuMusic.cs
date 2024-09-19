using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public AudioSource audioSource; // �r�d�o d�wi�ku dla muzyki w menu

    void Start()
    {
        // Upewnij si�, �e audioSource jest przypisane
        if (audioSource == null)
        {
            Debug.LogError("AudioSource is not assigned in MenuMusic.");
            return;
        }

        // Wczytaj g�o�no�� z MixerAudio i ustaw na audioSource
        SetVolumeFromMixer();

        // Odtw�rz muzyk�
        audioSource.Play();
    }

    private void SetVolumeFromMixer()
    {
        if (MixerAudio.Instance != null)
        {
            audioSource.volume = MixerAudio.Instance.Volume; // Ustaw g�o�no�� z MixerAudio
            Debug.Log("Menu music volume set to: " + audioSource.volume);
        }
        else
        {
            Debug.LogWarning("MixerAudio instance is null. Using default volume.");
        }
    }
}
