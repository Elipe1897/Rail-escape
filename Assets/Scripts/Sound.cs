using UnityEngine.Audio;
using UnityEngine;

// Elias
[System.Serializable]
public class Sound 
{
    public string name;
    public AudioClip Shoot;

    [Range(0f, 1f)]
    public float volume;
    [Range(0.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
   
}
