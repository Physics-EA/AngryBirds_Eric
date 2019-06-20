using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{

    public void chooseIt()
    {
        Debug.Log(name);
        SceneManager.LoadScene(name);
    }
}
