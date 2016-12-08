using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float speedScaler = .01f;
    float walkDir;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	    if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            transform.position += new Vector3(0, Input.GetAxis("Vertical") * speedScaler); //UP + DOWN
            transform.position += new Vector3(Input.GetAxis("Horizontal") * speedScaler, 0); //RIGHT + LEFT

            //walkDir = Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * (180 / Mathf.PI);
        }
        



        
        //print(Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * (180/Mathf.PI));
        //transform.rotation = Quaternion.Euler(0, 0, walkDir);
    }
}
