using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// A script I am still proud of, my method for handeling animation in flash works just as well here.
/// </summary>
public class Animate : MonoBehaviour {

    /// <summary>
    /// The head, so it can animate as well.
    /// </summary>
    public HeadAnimate head;

    /// <summary>
    /// This is the color swapper tool.
    /// </summary>
    public SetColor setColor;

    /// <summary>
    /// The framerate at which this object will animate.
    /// </summary>
    public float frameRate = 24;

    /// <summary>
    /// A counter of how many frames of animation have passed.
    /// </summary>
    int framesPassed = 0;

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
    /// THe frame immediately before this one.
    /// </summary>
    int prevCurFrame;


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

        //animState = test; by allen

        switch (animState)
        {
            //nothing
            case 0:
                break;
            //stop moving or performing other such actions
            case 1:
                framesPassed = 0;
                head.bobbing.pause = true;
                //face backwards when stopping
                if (sprites == walkB || sprites == hoeB || sprites == waterB)
                {
                    sprites = idleB;
                    head.currentFrame = 4;
                }
                //face forwards when stopping
                else if (sprites == walkF || sprites == hoeF || sprites == waterF)
                {
                    sprites = idleF;
                    head.currentFrame = 1;
                }
                //face frontright when stopping
                else if (sprites == walkFR || sprites == hoeR || sprites == waterR)
                {
                    sprites = idleFR;
                    head.currentFrame = 0;
                }
                //face frontleft when stopping
                else if (sprites == walkFL || sprites == hoeL || sprites == waterL)
                {
                    head.currentFrame = 2;
                    sprites = idleFL;
                }
                //face backright when stopping
                else if (sprites == walkBR)
                {
                    sprites = idleBR;
                    head.currentFrame = 5;
                }
                //face backleft when stopping
                else if (sprites == walkBL)
                {
                    sprites = idleBL;
                    head.currentFrame = 3;
                }
                break;
            //walk backward
            case 2:
                head.currentFrame = 4;
                head.bobbing.pause = false;
                sprites = walkB;
                break;
            //walk forward
            case 3:
                head.currentFrame = 1;
                head.bobbing.pause = false;
                sprites = walkF;
                break;
            //walk backwardright
            case 4:
                head.currentFrame = 5;
                head.bobbing.pause = false;
                sprites = walkBR;
                break;
            //walk backwardleft
            case 5:
                head.currentFrame = 3;
                head.bobbing.pause = false;
                sprites = walkBL;
                break;
            //walk forwardleft
            case 6:
                head.currentFrame = 2;
                head.bobbing.pause = false;
                sprites = walkFL;
                break;
            //walk forwardright
            case 7:
                head.currentFrame = 0;
                head.bobbing.pause = false;
                sprites = walkFR;
                break;
            //hoe backward
            case 8:
                head.currentFrame = 12;
                sprites = hoeB;
                head.bobbing.pause = true;

                if (framesPassed >= 3)
                {
                    head.currentFrame = 13;
                }
                if (framesPassed >= 5)
                {
                    Animate.Stop();
                    head.currentFrame = 4;
                    framesPassed = 0;
                }
                break;
            //hoe forward
            case 9:
                head.currentFrame = 8;
                sprites = hoeF;
                head.bobbing.pause = true;

                if (framesPassed >= 3)
                {
                    head.currentFrame = 9;
                }
                if (framesPassed >= 5)
                {
                    Animate.Stop();
                    head.currentFrame = 1;
                    framesPassed = 0;
                }
                break;
            //hoe right
            case 10:
                head.currentFrame = 6;
                sprites = hoeR;
                head.bobbing.pause = true;

                if (framesPassed >= 3)
                {
                    head.currentFrame = 7;
                }
                if (framesPassed >= 5)
                {
                    Animate.Stop();
                    head.currentFrame = 0;
                    framesPassed = 0;
                }
                break;
            //hoe left
            case 11:
                head.currentFrame = 10;
                sprites = hoeL;
                head.bobbing.pause = true;

                if (framesPassed >= 3)
                {
                    head.currentFrame = 11;
                }
                if (framesPassed >= 5)
                {
                    Animate.Stop();
                    head.currentFrame = 2;
                    framesPassed = 0;
                }
                break;
            //water backward
            case 12:
                head.currentFrame = 17;
                sprites = waterB;
                head.bobbing.pause = true;

                if (framesPassed > 5) Animate.Stop();
                break;
            //water forward
            case 13:
                head.currentFrame = 15;
                sprites = waterF;
                head.bobbing.pause = true;

                if (framesPassed > 5) Animate.Stop();
                break;
            //weater right
            case 14:
                head.currentFrame = 14;
                sprites = waterR;
                head.bobbing.pause = true;

                if (framesPassed > 5) Animate.Stop();
                break;
            //water left
            case 15:
                head.currentFrame = 16;
                rend.flipX = true;
                sprites = waterL;
                head.bobbing.pause = true;

                if (framesPassed > 5) Animate.Stop();
                break;
        }


        frameSwitch += Time.deltaTime * frameRate;
        if (frameSwitch >= 1)
        {
            if (prevCurFrame != animState) framesPassed = 0;

            frameSwitch = 0;
            currentFrame++;
            framesPassed++;

            if (currentFrame > sprites.Count - 1) currentFrame = 0;

            rend.sprite = Instantiate(sprites[currentFrame]);
            prevCurFrame = animState;
        }
    }
}
