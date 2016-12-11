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
    public static Vector3 redChannelHead = new Vector3(1, 0, 0);

    /// <summary>
    /// The green color channel.
    /// </summary>
    public static Vector3 greenChannelHead = new Vector3(0, 1, 0);

    /// <summary>
    /// The blue color channel.
    /// </summary>
    public static Vector3 blueChannelHead = new Vector3(0, 0, 1);

    /// <summary>
    /// The magenta color channel.
    /// </summary>
    public static Vector3 magentaChannelHead = new Vector3(1, 0, 1);

    /// <summary>
    /// The yellow color channel.
    /// </summary>
    public static Vector3 yellowChannelHead = new Vector3(1, 1, 0);

    /// <summary>
    /// The cyan color channel.
    /// </summary>
    public static Vector3 cyanChannelHead = new Vector3(0, 1, 1);

    /// <summary>
    /// The black color channel.
    /// </summary>
    public static Vector3 blackChannelHead = new Vector3(0, 0, 0);

    /// <summary>
    /// The white color channel.
    /// </summary>
    public static Vector3 whiteChannelHead = new Vector3(1, 1, 1);

    /// <summary>
    /// The red color channel.
    /// </summary>
    public static Vector3 redChannelBody = new Vector3(1, 0, 0);

    /// <summary>
    /// The green color channel.
    /// </summary>
    public static Vector3 greenChannelBody = new Vector3(0, 1, 0);

    /// <summary>
    /// The blue color channel.
    /// </summary>
    public static Vector3 blueChannelBody = new Vector3(0, 0, 1);

    /// <summary>
    /// The magenta color channel.
    /// </summary>
    public static Vector3 magentaChannelBody = new Vector3(1, 0, 1);

    /// <summary>
    /// The yellow color channel.
    /// </summary>
    public static Vector3 yellowChannelBody = new Vector3(1, 1, 0);

    /// <summary>
    /// The cyan color channel.
    /// </summary>
    public static Vector3 cyanChannelBody = new Vector3(0, 1, 1);

    /// <summary>
    /// The black color channel.
    /// </summary>
    public static Vector3 blackChannelBody = new Vector3(0, 0, 0);

    /// <summary>
    /// The white color channel.
    /// </summary>
    public static Vector3 whiteChannelBody = new Vector3(1, 1, 1);

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

        HeadAnimate.index = headType;
	}
}
