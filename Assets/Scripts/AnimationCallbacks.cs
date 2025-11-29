using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    public AudioSource footstepAudioSource;

    void PlayFootstep()
    {
        footstepAudioSource.pitch = Random.Range(0.7f, 1.3f);
        footstepAudioSource.Play();
    }
}
