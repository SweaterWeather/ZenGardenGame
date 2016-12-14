using UnityEngine;
using System.Collections;

public class collisionDetection : MonoBehaviour {

    bool selected = false;
	
	

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Selector")
        {
            //I AM SELECTED
            print("I AM SELECTED BRUHHH");
            this.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
            selected = true;
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Selector")
        {
            //I AM SELECTED
            print("DONT LEAVE ME BRUHHH, COME BACK!");
            this.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
            selected = false;
        }

    }
}
