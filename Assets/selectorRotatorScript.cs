using UnityEngine;
using System.Collections;

public class selectorRotatorScript : MonoBehaviour {

    float walkDir;
    float _dir;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            walkDir = Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * (180 / Mathf.PI);
        }
        
        transform.rotation = Quaternion.Euler(0, 0, walkDir);
        //print(transform.rotation.eulerAngles.z);

        _dir = transform.rotation.eulerAngles.z;
        //print(_dir);
        if (_dir >= 337.5) Animate.WalkForwardRight();//walk right
        if (_dir >= 0 && _dir < 22.5) Animate.WalkForwardRight(); //walk right
        if (_dir >= 22.5 && _dir < 67.5) Animate.WalkBackwardRight();//walk up and right
        if (_dir >= 67.5 && _dir < 112.5) Animate.WalkBackwards(); //walk up
        if (_dir >= 112.5 && _dir < 157.5) Animate.WalkBackwardLeft(); //walk up and left;
        if (_dir >= 157.5 && _dir < 202.5) Animate.WalkForwardLeft(); //walk left
        if (_dir >= 202.5 && _dir < 249.5) Animate.WalkForwardLeft(); //walk down and left;
        if (_dir >= 249.5 && _dir < 292.5) Animate.WalkForwards(); //walk down
        if (_dir >= 292.5 && _dir < 337.5) Animate.WalkForwardRight(); //walk down and right

        if(Mathf.Abs(Input.GetAxis("Vertical")) <= .2f && Mathf.Abs(Input.GetAxis("Horizontal")) <= .2f)
        {
            Animate.Stop();
        }

    }
}
