using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Director;

/// <summary>
/// This script will hopefully rework Unity's awful animator into something somewhat usable, specifically for the player.
/// </summary>
public class CharacterAnimationController : MonoBehaviour {

    /// <summary>
    /// The animator for this object.
    /// </summary>
    public Animator anim;

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
	
	/// <summary>
    /// 
    /// </summary>
	void Update () {
        switch (animState)
        {
            case 0:
                break;
            case 1:
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("waterL"))
            {
                anim.Play("idleBL");
            }
                break;
        }
	}
}
