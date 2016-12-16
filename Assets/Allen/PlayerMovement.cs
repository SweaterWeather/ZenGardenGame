using UnityEngine;
using System.Collections;

/// <summary>
/// This script controls player movement.
/// </summary>
public class PlayerMovement : MonoBehaviour {

    /// <summary>
    /// speedScaler: scales the speed, is editable in editor for easy testing.
    /// </summary>
    public float speedScaler = 10f;    

	
	
    /// <summary>
    /// Update is called once per frame. This function is getting raw input from the controller axis and directly affects the position of the object.
    /// </summary>
	void Update () {
        
	    if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            transform.position += new Vector3(0, Input.GetAxis("Vertical") * speedScaler * Time.deltaTime); //UP + DOWN
            transform.position += new Vector3(Input.GetAxis("Horizontal") * speedScaler * Time.deltaTime, 0); //RIGHT + LEFT

            //walkDir = Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * (180 / Mathf.PI);
        }
        



        
        //print(Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * (180/Mathf.PI));
        //transform.rotation = Quaternion.Euler(0, 0, walkDir);
    }
}
