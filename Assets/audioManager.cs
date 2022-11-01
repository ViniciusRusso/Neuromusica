using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip somGrosso;
    public AudioClip somFino;
    public AudioSource source;

    public void playSound(bool thicc)
    {
        if (thicc)
        {
            source.clip = somGrosso;
        }
        else
        {
            source.clip = somFino;
        }

        source.Play();
    }
}
