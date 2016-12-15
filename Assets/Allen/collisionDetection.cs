using UnityEngine;
using System.Collections;

public class collisionDetection : MonoBehaviour {

    //This script was originally intended to just see if the object was selected, it turned into a game mechanic script for the individual tiles. Yay duck tape.

        /// <summary>
        /// selected: is this tile selected?
        /// _plantVisible: are there plants to render? (has the player planted anything on this tile?)
        /// </summary>
    bool selected = false;
    public bool _plantVisible = false;

    /// <summary>
    /// Runs every frame.
    /// </summary>
    void Update()
    {
        //if water can is used while this tile is selected.
        if (Input.GetButtonDown("WaterCan") && selected) //Q
        {
            //grabs info that is attached to a child object.
            //if this tile currently has a plant that is growing, allow player to apply water to the tile
            if (this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing && ToolController.waterCounter > 0)
            {
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater = true;

                AudioPlayer.PlayWaterSound();

                ToolController.waterCounter--;
                UI.water = ToolController.waterCounter;
                //print("watered");
            }
            else
            {

                //print("derp"); //DEBUG

            }

        }
        //if how is used while this tile is selected.
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
            if (this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP >= 99) //fully grown, you get more crops.
            {
                AudioPlayer.PlayHarvestSound();
                //fully grown, you get 3 wheat. Congrats.
                //resets the plant as if it had not been grown and it disappears from the tile
                UI.crops += 3;
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing = false;
                _plantVisible = false;
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater = false;  
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP = 0;
                this.gameObject.transform.GetChild(1).GetComponent<Animator>().Play("Bud_Lloyd"); //resets the animator to frame 1
            }
            else if (this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP >= 66) //if plant has grown enough to harvest, but isnt fully grown. Reduced reward.
            {
                AudioPlayer.PlayHarvestSound();
                //not fully grown, you only get 1 wheat, resets the plant as if it had not been grown and it disappears from the tile
                UI.crops += 1;
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing = false;
                _plantVisible = false;
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater = false;            
                this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP = 0;
                this.gameObject.transform.GetChild(1).GetComponent<Animator>().Play("Bud_Lloyd"); //resets the animator to frame 1
            }
        }

        //logic that determines if the plant is visible.
        if (_plantVisible)
        {
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = true;
        } else
        {
            this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = false;
        }
        //logic that determines if the water indicator on this tile is visible.
        if (this.gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater)
        {
            this.gameObject.transform.GetChild(2).GetComponent<MeshRenderer>().enabled = true;
        } else
        {
            this.gameObject.transform.GetChild(2).GetComponent<MeshRenderer>().enabled = false;
        }
    }


    //This collision script detects if the selector is on this specific tile.
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
