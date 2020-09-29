using UnityEngine;

public class PandaCollision : MonoBehaviour
{

	void OnCollisionEnter(Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle")
		{
			Debug.Log("??/");

			FindObjectOfType<GameManager>().EndGame();
		}
	}

}
