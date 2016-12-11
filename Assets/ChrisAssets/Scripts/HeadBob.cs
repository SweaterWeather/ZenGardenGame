using UnityEngine;
using System.Collections;
/// <summary>
/// This script bobs the head a bit.  That's all.
/// </summary>
public class HeadBob : MonoBehaviour {
    /// <summary>
    /// A bool to control whether or not you move your head up and down, to make walking look smoother.
    /// </summary>
    public bool pause = true;

	/// <summary>
    /// Here takes place the bobbing.
    /// </summary>
	void Update () {
        if (pause) return;
        float yDisplace = Mathf.Cos(Time.time * 15)* .005f;
        Vector3 pos = new Vector3(transform.localPosition.x, transform.localPosition.y + yDisplace, transform.localPosition.z);
        transform.localPosition = pos;
	}
}
