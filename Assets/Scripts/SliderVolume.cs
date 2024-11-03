using UnityEngine;
using UnityEngine.Audio;

public class SliderVolume : MonoBehaviour
{
    [SerializeField] protected AudioMixerGroup _mixer;
    [SerializeField] protected string _nameGroup;

    private float _minScrollbarValue = 0.0001f;
    private float _maxScrollbarValue = 1f;
    private float _lgStep = 20f;

    public void ChangeVolume(float volume)
    {
        volume = Mathf.Clamp(volume, _minScrollbarValue, _maxScrollbarValue);
        volume = Mathf.Log10(volume) * _lgStep;
        _mixer.audioMixer.SetFloat(_nameGroup, volume);
    }
}
