using System;
using UnityEngine;
using UnityEngine.Audio;

public class SettingPanel : MonoBehaviour
{
    [SerializeField] AudioMixerGroup _mixer;

    private float _minScrollbarValue = 0.0001f;
    private float _maxScrollbarValue = 1f;
    private float _normalVolume = 0f;
    private float _nonVolume = -80f;

    private float _lgStep = 20f;

    private string _masterVolume = "MasterVolume";
    private string _musicVolume = "MusicVolume";
    private string _effectVolume = "EffectsVolume";

    public void ToggleAllSound(bool enabled)
    {
        if (enabled)
            _mixer.audioMixer.SetFloat(_masterVolume, _nonVolume);
        else
            _mixer.audioMixer.SetFloat(_masterVolume, _normalVolume);
    }

    public void ChangeOverralVolume(float volume) 
    {
        ChangeVolume(_masterVolume, volume);
    }

    public void ChangeButtomVolume(float volume) 
    {
        ChangeVolume(_effectVolume, volume);
    }

    public void ChangeBackgroundVolume(float volume)
    {
        ChangeVolume(_musicVolume, volume);
    }

    private void ChangeVolume(string name, float volume)
    {
        volume = Mathf.Clamp(volume, _minScrollbarValue, _maxScrollbarValue);
        volume = Mathf.Log10(volume) * _lgStep;
        _mixer.audioMixer.SetFloat(name, volume);
    }
}
