using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// A script I am still proud of, my method for handeling animation in flash works just as well here.
/// </summary>
public class Animate : MonoBehaviour {

    /// <summary>
    /// This is the color swapper tool.
    /// </summary>
    public SetColor setColor;

    /// <summary>
    /// The framerate at which this object will animate.
    /// </summary>
    public float frameRate = 24;

    /// <summary>
    /// A quick pause to make the animation stop.
    /// </summary>
    public bool pause;

    /// <summary>
    /// How long is left till the frames should switch again.
    /// </summary>
    float frameSwitch = 0;

    /// <summary>
    /// The frame we are currently on.
    /// </summary>
    int currentFrame;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> idleF;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> idleB;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> idleFR;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> idleFL;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> idleBR;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> idleBL;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> walkF;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> walkB;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> walkBR;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> walkBL;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> walkFR;


    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> walkFL;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> hoeF;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> hoeB;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> hoeL;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> hoeR;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> waterF;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> waterB;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> waterL;

    /// <summary>
    /// A list of all sprites to loop through.
    /// </summary>
    public List<Sprite> waterR;

    /// <summary>
    /// All the sprites for real though
    /// </summary>
    public List<Sprite> sprites;

    /// <summary>
    /// This int commands the player on which animation to perform.
    /// 0: continue current action.
    /// 1: stop the current action.
    /// 2: walk up
    /// 3: walk down
    /// 4: walk up + left
    /// 5: walk up + right
    /// 6: walk down + left
    /// 7: walk down + right
    /// 8: hoe
    /// 9: water
    /// </summary>
    public static int animState;

    public int test;

    /// <summary>
    /// The renderer used for those sprites.
    /// </summary>
    SpriteRenderer rend;

	/// <summary>
    /// The start loop loads in all of the sprites, and starts you off on the first frame of animation.
    /// </summary>
	void Start () {
        rend = GetComponent<SpriteRenderer>();
        if(sprites.Count > 0 && sprites[0] is Sprite) rend.sprite = sprites[0] as Sprite;
        currentFrame = 0;

        sprites = idleFR;

        Sprite dummy = Instantiate(rend.sprite);

        //rend.sprite = null;
        rend.sprite = setColor.RecastPixels(dummy);
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void Stop()
    {
        animState = 1;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void WalkBackwards()
    {
        animState = 2;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void WalkForwards()
    {
        animState = 3;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void WalkBackwardRight()
    {
        animState = 4;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void WalkBackwardLeft()
    {
        animState = 5;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void WalkForwardLeft()
    {
        animState = 6;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void WalkForwardRight()
    {
        animState = 7;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void HoeBackward()
    {
        animState = 8;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void HoeForwards()
    {
        animState = 9;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void HoeRight()
    {
        animState = 10;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void HoeLeft()
    {
        animState = 11;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void WaterBackward()
    {
        animState = 12;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void WaterForwards()
    {
        animState = 13;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void WaterRight()
    {
        animState = 14;
    }

    /// <summary>
    /// This function is for easy to understand use by teammates so they don't have to dig through my code, they can just call Animate."blahblah"
    /// </summary>
    public static void WaterLeft()
    {
        animState = 15;
    }

    /// <summary>
    /// This update loop counts down till the next frame swap, and then advances you to the next frame when you are due to animate again.
    /// </summary>
    void Update () {
        if (pause) return;
        if(rend)rend.flipX = false;

        //animState = test;

        switch (animState)
        {
            case 0:
                break;
                //stop moving or performing other such actions
            case 1:
                //face backwards when stopping
                if (sprites == walkB || sprites == hoeB || sprites == waterB)
                {
                    sprites = idleB;
                }
                //face forwards when stopping
                else if (sprites == walkF || sprites == hoeF || sprites == waterF)
                {
                    sprites = idleF;
                }
                //face frontright when stopping
                else if (sprites == walkFR || sprites == hoeR || sprites == waterR)
                {
                    sprites = idleFR;
                }
                //face frontleft when stopping
                else if (sprites == walkFL || sprites == hoeL || sprites == waterL)
                {
                    sprites = idleFL;
                }
                //face backright when stopping
                else if (sprites == walkBR)
                {
                    sprites = idleBR;
                }
                //face backleft when stopping
                else if (sprites == walkBL)
                {
                    sprites = idleBL;
                }
                break;
            //walk backward
            case 2:
                sprites = walkB;
                break;
            //walk forward
            case 3:
                sprites = walkF;
                break;
            //walk backwardright
            case 4:
                sprites = walkBR;
                break;
            //walk backwardleft
            case 5:
                sprites = walkBL;
                break;
            //walk forwardleft
            case 6:
                sprites = walkFL;
                break;
            //walk backwardright
            case 7:
                sprites = walkFR;
                break;
            //hoe backward
            case 8:
                sprites = hoeB;
                break;
            //hoe forward
            case 9:
                sprites = hoeF;
                break;
            //hoe right
            case 10:
                sprites = hoeR;
                break;
            //hoe left
            case 11:
                sprites = hoeL;
                break;
            //water backward
            case 12:
                sprites = waterB;
                break;
            //water forward
            case 13:
                sprites = waterF;
                break;
            //weater right
            case 14:
                sprites = waterR;
                break;
            //water left
            case 15:
                rend.flipX = true;
                sprites = waterL;
                break;
        }


        frameSwitch += Time.deltaTime * frameRate;
        if (frameSwitch >= 1)
        {

            frameSwitch = 0;
            currentFrame++;
            if (currentFrame > sprites.Count - 1) currentFrame = 0;

            rend.sprite = Instantiate(sprites[currentFrame]);
        }
	}
}
