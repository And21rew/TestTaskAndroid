using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource sound;
    [SerializeField] private AudioClip hit, score, wing;

    public void PlayHitClip() => sound.PlayOneShot(hit);

    public void PlayScoreClip() => sound.PlayOneShot(score);

    public void PlayWingClip() => sound.PlayOneShot(wing);
}
