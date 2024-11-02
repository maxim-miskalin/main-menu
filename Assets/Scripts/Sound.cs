using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private float _pitchMinValue = 0.9f;
    [SerializeField] private float _pitchMaxValue = 1.1f;
    
    private AudioSource _audio;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        _audio.pitch = Random.Range(_pitchMinValue, _pitchMaxValue);
        _audio.Play();
    }
}
