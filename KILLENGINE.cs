using UnityEngine;

public class KILLENGINE : MonoBehaviour
{

    public CubeX movement;


    void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager1>().EndGame();
        }
    }
}

