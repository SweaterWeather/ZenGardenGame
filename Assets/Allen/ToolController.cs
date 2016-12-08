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
            //selectorRotatorScript._dir
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
