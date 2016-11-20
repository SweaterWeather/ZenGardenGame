using UnityEngine;
using System.Collections;
/// <summary>
/// this class controls how the plant grows
/// </summary>
public class PlantGrowing_Lloyd : MonoBehaviour {
    /// <summary>
    /// the maximum growth of the plant
    /// </summary>
    float growthMaxEXP=100;
    /// <summary>
    /// the experience of the gameObject gets overtime
    /// </summary>
    float growthEXP = 0;
    /// <summary>
    /// a multiplier for the growth exp
    /// </summary>
   public float growthSpeed = 1;
    /// <summary>
    /// reference to the animator of the gameObject
    /// </summary>
    Animator ani;
    /// <summary>
    /// check if the gameObject is watered
    /// </summary>
    bool isWater = false;

	// Use this for initialization
	void Start () {
        ani = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        growthEXP += Time.deltaTime * growthSpeed;
        if (growthEXP > growthMaxEXP)
        {
            growthEXP = growthMaxEXP;
        }
        else
        {
            ani.SetFloat("growthEXP", growthEXP);
        }
	}
}
