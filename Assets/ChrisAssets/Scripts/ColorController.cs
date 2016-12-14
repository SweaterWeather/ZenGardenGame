using UnityEngine;
using System.Collections;

/// <summary>
/// This class will use static vaules to alter the actual colors of the head and body sprites.
/// </summary>
public class ColorController : MonoBehaviour
{
    /// <summary>
    /// The character head that will be used.
    /// </summary>
    public static int headType;

    /// <summary>
    /// The red color channel.
    /// </summary>
    public static Vector3 redChannelHead = new Vector3(0.52f, 0.4f, 0.34f);

    /// <summary>
    /// The green color channel.
    /// </summary>
    public static Vector3 greenChannelHead = new Vector3(0.74f, 0.74f, 0.7f);

    /// <summary>
    /// The blue color channel.
    /// </summary>
    public static Vector3 blueChannelHead = new Vector3(0.5f, 0.42f, 0.34f);

    /// <summary>
    /// The magenta color channel.
    /// </summary>
    public static Vector3 magentaChannelHead = new Vector3(0.74f, 0.68f, 0.7f);

    /// <summary>
    /// The yellow color channel.
    /// </summary>
    public static Vector3 yellowChannelHead = new Vector3(1.0f, 0.9f, 0.66f);

    /// <summary>
    /// The cyan color channel.
    /// </summary>
    public static Vector3 cyanChannelHead = new Vector3(0.5f, 0.42f, 0.34f);

    /// <summary>
    /// The black color channel.
    /// </summary>
    public static Vector3 blackChannelHead = new Vector3(0.1f, 0.075f, 0.05f);

    /// <summary>
    /// The white color channel.
    /// </summary>
    public static Vector3 whiteChannelHead = new Vector3(0.4f, 0.36f, 0.14f);

    /// <summary>
    /// The red color channel.
    /// </summary>
    public static Vector3 redChannelBody = new Vector3(0.85f, 0.85f, 0.85f);

    /// <summary>
    /// The green color channel.
    /// </summary>
    public static Vector3 greenChannelBody = new Vector3(0.46f, 0.46f, 1.0f);

    /// <summary>
    /// The blue color channel.
    /// </summary>
    public static Vector3 blueChannelBody = new Vector3(0.46f, 0.46f, 0.62f);

    /// <summary>
    /// The magenta color channel.
    /// </summary>
    public static Vector3 magentaChannelBody = new Vector3(0.54f, 0.56f, 0.78f);

    /// <summary>
    /// The yellow color channel.
    /// </summary>
    public static Vector3 yellowChannelBody = new Vector3(1, 0.9f, 0.66f);

    /// <summary>
    /// The cyan color channel.
    /// </summary>
    public static Vector3 cyanChannelBody = new Vector3(0.38f, 0.38f, 0.8f);

    /// <summary>
    /// The black color channel.
    /// </summary>
    public static Vector3 blackChannelBody = new Vector3(0.1f, 0.075f, 0.05f);

    /// <summary>
    /// The white color channel.
    /// </summary>
    public static Vector3 whiteChannelBody = new Vector3(0.18f, 0.24f, 0.46f);

    /// <summary>
    /// The head whose color should be altered.
    /// </summary>
    public SetColor head;

    /// <summary>
    /// The body whose color should be altered.
    /// </summary>
    public SetColor body;

    /// <summary>
    /// 
    /// </summary>
    void Start () {
        head.Red = redChannelHead;
        head.Green = greenChannelHead;
        head.Blue = blueChannelHead;
        head.Magenta = magentaChannelHead;
        head.Yellow = yellowChannelHead;
        head.Cyan = cyanChannelHead;
        head.Black = blackChannelHead;
        head.White = whiteChannelHead;

        body.Red = redChannelBody;
        body.Green = greenChannelBody;
        body.Blue = blueChannelBody;
        body.Cyan = cyanChannelBody;
        body.Magenta = magentaChannelBody;
        body.Yellow = yellowChannelBody;
        body.Black = blackChannelBody;
        body.White = whiteChannelBody;

        //HeadAnimate.index = headType;
	}
}
