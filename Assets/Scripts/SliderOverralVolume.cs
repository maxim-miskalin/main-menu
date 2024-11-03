using UnityEngine;
using UnityEngine.UI;

public class SliderOverralVolume : SliderVolume
{
    [SerializeField] private Toggle _muteButtom;

    private float _currentScrollbarValue = 1f;
    private float _nonVolume = -80f;

    public void ToggleAllSound(bool enabled)
    {
        if (enabled)
            _mixer.audioMixer.SetFloat(_nameGroup, _nonVolume);
        else
            ChangeVolume(_currentScrollbarValue);
    }

    public void ChangeOverralVolume(float volume)
    {
        _currentScrollbarValue = volume;

        if (!_muteButtom.isOn)
            ChangeVolume(_currentScrollbarValue);
    }
}
