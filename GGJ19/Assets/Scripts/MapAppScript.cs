using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapAppScript : MonoBehaviour {

    public int NumMapButtons = 20;

    public Button[] mapButtons = new Button[20];

    bool appIn = true;

	// Use this for initialization
	void Start ()
    {
        int numActiveButtons = 0;

        while (numActiveButtons < 10)
        {
            int rndIndex = Random.Range(0, NumMapButtons - 1);

            if (!mapButtons[rndIndex].enabled)
            {
                mapButtons[rndIndex].enabled = true;
                numActiveButtons++;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IntroMap()
    {
        if(appIn == false)
        {
            this.GetComponent<Animator>().Play("AppIntro");
            appIn = true;
        }

    }

    public void OutroMap()
    {
        if (appIn == true)
        {
            this.GetComponent<Animator>().Play("AppOutro");
            appIn = false;
        }

    }
}
