using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// This script turns the head.
/// </summary>
public class HeadAnimate : MonoBehaviour
{
    /// <summary>
    /// A reference to the script that makes the player's head bob up and down so it can be turned on and off when appropriate for walking purposes.
    /// </summary>
    public HeadBob bobbing;

    /// <summary>
    /// The sprite renderer.
    /// </summary>
    public SpriteRenderer rend;

    /// <summary>
    /// This is the head that will load in.
    /// 0: Hat Man
    /// 1: Man
    /// 2: Young Woman
    /// 3: Old Woman
    /// 4: Panda
    /// </summary>
    public static int index;

    /// <summary>
    /// The current frame of the animation.
    /// 0: Face FR
    /// 1: Face F
    /// 2: Face FL
    /// 3: Face BL
    /// 4: Fave B
    /// 5: Face BR
    /// 6: Hoe R1
    /// 7: Hoe R2
    /// 8: Hoe F1
    /// 9: Hoe F2
    /// 10: Hoe L1
    /// 11: Hoe L2
    /// 12: Hoe B1
    /// 13: Hoe B2
    /// 14: Water R
    /// 15: Water F
    /// 16: Water L
    /// 17: Water B 
    /// 
    /// </summary>
    public int currentFrame = 0;

    /// <summary>
    /// A list of all sprites.
    /// </summary>
    public List<Sprite> sprites;

    /// <summary>
    /// A list of oldwoman sprites.
    /// </summary>
    public List<Sprite> oldWoman;

    /// <summary>
    /// A list of hatman sprites.
    /// </summary>
    public List<Sprite> hatMan;

    /// <summary>
    /// A list of panda sprites.
    /// </summary>
    public List<Sprite> panda;

    /// <summary>
    /// A list of youngwoman sprites.
    /// </summary>
    public List<Sprite> youngWoman;

    /// <summary>
    /// A list of man sprites.
    /// </summary>
    public List<Sprite> man;

    /// <summary>
    /// The start function sets up the proper head.
    /// </summary>
    void Start()
    {
        switch (index)
        {
            case 0: sprites = hatMan;
                break;
            case 1: sprites = man;
                break;
            case 2:
                sprites = youngWoman;
                break;
            case 3:
                sprites = oldWoman;
                break;
            case 4:
                sprites = panda;
                break;
        }
    }

    void Update()
    {
       
        Vector3 pos;
        switch (currentFrame)
        {
            //face FR
            case 0:
                rend.sprite = sprites[currentFrame];
                pos = new Vector3(-.5f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //face F
            case 1:
                rend.sprite = sprites[currentFrame];
                pos = new Vector3(-.15f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //face FL
            case 2:
                rend.sprite = sprites[currentFrame];
                pos = new Vector3(.5f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //face BL
            case 3:
                rend.sprite = sprites[currentFrame];
                pos = new Vector3(-.5f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //face B
            case 4:
                rend.sprite = sprites[currentFrame];
                pos = new Vector3(-.15f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //face BR
            case 5:
                rend.sprite = sprites[currentFrame];
                pos = new Vector3(.5f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Hoe R1:
            case 6:
                rend.sprite = sprites[5];
                pos = new Vector3(.5f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Hoe R2:
            case 7:
                rend.sprite = sprites[0];
                pos = new Vector3(-1f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Hoe F1:
            case 8:
                rend.sprite = sprites[1];
                pos = new Vector3(.3f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Hoe F2:
            case 9:
                rend.sprite = sprites[1];
                pos = new Vector3(-.5f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Hoe L1:
            case 10:
                rend.sprite = sprites[3];
                pos = new Vector3(-.5f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Hoe L2:
            case 11:
                rend.sprite = sprites[2];
                pos = new Vector3(1f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Hoe B1
            case 12:
                rend.sprite = sprites[5];
                pos = new Vector3(-.5f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Hoe B2
            case 13:
                rend.sprite = sprites[4];
                pos = new Vector3(.45f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Water R
            case 14:
                rend.sprite = sprites[0];
                pos = new Vector3(-.8f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Water F
            case 15:
                rend.sprite = sprites[1];
                pos = new Vector3(-.1f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Water L
            case 16:
                rend.sprite = sprites[2];
                pos = new Vector3(.7f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
            //Water L
            case 17:
                rend.sprite = sprites[4];
                pos = new Vector3(-.1f, transform.localPosition.y);
                transform.localPosition = pos;
                break;
        }
    }
}
