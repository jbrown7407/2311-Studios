using UnityEngine;

public class EndingTrigger : MonoBehaviour
{

    public GameManager1 gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();

    }

}