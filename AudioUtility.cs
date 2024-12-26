using UnityEngine;

public static class AudioUtility
{
    public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume = 1.0f)
    {
        AudioSource.PlayClipAtPoint(clip, position, volume);
    }

    public static void SetAudioVolume(AudioSource audioSource, float volume)
    {
        audioSource.volume = Mathf.Clamp01(volume);
    }
}
