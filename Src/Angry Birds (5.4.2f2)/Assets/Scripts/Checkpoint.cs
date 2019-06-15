using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {

	public void chooseIt()
    {
        SceneManager.LoadScene(name);
    }
}
