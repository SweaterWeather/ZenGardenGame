using UnityEngine;
using System.Collections;

public class selectorRotatorScript : MonoBehaviour {

    /// <summary>
    /// walkDir: Direction player is walking, determined by controler axis.
    /// _dir: locallay used dir that is in degrees that states which direction the player should be facing. Is static for use as reference in other classes.
    /// </summary>
    float walkDir;
    public static float _dir;

    // Update is called once per frame
    /// <summary>
    /// Called Once per frame, the game is constantly checking to see which way to have the sprite animate towards.
    /// </summary>
	void Update () {

        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            walkDir = Mathf.Atan2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal")) * (180 / Mathf.PI);
        }        
        transform.rotation = Quaternion.Euler(0, 0, walkDir);       

        _dir = transform.rotation.eulerAngles.z;


        //What dir is the player facing? This code decides.
        if (Animate.animState < 8) {
            if (_dir >= 337.5) Animate.WalkForwardRight();//walk right
            if (_dir >= 0 && _dir < 22.5) Animate.WalkForwardRight(); //walk right
            if (_dir >= 22.5 && _dir < 67.5) Animate.WalkBackwardRight();//walk up and right
            if (_dir >= 67.5 && _dir < 112.5) Animate.WalkBackwards(); //walk up
            if (_dir >= 112.5 && _dir < 157.5) Animate.WalkBackwardLeft(); //walk up and left;
            if (_dir >= 157.5 && _dir < 202.5) Animate.WalkForwardLeft(); //walk left
            if (_dir >= 202.5 && _dir < 249.5) Animate.WalkForwardLeft(); //walk down and left;
            if (_dir >= 249.5 && _dir < 292.5) Animate.WalkForwards(); //walk down
            if (_dir >= 292.5 && _dir < 337.5) Animate.WalkForwardRight(); //walk down and right
        }

        //Stops the walk animate when the controller axis falls below a certain point.
        if(Mathf.Abs(Input.GetAxis("Vertical")) <= .2f && Mathf.Abs(Input.GetAxis("Horizontal")) <= .2f)
        {
            if(Animate.animState < 8)Animate.Stop();
        }

    }
}
