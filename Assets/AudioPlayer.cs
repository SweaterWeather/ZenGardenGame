using UnityEngine;
using System.Collections;

/// <summary>
/// This script calls for audio to be played.
/// </summary>
public class AudioPlayer : MonoBehaviour
{

    /// <summary>
    /// The title music.
    /// </summary>
    public AudioSource musicTitle;

    /// <summary>
    /// The game music.
    /// </summary>
    public AudioSource musicGame;

    /// <summary>
    /// The watering sound.
    /// </summary>
    public AudioSource waterSound;

    /// <summary>
    /// The harvesting sound.
    /// </summary>
    public AudioSource harvestSound;

    /// <summary>
    /// The hoe swinging sound.
    /// </summary>
    public AudioSource swingingSound;

    /// <summary>
    /// The building sound.
    /// </summary>
    public AudioSource buildingSound;

    /// <summary>
    /// The click sound.
    /// </summary>
    public AudioSource clickSound;

    /// <summary>
    /// A static reference to itself.
    /// </summary>
    public static AudioPlayer audioPlay;

	/// <summary>
    /// This start menu causes this object to not be destroyed on load.
    /// </summary>
	void Start () {
        DontDestroyOnLoad(this.gameObject);
        audioPlay = this;
    }

    /// <summary>
    /// This function plays the title music.
    /// </summary>
    public static void PlayTitleMusic()
    {
        try
        {
            audioPlay.musicGame.Stop();
            audioPlay.musicTitle.Play();
        }
        catch { }
    }

    /// <summary>
    /// This function plays the game music.
    /// </summary>
    public static void PlayGameMusic()
    {
        try
        {
            audioPlay.musicTitle.Stop();
            audioPlay.musicGame.Play();
        }
        catch { }
    }

    /// <summary>
    /// This function plays the water sound.
    /// </summary>
    public static void PlayWaterSound()
    {
        try
        {
            audioPlay.waterSound.Play();
        }
        catch { }
    }

    /// <summary>
    /// This function plays the harvest sound.
    /// </summary>
    public static void PlayHarvestSound()
    {
        try
        {
            audioPlay.harvestSound.Play();
        }
        catch { }
    }

    /// <summary>
    /// This function plays the swing sound.
    /// </summary>
    public static void PlaySwingSound()
    {
        try
        {
            audioPlay.swingingSound.Play();
        }
        catch { }
    }

    /// <summary>
    /// This function plays the building sound.
    /// </summary>
    public static void PlayBuildingSound()
    {
        try
        {
            audioPlay.buildingSound.Play();
        }
        catch { }
    }

    /// <summary>
    /// This function plays the click sound.
    /// </summary>
    public static void PlayClickSound()
    {
        try
        {
            audioPlay.clickSound.Play();
        }
        catch { }
    }
}
