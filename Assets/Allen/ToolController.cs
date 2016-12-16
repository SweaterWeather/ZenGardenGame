using UnityEngine;
using System.Collections;

/// <summary>
/// This script controls the tool behaviors in game.
/// </summary>
public class ToolController : MonoBehaviour {

    /// <summary>
    /// The ammount of water the player has.
    /// </summary>
	static public int waterCounter = 0;
    /// <summary>
    /// If the player can get water.
    /// </summary>
    public bool canGetWater = false;
    /// <summary>
    /// If the player can trade crops for money.
    /// </summary>
    public bool canSell = false;

    /// <summary>
    /// For some reason, this plays the game music.
    /// </summary>
    void Start()
    {
        AudioPlayer.PlayGameMusic();
    }

	/// <summary>
    /// Update is ran once per frame. This is constantly checking to see if the tool's button is pressed.
    /// </summary>
	void Update () {

        //Input Checks For tools
        if (Input.GetButtonDown("WaterCan")) //Q
        {

            //Logic that allows us to collect water from the fountain.
            if (canGetWater)
            {
                AudioPlayer.PlayWaterSound();
                waterCounter = 3;
                UI.water = waterCounter;
            }
            //print(waterCounter);

            //play water animation    
            //Animator commands for tools
            if (selectorRotatorScript._dir >= 45 && selectorRotatorScript._dir < 135)
            {
                Animate.WaterBackward();
            }
            else if (selectorRotatorScript._dir >= 135 && selectorRotatorScript._dir < 225)
            {
                Animate.WaterLeft();
            }
            else if (selectorRotatorScript._dir >= 225 && selectorRotatorScript._dir < 315)
            {
                Animate.WaterForwards();
            }
            else if (selectorRotatorScript._dir >= 315 || selectorRotatorScript._dir >= 0)
            {
                Animate.WaterRight();
            }
            //play watercan animation
        }
        if (Input.GetButtonDown("Hoe")) //E Input
        {
            //logic that allows us to turn in the crops to the mill
            if (canSell)
            {
                AudioPlayer.PlayBuildingSound();
                UI.score += UI.crops;
                UI.crops = 0;

            }
            
            //print("HOE WAS USED");
            //Animator commands for tools          
            if(selectorRotatorScript._dir >= 45 && selectorRotatorScript._dir < 135)
            {
                Animate.HoeBackward();
            } else if (selectorRotatorScript._dir >= 135 && selectorRotatorScript._dir < 225)
            {
                Animate.HoeLeft();
            } else if (selectorRotatorScript._dir >= 225 && selectorRotatorScript._dir < 315)
            {
                Animate.HoeForwards();
            } else if (selectorRotatorScript._dir >= 315 || selectorRotatorScript._dir >= 0)
            {
                Animate.HoeRight();
            }
        }
        
        
        //not actually used :(
        if (Input.GetButtonDown("Pause")) //p
        {
            print("PauseTest");
        }
	}//Update

    /// <summary>
    ///These collision detectors are just stating if we can get water or turn in crops to the store. Depending on if the "selector" is hitting certain object types.
    /// </summary>
    /// <param name="other">The other collider.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            canGetWater = true;
        }
        if (other.gameObject.tag == "Store") canSell = true;
        

    }
    /// <summary>
    /// The collider exit event which deselects interaction options.
    /// </summary>
    /// <param name="other">The other collision box.</param>
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Water") canGetWater = false;
        if (other.gameObject.tag == "Store")
        {
           
            canSell = false;
        }
    }

}
