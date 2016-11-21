﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public class SetColor : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    public SpriteRenderer source;

    /// <summary>
    /// 
    /// </summary>
    public Sprite target;

    /// <summary>
    /// The target colors for red areas on your spriteswap.
    /// </summary>
    public Vector3 Red;

    /// <summary>
    /// The target colors for green areas on your spriteswap.
    /// </summary>
    public Vector3 Green;

    /// <summary>
    /// The target colors for blue areas on your spriteswap.
    /// </summary>
    public Vector3 Blue;

    /// <summary>
    /// The target colors for magenta areas on your spriteswap.
    /// </summary>
    public Vector3 Magenta;

    /// <summary>
    /// The target colors for yellow areas on your spriteswap.
    /// </summary>
    public Vector3 Yellow;

    /// <summary>
    /// The target colors for cyan areas on your spriteswap.
    /// </summary>
    public Vector3 Cyan;

    /// <summary>
    /// The target colors for black areas on your spriteswap.
    /// </summary>
    public Vector3 Black;

    /// <summary>
    /// The target colors for white areas on your spriteswap.
    /// </summary>
    public Vector3 White;

    // Use this for initialization
    void Start () {
        Sprite doop = source.sprite;
        Texture2D souceText = doop.texture;
        Texture2D targetText = target.texture;

        Color[] colors = souceText.GetPixels();

        for(int i = 0; i < colors.Length; i++)
        {
            //The color being swapped out.
            //0 : red
            //1 : green
            //2 : blue
            //3 : magenta
            //4 : yellow
            //5 : cyan
            //6 : black
            //7 : white
            int mode = 0;
            if(colors[i].a > 0)
            {
                if (colors[i].r > .5f && colors[i].g > .5f && colors[i].b > .5f) mode = 7;
                else if (colors[i].r < .5f && colors[i].g < .5f && colors[i].b < .5f) mode = 6;
                else if (colors[i].g > .5f && colors[i].b > .5f) mode = 5;
                else if (colors[i].r > .5f && colors[i].g > .5f) mode = 4;
                else if (colors[i].r > .5f && colors[i].b > .5f) mode = 3;
                else if (colors[i].b > .5f) mode = 2;
                else if (colors[i].g > .5f) mode = 1;
                else if (colors[i].r > .5f) mode = 0;

                switch (mode)
                {
                    case 0:
                        colors[i].r = Red.x;
                        colors[i].g = Red.y;
                        colors[i].b = Red.z;
                        break;
                    case 1:
                        colors[i].r = Green.x;
                        colors[i].g = Green.y;
                        colors[i].b = Green.z;
                        break;
                    case 2:
                        colors[i].r = Blue.x;
                        colors[i].g = Blue.y;
                        colors[i].b = Blue.z;
                        break;
                    case 3:
                        colors[i].r = Magenta.x;
                        colors[i].g = Magenta.y;
                        colors[i].b = Magenta.z;
                        break;
                    case 4:
                        colors[i].r = Yellow.x;
                        colors[i].g = Yellow.y;
                        colors[i].b = Yellow.z;
                        break;
                    case 5:
                        colors[i].r = Cyan.x;
                        colors[i].g = Cyan.y;
                        colors[i].b = Cyan.z;
                        break;
                    case 6:
                        colors[i].r = Black.x;
                        colors[i].g = Black.y;
                        colors[i].b = Black.z;
                        break;
                    case 7:
                        colors[i].r = White.x;
                        colors[i].g = White.y;
                        colors[i].b = White.z;
                        break;
                }
            }
        }
        targetText.SetPixels(colors);
        targetText.Apply();

        source.sprite = target;
	}
}
