﻿using UnityEngine;
using System.Collections;

public class ToolController : MonoBehaviour {


	static public int waterCounter = 0;
    public bool canGetWater = false;
	/// <summary>
    /// Update is ran once per frame. This is constantly checking to see if the tool's button is pressed.
    /// </summary>
	void Update () {

        
        if (Input.GetButtonDown("WaterCan")) //Q
        {


            if (canGetWater) { 
                waterCounter = 3;
            }


            //play water animation    

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
        if (Input.GetButtonDown("Hoe")) //E
        {
            //print("HOE WAS USED");
                      
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
        
        
        
        if (Input.GetButtonDown("Pause")) //p
        {
            print("PauseTest");
        }
	}//Update

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Water") canGetWater = true;
        print("VASSER");

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Water") canGetWater = false;
    }

}
