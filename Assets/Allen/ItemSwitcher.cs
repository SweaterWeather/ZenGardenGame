using UnityEngine;
using System.Collections;

public class ItemSwitcher : MonoBehaviour {

    int itemCode = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Tools should be static so we can tell when certain tools are in use anywhere.

        //TODO Custom Input

        //Universal buttons to cycle back and forth

        //Keyboard exclusive (1,2,3,4) to select tool

        //Controller exclusive Dpad to select tool (HOW MANY TOOLS?)

        switch (itemCode)
        {
            case 0: //hands
                break;
            case 1: //tool 1 (hoe)
                break;
            case 2: //tool 2 (water can)
                break;
                //etc...
        }


	}
}
