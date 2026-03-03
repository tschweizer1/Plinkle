using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private static bool isBallInPlay;
    public AudioClip PegHitClip;

    private AudioSource audioSource;

    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        isBallInPlay = true;
    }

    public static bool IsBallInPlay()
    {
        return isBallInPlay;
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Peg"))
        {
            audioSource.PlayOneShot(PegHitClip);
            audioSource.pitch = audioSource.pitch + 0.1f;
        }
    }

    public void OnDestroy()
    {
        isBallInPlay = false;
    }
}
