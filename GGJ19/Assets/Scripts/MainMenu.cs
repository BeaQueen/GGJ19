using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayButton()
	{
		SceneManager.LoadScene("Intro");
	}

	public void CreditsButton()
	{
		SceneManager.LoadScene("Credits");
	}

	public void ExitButton()
	{
		Application.Quit();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
