using UnityEngine;
using System.Collections;
using System.Collections.Generic;
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
    /// the list of point where the house can spawn
    /// </summary>
    public List<GameObject> spawnPoint;

    /// <summary>
    /// what point is already used
    /// </summary>
     List<int> usedLocation;
    /// <summary>
    /// this house is the reference of the house that hasn't place yet
    /// </summary>
    GameObject houseRef;
    /// <summary>
    /// the step process of making house
    /// </summary>
    int makingHouseStep = 1;

    /// <summary>
    /// the index of the location that the house can build on
    /// </summary>

    int indexOfSpawnLocation = 0;
	/// <summary>
    /// initiate used Location
    /// </summary>
    void Start()
    {
        usedLocation = new List<int>();
    }
	
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
                switchLocation();

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
        indexOfSpawnLocation = 0;
        if (usedLocation.Count > 0)
        {

            while (checkPoint(indexOfSpawnLocation))
            {
                print("eeee");
                indexOfSpawnLocation++;
                if (indexOfSpawnLocation > (spawnPoint.Count - 1))
                {
                    indexOfSpawnLocation = 0;
                }

            }
        }


        float camX = spawnPoint[indexOfSpawnLocation].transform.position.x;
        float camY = spawnPoint[indexOfSpawnLocation].transform.position.y;


        Camera.main.transform.position = new Vector3(camX, camY, Camera.main.transform.position.z);
       // houseRef.transform.position = spawnPoint[indexOfSpawnLocation].transform.position;


        float x = spawnPoint[indexOfSpawnLocation].transform.position.x;
        float y = spawnPoint[indexOfSpawnLocation].transform.position.y;
        float z = spawnPoint[indexOfSpawnLocation].transform.position.z;
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
    /// <summary>
    /// switching the location of the house ref gameObject
    /// </summary>
    void switchLocation()
    {
       // indexOfSpawnLocation = 0;

        if (Input.GetButtonDown("Horizontal") )
        {
            float direction = Input.GetAxisRaw("Horizontal");
            Mathf.Clamp(indexOfSpawnLocation += (int)Input.GetAxisRaw("Horizontal"), 0, 1);
            if (indexOfSpawnLocation > (spawnPoint.Count -1))
            {
                indexOfSpawnLocation = 0;
            }
            if (indexOfSpawnLocation < 0)
            {
                indexOfSpawnLocation = (spawnPoint.Count - 1);
            }
             if (usedLocation.Count>0)
             {
                
                 while (checkPoint(indexOfSpawnLocation))
                 {
                    if (direction > 0)
                    {
                        indexOfSpawnLocation++;
                        if (indexOfSpawnLocation > (spawnPoint.Count - 1))
                        {
                          
                            indexOfSpawnLocation = 0;
                        }
                    }
                    else
                    {
                        indexOfSpawnLocation--;
                        if (indexOfSpawnLocation < 0)
                        {
                          
                            indexOfSpawnLocation = (spawnPoint.Count - 1);
                        }
                    }
                   
                    
                 }
             }
           

            float camX = spawnPoint[indexOfSpawnLocation].transform.position.x;
            float camY = spawnPoint[indexOfSpawnLocation].transform.position.y;


            Camera.main.transform.position = new Vector3(camX, camY, Camera.main.transform.position.z);
            houseRef.transform.position = spawnPoint[indexOfSpawnLocation].transform.position;

        }

        if (Input.GetButtonDown("Vertical"))
        {
            usedLocation.Add(indexOfSpawnLocation);

            print(usedLocation.Count+"  "+ indexOfSpawnLocation);
            makingHouseStep = 1;
        }




    }
    /// <summary>
    /// checking if the spawn is overlapping with other spawning point
    /// </summary>
    /// <param name="spawnLocationIndex">the location of the house based on the spawning point</param>
    /// <returns>the index of location in spawn point</returns>
    bool checkPoint(int spawnLocationIndex)
    {
        
        for(int i =(usedLocation.Count-1); i >=0; i--)
        {
           
            if (usedLocation[i] == spawnLocationIndex)
            {
                return true;
            }
            print("used Point " + usedLocation[i] + " spawnPointIndex " + spawnLocationIndex);
        }

        return false;
    }
}
