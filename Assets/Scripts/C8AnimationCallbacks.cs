using UnityEngine;

public class C8AnimationCallbacks : MonoBehaviour
{
    public AudioSource footstepAudioSource;

    void PlayFootstep()
    {
        footstepAudioSource.pitch = Random.Range(0.7f, 1.3f);
        footstepAudioSource.Play();
    }
}
