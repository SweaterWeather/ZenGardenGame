using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// This script turns the head.
/// </summary>
public class HeadAnimate : MonoBehaviour
{

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

    }
}
