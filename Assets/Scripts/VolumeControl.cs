using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MasterVolumeControl : MonoBehaviour
{
    // Referencja do AudioMixer
    public AudioMixer masterMixer;

    // Referencja do suwaka
    public Slider volumeSlider;

    void Start()
    {
        // Ustawienie pocz¹tkowej wartoœci suwaka (odczyt decybeli)
        float volume;
        masterMixer.GetFloat("SFXVolume", out volume);
        volumeSlider.value = Mathf.Pow(10, volume / 20f);

        // Subskrypcja zmiany wartoœci suwaka
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    // Metoda do ustawiania g³oœnoœci
    public void SetVolume(float sliderValue)
    {
        // Konwersja wartoœci z suwaka (0-1) na decybele (-80 do 0)
        float volume = Mathf.Log10(sliderValue) * 20;
        masterMixer.SetFloat("SFXVolume", volume);
    }
}
