using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// Use this for initialization

	public void StartGame () 
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	
	}
	
    public void QuitGame()
    {
        Debug.Log("The game Quit");
        Application.Quit();
    }
	// Update is called once per frame
	void Update () {
	
	}
}
