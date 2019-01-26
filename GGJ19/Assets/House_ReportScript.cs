using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House_ReportScript : MonoBehaviour {

  

    int total1;
    int total2;
    int total3;
    

    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		


	}

    public void fill_total()
    {

        int zone = Random.Range(-1, 1);
        int house_Class = Random.Range(-1, 1);
        int furniture = Random.Range(-1, 1);
        int job = Random.Range(-1, 1);
        int virtue = Random.Range(-1, 1);
        int vice = Random.Range(-1, 1);

        total1 = zone + job;
        total2 = house_Class + virtue;
        total3 = furniture + vice;

    }
}
