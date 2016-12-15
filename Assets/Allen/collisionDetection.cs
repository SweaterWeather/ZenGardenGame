using UnityEngine;
using System.Collections;

public class collisionDetection : MonoBehaviour {

    bool selected = false;
	
	void Update()
    {
        if (Input.GetButtonDown("WaterCan") && selected) //Q
        {
            if (this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing)
            {
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater = true;
            }
            else
            {
                
                print("derp, use your hoe to plant a seed on this ground");              

            }

        }
        if (Input.GetButtonDown("Hoe") && selected) //E
        {
            //start growing / plant seeds
            if(this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP <= 0)
            {
                print("you planted some wheat");
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing = true;
                this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = true;
            }


            //destroy / harvest plant if exp is passsed certain point.
            if(this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP >= 99)
            {
                //fully grown, you get 3 wheat. Congrats.
                print("you get 3 wheat because you were patient enough to wait until it was fully grown.");

                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing = false;
                this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = false;
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP = 0;
                this.gameObject.transform.GetChild(1).GetComponent<Animator>().Play("Bud_Lloyd");
            }
            else if(this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP >= 66)
            {
                //not fully grown, you only get 1 wheat
                print("you get 1 wheat because you are impatient. Let plant grow!");

                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing = false;
                this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = false;
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP = 0;
                this.gameObject.transform.GetChild(1).GetComponent<Animator>().Play("Bud_Lloyd");
            }
        }
    }

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
