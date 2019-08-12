
using UnityEngine;

public class ET : MonoBehaviour
{

	public GameManager gameManager;

	void OnTriggerEnter()
	{
		gameManager.CompleteLevel();

	}

}