using UnityEngine;
using System.Collections;
/// <summary>
/// this class spawns house and place them
/// </summary>
public class SpawnHouse_Lloyd : MonoBehaviour {
    /// <summary>
    /// player can move the building if the building isn't place
    /// </summary>
  bool  isPlace =false;
    /// <summary>
    /// first house of the game
    /// </summary>
    public GameObject house1;
    /// <summary>
    /// this house is the reference of the house that hasn't place yet
    /// </summary>
    GameObject houseRef;
    /// <summary>
    /// the step process of making house
    /// </summary>
    int makingHouseStep = 1;
	
	
	// Update is called once per frame
	void Update () {

       /* if (Input.GetButton("SpawnBuilding"))
        {
           makeHouse(house1);
        }
        if (!isPlace)
        {

        }

    */
        switch (makingHouseStep)
        {
            case 1:
                if (Input.GetButton("SpawnBuilding"))
                {
                    print("hehehe");
                    makeHouse(house1);
                    makingHouseStep = 2;
                }
                break;
            case 2:
                moveHouse();

                break;

        }


	}
    /// <summary>
    /// making house spawn
    /// </summary>
    /// <param name="house">reference to the house obj</param>
    void makeHouse(GameObject house)
    {
        houseRef = (GameObject)Instantiate(house, getLocation(), Quaternion.identity);
    }
    /// <summary>
    /// setting house location
    /// </summary>
    /// <returns> return location of the object</returns>
    Vector3 getLocation()
    {
        float x = 1;
        float y = 1;
        float z = -1;
        Vector3 location = new Vector3(x, y, z);
        return location;
    }

    /// <summary>
    /// moving house in a grid position
    /// </summary>
    void moveHouse()
    {
        if(Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
        {
            int xDir = (int)Input.GetAxisRaw("Horizontal");
            int yDir = (int)Input.GetAxisRaw("Vertical");
            int x = (int)houseRef.transform.position.x + xDir;
            int y = (int)houseRef.transform.position.y + yDir;
            Vector3 move = new Vector3(x, y, houseRef.transform.position.z);

            houseRef.transform.position = move;
        }
       

       
        
    }


}
