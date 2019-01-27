using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndCanvasScript : MonoBehaviour
{

    bool appIn = false;


    public GameObject gameManager;

   



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IntroEndCanvas()
    {
        if (appIn == false)
        {
            this.GetComponent<Animator>().Play("AppIntro");
            appIn = true;
        }

    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
