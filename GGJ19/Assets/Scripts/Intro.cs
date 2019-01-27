using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

	public void ReturnButton()
	{
		SceneManager.LoadScene("Mapa");
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			SceneManager.LoadScene("Mapa");
		}
	}
}
