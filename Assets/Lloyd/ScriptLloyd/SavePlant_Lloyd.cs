using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
/// <summary>
/// Save plant Only
/// </summary>
public class SavePlant_Lloyd : MonoBehaviour
{
    /// <summary>
    /// Money value to be saved.
    /// </summary>
    int money;
    /// <summary>
    /// Water value to be saved.
    /// </summary>
    int waterAmmount;
    /// <summary>
    /// Crop value to be saved.
    /// </summary>
    int cropAmmount;
    /// <summary>
    /// testing purposes for turning on and off loading
    /// 
    /// </summary>
    public bool isLoading = false;
    /// <summary>
    /// reference to the plant to be spawned when load
    /// </summary>
    public FlagForSaving plant;
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
    FlagForSaving[] plants;
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
    /// set water
    /// </summary>
    List<bool> isWater = new List<bool>();
    /// <summary>
    /// setvisible of plant
    /// </summary>
    List<bool> isVisible = new List<bool>();
    /// <summary>
    /// A list containing all isGrowing bools for every plant in the game.
    /// </summary>
    List<bool> isGrowing = new List<bool>();
    /// <summary>
    /// A list containting all the growth exp values of every plant in the game.
    /// </summary>
    List<float> growthEXP = new List<float>();

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
        
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (!isLoading) savePlant();
            else loadPlant();


        }
	}

    /// <summary>
    /// This function triggers the game to delete your previous save data.
    /// </summary>
    public static void delete()
    {
        try { File.Delete(SAVEPLANTLOCATION + SAVE_NAME); }
        catch(Exception gyrados)
        {
            print(gyrados);
        }
          
   


    }
    /// <summary>
    /// save plant
    /// </summary>
    public void savePlant()
    {
        money = UI.score;
        cropAmmount = UI.crops;
        waterAmmount = UI.water;
        plants = FindObjectsOfType<FlagForSaving>();
        FileStream fs = null;
        try
        {
            setWaterAndVisible();
            ///getPlantPosition();
            PlantSaveData psd = new PlantSaveData(isWater,isVisible,isGrowing,growthEXP, money, cropAmmount, waterAmmount);
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
    /// set water and its visible
    /// </summary>
    public void setWaterAndVisible(){
        isVisible.Clear();
        isWater.Clear();
        isGrowing.Clear();
        growthEXP.Clear();
        for(int i = 0; i < plants.Length; i++)
        {
            isWater.Add(plants[i].gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater);
            isVisible.Add(plants[i].gameObject.GetComponent<collisionDetection>()._plantVisible);
            isGrowing.Add(plants[i].gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing);
            growthEXP.Add(plants[i].gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP);
        }



        }

    /// <summary>
    /// This function loads the values of all the UI values.
    /// </summary>
    /// <param name="mon">The money, or score.</param>
    /// <param name="wah">THe water ammount.</param>
    /// <param name="crop">How many crops are harvested.</param>
    public void LoadingMoney(int mon, int wah, int crop)
    {
        UI.crops = crop;
        ToolController.waterCounter = wah;
        UI.water = wah;
        UI.score = mon;
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

            LoadingMoney(psd.money, psd.waterr, psd.crops);
            planted(psd.isWaterVis, psd.isVisible, psd.isGrowing, psd.growthExp);
           // spawnPlant(psd.plantPosX, psd.plantPosY, psd.plantPosZ);
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
    /// repopulate plant from previous save
    /// </summary>
    public void planted(List<bool>water, List<bool>visible, List<bool>growing, List<float>exp)
    {
        FlagForSaving[] plants = FindObjectsOfType<FlagForSaving>();

        for(int i = 0; i < plants.Length; i++)
        {
            plants[i].gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isWater = water[i];
            plants[i].gameObject.GetComponent<collisionDetection>()._plantVisible = visible[i];
            plants[i].gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().isGrowing = growing[i];
            plants[i].gameObject.transform.GetChild(1).GetComponent<PlantGrowing_Lloyd>().growthEXP = exp[i];
            plants[i].gameObject.transform.GetChild(1).GetComponent<Animator>().SetFloat("growthEXP",exp[i]);
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
{
    /// <summary>
    /// THe ammount of money
    /// </summary>
    public int money;
    /// <summary>
    /// THe ammount of money
    /// </summary>
    public int waterr;
    /// <summary>
    /// THe ammount of money
    /// </summary>
    public int crops;
    /// <summary>
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
    /// track if seed are watered
    /// </summary>
    public List<bool> isWaterVis;
    /// <summary>
    /// track if seeds are visible
    /// </summary>
    public List<bool> isVisible;
    /// <summary>
    /// A list of all isGrowing bools.
    /// </summary>
    public List<bool> isGrowing;
    /// <summary>
    /// A list of all plant growth values.
    /// </summary>
    public List<float> growthExp;
    /// <summary>
    /// default constructor for saving
    /// </summary>
    /// 
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
    /// <summary>
    /// This function sets the values of all plants.
    /// </summary>
    /// <param name="water">The plants watered satus.</param>
    /// <param name="visible">Whether the plant is visible or not.</param>
    /// <param name="growing">Whether the plant is growning or not.</param>
    /// <param name="exp">The plant's exp.</param>
    /// <param name="mon">The money that the player has.</param>
    /// <param name="crop">The ammount of crops that the player has.</param>
    /// <param name="wah">The ammount of water that the player has.</param>
    public PlantSaveData(List<bool>water, List<bool> visible, List<bool> growing, List<float> exp, int mon, int crop, int wah)
    {
        isWaterVis = water;
        isVisible = visible;
        isGrowing = growing;
        growthExp = exp;
        waterr = wah;
        crops = crop;
        money = mon;

    }
}