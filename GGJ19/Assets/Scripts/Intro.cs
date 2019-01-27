using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

	public void ReturnButton()
	{
		SceneManager.LoadScene("Mapa");
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			SceneManager.LoadScene("MainMenu");
		}
	}
}
