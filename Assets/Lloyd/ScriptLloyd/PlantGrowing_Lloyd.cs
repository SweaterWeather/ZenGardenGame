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
    public float growthEXP = 0;
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
    public bool isWater = false;
    public bool isGrowing = false;
    /// <summary>
    /// the stage of the plant
    /// 0 = seed
    /// 1= bud
    /// 2= small flower
    /// 3 = big flower
    /// </summary>
    int stage = 0;
    /// <summary>
    /// initiate ani to reference the animator component
    /// </summary>
	void Start () {
       
        ani = GetComponent<Animator>();
	}
	
    /// <summary>
    /// updating growthEXP
    /// </summary>
	void Update () {

        if (isWater)
        {
            growthEXP += Time.deltaTime * growthSpeed * 1.5f;
            }
        else if (isGrowing)
        {
            growthEXP += Time.deltaTime * growthSpeed;
        }
       
        if (growthEXP > growthMaxEXP)
        {
           
            growthEXP = growthMaxEXP;
            stage = (int)(growthEXP / 33.333f);
           // print(stage);
        }
        else
        {
            ani.SetFloat("growthEXP", growthEXP);
            stage = (int)(growthEXP / 33.333f);

        }
	}
}
