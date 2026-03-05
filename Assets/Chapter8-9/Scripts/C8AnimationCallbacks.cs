using System;
using UnityEngine;

public enum EFloortype
{
    Grass,
    Snow,
    Ice,
    Dirt,
    Wood
}

public class C8AnimationCallbacks : MonoBehaviour
{
    public AudioSource footstepAudioSource;
    [NonSerialized] public EFloortype floortype;

    public AudioClip footStepGrass;
    public AudioClip footStepSnow;
    public AudioClip footStepIce;
    public AudioClip footStepDirt;
    public AudioClip footStepWood;

    void PlayFootstep()
    {
        footstepAudioSource.pitch = UnityEngine.Random.Range(0.7f, 1.3f);
        footstepAudioSource.Stop();
        footstepAudioSource.clip = floortype switch
        {
            EFloortype.Grass => footStepGrass,
            EFloortype.Snow => footStepSnow,
            EFloortype.Ice => footStepIce,
            EFloortype.Dirt => footStepDirt,
            EFloortype.Wood => footStepWood,
            _ => throw new NotImplementedException()
        };
        footstepAudioSource.Play();
    }
}
