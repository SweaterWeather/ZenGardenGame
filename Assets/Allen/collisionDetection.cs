using UnityEngine;
using System.Collections;

public class collisionDetection : MonoBehaviour {

    bool selected = false;
    public bool _plantVisible = false;

    void Update()
    {
        if (Input.GetButtonDown("WaterCan") && selected) //Q
        {
            if (this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing && ToolController.waterCounter > 0)
            {
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater = true;
 
 

                ToolController.waterCounter--;
                UI.water = ToolController.waterCounter;
                print("watered");
            }
            else
            {

                print("derp, use your hoe to plant a seed on this ground");

            }

        }
        if (Input.GetButtonDown("Hoe") && selected) //E
        {
            //start growing / plant seeds
            if (this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP <= 0)
            {
                print("you planted some wheat");
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing = true;

                _plantVisible = true;
            }


            //destroy / harvest plant if exp is passsed certain point.
            if (this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP >= 99)
            {
                AudioPlayer.PlayHarvestSound();
                //fully grown, you get 3 wheat. Congrats.
                print("you get 3 wheat because you were patient enough to wait until it was fully grown.");
                UI.crops += 3;

                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing = false;

                _plantVisible = false;
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater = false;
  
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP = 0;
                this.gameObject.transform.GetChild(1).GetComponent<Animator>().Play("Bud_Lloyd"); //resets the animator to frame 1
            }
            else if (this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP >= 66)
            {
                AudioPlayer.PlayHarvestSound();
                //not fully grown, you only get 1 wheat
                print("you get 1 wheat because you are impatient. Let plant grow!");
                UI.crops += 1;

                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing = false;

                _plantVisible = false;
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater = false;
            
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP = 0;
                this.gameObject.transform.GetChild(1).GetComponent<Animator>().Play("Bud_Lloyd"); //resets the animator to frame 1
            }
        }

        if (_plantVisible)
        {
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = true;
        } else
        {
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = false;
        }

        if (this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater)
        {
            this.gameObject.transform.GetChild(2).GetComponent<MeshRenderer>().enabled = true;
        } else
        {
            this.gameObject.transform.GetChild(2).GetComponent<MeshRenderer>().enabled = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Selector")
        {
            //I AM SELECTED
            
            this.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
            selected = true;
        }

        

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Selector")
        {
            //I AM NOT SELECTED
            
            this.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
            selected = false;
        }

    }
}
