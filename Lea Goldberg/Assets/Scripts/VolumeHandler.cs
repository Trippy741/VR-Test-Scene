using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine;

public class VolumeHandler : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider volumeSlider;
    private float sliderValue;
    private float mainVolume;
    private void OnEnable()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("MainVolumeValue", sliderValue);
    }
    private void OnDisable()
    {
        PlayerPrefs.SetFloat("MainVolumeValue", mainVolume);
    }
    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("MainVolumeValue", mainVolume);
    }
    public void SetVolume(float sliderValue)
    {
        mixer.SetFloat("MainVolume", Mathf.Log10(sliderValue)*20);
    }
    public void SliderHandler()
    {
        mixer.GetFloat("MainVolume", out sliderValue);
        SetVolume(sliderValue);
    }
}
