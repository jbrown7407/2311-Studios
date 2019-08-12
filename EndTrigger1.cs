
using UnityEngine;

public class EndTrigger1 : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();

    }

}