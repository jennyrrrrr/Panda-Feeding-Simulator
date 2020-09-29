using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameHasEnded = false;
	public float restartDelay = 1f;
	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		Debug.Log("GAME com");
		completeLevelUI.SetActive(true);
	}

	// Start is called before the first frame update
	public void EndGame() {
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("GAME OVER");
			//Invoke("Restart", restartDelay);
		}
	}
}
