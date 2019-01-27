using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HousesManager : MonoBehaviour
{
    #region Singleton
    public static HousesManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = gameObject.GetComponent<HousesManager>();
    }
    #endregion

    public House[] gameHouses = new House[20];

    public SpriteRenderer SpritePhoto;
    public Text TextZone;
    public Text TextFurniture;
    public Text TextType;

    public Text HouseValue;

    int HouseValueTotal;

    bool appIn = false;

    int max_next;

    public void ShowHouse(int gameHouseIndex)
    {
        SpritePhoto.sprite = gameHouses[gameHouseIndex].HouseTypeImg;
        TextZone.text = gameHouses[gameHouseIndex].HouseZoneStr;
        TextFurniture.text = gameHouses[gameHouseIndex].HouseFurnitureStr;
        TextType.text = gameHouses[gameHouseIndex].HouseTypeStr;
        HouseValueTotal = gameHouses[gameHouseIndex].HouseZone + gameHouses[gameHouseIndex].HouseType + gameHouses[gameHouseIndex].HouseFurniture;
        HouseValue.text = HouseValueTotal.ToString();
    }

    public int CalculateHouseMoney(int gameHouseIndex)
    {
        //Para BEA: Esto es solo de ejemplo. Hacerlo con la fórmula que sea
        
        return gameHouses[gameHouseIndex].HouseZone + gameHouses[gameHouseIndex].HouseType + gameHouses[gameHouseIndex].HouseFurniture;
     
    }


    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}




    public void IntroHouses()
    {
        if (appIn == false)
        {
            this.GetComponent<Animator>().Play("AppIntro");
            appIn = true;
        }

    }

    public void OutroHouses()
    {
        if (appIn == true)
        {
            this.GetComponent<Animator>().Play("AppOutro");
            appIn = false;
        }

    }

}
