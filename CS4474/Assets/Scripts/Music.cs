using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music MusicInstance { get; private set; }
    public AudioSource right;
    public AudioSource wrong;
    public AudioSource waterfall;
    private void Start()
    {
        MusicInstance = this;
    }
    public void PlayRight()
    {
        right.Play();
    }

    public void PlayWrong()
    {
        wrong.Play();
    }

    public void PlayWaterFall()
    {
        waterfall.Play();
    }
}
