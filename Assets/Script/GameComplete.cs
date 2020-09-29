using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{

	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
