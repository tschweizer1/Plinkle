using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip CannonClip;
    public AudioClip PegDestroyedClip;
    public AudioClip PegHitClip;
    public AudioClip FireworksClip;
    public AudioSource AudioSource;
    public void PlayCannonSound()
    {
        AudioSource.PlayOneShot(CannonClip);
    }

    public void PlayPegDestroyedSound()
    {
        AudioSource.PlayOneShot(PegDestroyedClip);
    }

    public void PlayPegHitSound()
    {
        AudioSource.PlayOneShot(PegHitClip);
    }

    public void PlayFireworksSound()
    {
        AudioSource.PlayOneShot(FireworksClip);
    }
}
