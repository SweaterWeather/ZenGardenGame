using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// This causes the camera to move back and forth on a sin wave.  It also loads the game states.
/// </summary>
public class SinMove : MonoBehaviour {

    /// <summary>
    /// This only plays the music.
    /// </summary>
    void Start()
    {
        AudioPlayer.PlayTitleMusic();
    }

	/// <summary>
    /// This makes the camera move with a sin wave.
    /// </summary>
	void Update () {
    Vector3 pos = new Vector3(transform.position.x, -20 + Mathf.Sin(Time.time * .25f) * 10, -10);
        transform.position = pos;
    }

    /// <summary>
    /// Switch to the play state.
    /// </summary>
    public void SwitchToPlay()
    {
        AudioPlayer.PlayClickSound();
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// Switch to the character builder state.
    /// </summary>
    public void SwitchToBuild()
    {
        AudioPlayer.PlayClickSound();
        SceneManager.LoadScene(1);
    }
}
