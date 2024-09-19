using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public AudioSource audioSource; // èrÛd≥o düwiÍku dla muzyki w menu

    void Start()
    {
        // Upewnij siÍ, øe audioSource jest przypisane
        if (audioSource == null)
        {
            Debug.LogError("AudioSource is not assigned in MenuMusic.");
            return;
        }

        // Wczytaj g≥oúnoúÊ z MixerAudio i ustaw na audioSource
        SetVolumeFromMixer();

        // OdtwÛrz muzykÍ
        audioSource.Play();
    }

    private void SetVolumeFromMixer()
    {
        if (MixerAudio.Instance != null)
        {
            audioSource.volume = MixerAudio.Instance.Volume; // Ustaw g≥oúnoúÊ z MixerAudio
            Debug.Log("Menu music volume set to: " + audioSource.volume);
        }
        else
        {
            Debug.LogWarning("MixerAudio instance is null. Using default volume.");
        }
    }
}
