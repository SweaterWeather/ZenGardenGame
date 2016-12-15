using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
/// <summary>
/// Save plant Only
/// </summary>
public class SavePlant_Lloyd : MonoBehaviour {
    /// <summary>
    /// testing purposes for turning on and off loading
    /// 
    /// </summary>
    public bool isLoading = false;
    /// <summary>
    /// reference to the plant to be spawned when load
    /// </summary>
    public PlantGrowing_Lloyd plant;
    /// <summary>
    /// reference to itself
    /// </summary>
    public static SavePlant_Lloyd savePlant_Lloyd;
    /// <summary>
    /// name of the location
    /// </summary>
    public static string SAVEPLANTLOCATION = "Assets/Lloyd/Save_GameLloyd/";
    /// <summary>
    /// name of the file
    /// </summary>
    public static string SAVE_NAME = "PLANT_SAVE_DATA.txt";
    /// <summary>
    /// reference to all the plants in the scene
    /// </summary>
    PlantGrowing_Lloyd[] plants;
    /// <summary>
    /// reference to the position of those plant in x
    /// </summary>
    List<float> plantPositionsX = new List<float>();
    /// <summary>
    /// reference to the position of those plant in y
    /// </summary>
    List<float> plantPositionsY = new List<float>();
    /// <summary>
    /// reference to the position of those plant in z
    /// </summary>
    List<float> plantPositionsZ = new List<float>();

/// <summary>
/// inititate savePlant_Lloyd
/// </summary>
   void Start()
    {
        savePlant_Lloyd = this;
    }
    /// <summary>
    /// testing with save and load
    /// </summary>
    // Update is called once per frame
    void Update () {
        /*
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (!isLoading) savePlant();
            else loadPlant();


        }*/
	}
    /// <summary>
    /// save plant
    /// </summary>
    public void savePlant()
    {
        plants = FindObjectsOfType<PlantGrowing_Lloyd>();
        FileStream fs = null;
        try
        {
            getPlantPosition();
            PlantSaveData psd = new PlantSaveData(plantPositionsX,plantPositionsY,plantPositionsZ);
            fs = new FileStream(SAVEPLANTLOCATION + SAVE_NAME, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, psd);
            fs.Close();
            print("Save");
        }
        catch(Exception e)
        {
            print(e);
        }
        finally
        {
            if (fs != null) fs.Close();
        }
    
    }


    /// <summary>
    /// loading and spawning plant information
    /// </summary>
    public void loadPlant()
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream(SAVEPLANTLOCATION + SAVE_NAME, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            PlantSaveData psd = (PlantSaveData)bf.Deserialize(fs);
            spawnPlant(psd.plantPosX, psd.plantPosY, psd.plantPosZ);
            fs.Close();
            print("loaded");

        }
        catch(Exception e)
        {
            print(e);
        }
        finally
        {
            if (fs != null) fs.Close();
        }
    }


    /// <summary>
    /// spawn plant to the saved location
    /// </summary>
    /// <param name="x">list of x positon</param>
    /// <param name="y">list of y positon</param>
    /// <param name="z">list of z positon</param>
    void spawnPlant(List<float> x, List<float> y, List<float> z)
    {
        for(int i =0; i<x.Count; i++)
        {
            Instantiate(plant, new Vector3(x[i], y[i], z[i]), Quaternion.identity);
        }
    }

    /// <summary>
    /// find each plants position
    /// </summary>
    public void getPlantPosition()
    {
        List<float> posX = new List<float>();
        List<float> posY = new List<float>();
        List<float> posZ = new List<float>();
        for (int i = 0; i<plants.Length; i++)
        {
            posX.Add(plants[i].transform.position.x);
            posY.Add(plants[i].transform.position.y);
            posZ.Add(plants[i].transform.position.z);
        }

        plantPositionsX = posX;
        plantPositionsY = posY;
        plantPositionsZ = posZ;
    }
}


[Serializable]
///information of plants that is being serialized
class PlantSaveData
{/// <summary>
/// plant x direction
/// </summary>
   public List<float> plantPosX;
    /// <summary>
    /// plant Y direction
    /// </summary>
    public List<float> plantPosY;
    /// <summary>
    /// plant z direction
    /// </summary>
    public List<float> plantPosZ;
    /// <summary>
    /// default constructor for saving
    /// </summary>
    public PlantSaveData()
    {

    }
    /// <summary>
    /// saving plant position x y and z
    /// </summary>
    /// <param name="x">list of x position</param>
    /// <param name="y">list of y position</param>
    /// <param name="z">list of z position</param>
    public PlantSaveData(List<float>x, List<float>y, List<float>z)
    {
        plantPosX = x;
        plantPosY = y;
        plantPosZ = z;
    }
}