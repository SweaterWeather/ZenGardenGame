using UnityEngine;
using System.Collections;

public class ToolController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        
        if (Input.GetButtonDown("WaterCan"))
        {
            print("WATER CAN WAS USED");
            //play watercan animation
        }
        if (Input.GetButtonDown("Hoe"))
        {
            print("HOE WAS USED");
            //play hoe animation              
            if(selectorRotatorScript._dir >= 45 && selectorRotatorScript._dir < 135)
            {
                Animate.HoeForwards();
            } else if (selectorRotatorScript._dir >= 135 && selectorRotatorScript._dir < 225)
            {
                Animate.HoeLeft();
            } else if (selectorRotatorScript._dir >= 225 && selectorRotatorScript._dir < 315)
            {
                Animate.HoeBackward();
            } else if (selectorRotatorScript._dir >= 315 || selectorRotatorScript._dir >= 0)
            {
                Animate.HoeRight();
            }
        }

        if (Input.GetButtonDown("Pause"))
        {
            print("PauseTest");
        }
	}

    void OnTriggerEnter(Collider other)
    {
        print("boom");
        print(other.gameObject.tag);
        if (other.gameObject.tag == "Plant")
        {
            print("Plant Selected");
        }
    }
}
