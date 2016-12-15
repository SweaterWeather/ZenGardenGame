using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// This script controls the ingame UI field.
/// </summary>
public class UI : MonoBehaviour
{
    /// <summary>
    /// The text field of the score.
    /// </summary>
    public Text scoreText;

    /// <summary>
    /// The text field of the crops.
    /// </summary>
    public Text cropText;

    /// <summary>
    /// The text field of the water.
    /// </summary>
    public Text waterText;

    /// <summary>
    /// This is the player's score.
    /// </summary>
    public static int score;

    /// <summary>
    /// This is the player's crop count.
    /// </summary>
    public static int crops;

    /// <summary>
    /// This is the player's water ammount.
    /// </summary>
    public static int water;

    /// <summary>
    /// This update loop sets every textfield equal to the proper score values.
    /// </summary>
    void Update ()
    {
        scoreText.text = "" + score + "";
        cropText.text = "" + crops + "";
        waterText.text = "" + water + "";
    }
}
