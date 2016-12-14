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
    public static string SAVEPLANTLOCATION = "Assets/Lloyd/Save_GameLloyd/";
    public static string SAVE_NAME = "PLANT_SAVE_DATA.txt";
    /// <summary>
    /// reference to all the plants in the scene
    /// </summary>
    PlantGrowing_Lloyd[] plants;
    /// <summary>
    /// reference to the position of those plant
    /// </summary>
    List<Vector3> plantPostions;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.V))
        {
            savePlant();
            
        }
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
            PlantSaveData psd = new PlantSaveData(plants);
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
}


[Serializable]
class PlantSaveData
{
    PlantGrowing_Lloyd[] savedPlants;
    public PlantSaveData()
    {

    }

    public PlantSaveData(PlantGrowing_Lloyd[] importPlants)
    {
        savedPlants = importPlants;
    }
}