using UnityEngine;

public class AteTrigger : MonoBehaviour
{

	public GameManager gameManager;

	void OnTriggerEnter()
	{
		gameManager.CompleteLevel();
	}

}

