using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceCanvasScript : MonoBehaviour {

    public GameObject map;
    public GameObject houses;
    public GameObject explorer;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MapAppIntro()
    {
        Debug.Log("IntroMap");
        map.SendMessage("IntroMap");
    }

    public void MapAppOutro()
    {
        Debug.Log("OutroMap");
        map.SendMessage("OutroMap");
    }

    public void HousesAppIntro()
    {
        Debug.Log("IntroHouses");
        houses.SendMessage("IntroHouses");
    }

    public void HousesAppOutro()
    {
        Debug.Log("OutroHouses");
        houses.SendMessage("OutroHouses");
    }

    public void ExplorerAppIntro()
    {
        Debug.Log("IntroExplorers");
        explorer.SendMessage("IntroExplorer");
    }

    public void ExplorerAppOutro()
    {
        Debug.Log("OutroExplorer");
        explorer.SendMessage("OutroExplorer");
    }

}
