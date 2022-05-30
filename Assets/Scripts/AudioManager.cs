using UnityEngine.Audio;
using System;
using UnityEngine;

// Elias 
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    
    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound s in sounds)
        {
           s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.Shoot;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
 
    public void PlayShoot(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
    
}
