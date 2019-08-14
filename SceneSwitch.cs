
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour

{
    void OnTriggerEnter(Collider other)
    {
		//SceneManager.LoadScene(2);
		//change # to switch scenes manually
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}