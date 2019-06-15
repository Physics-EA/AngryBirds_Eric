using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SceneTwoCtrl : MonoBehaviour {

    public GameObject Black;
    public GameObject yes;
    public GameObject teach;
    public GameObject loss;
    public GameObject win;
    public List<GameObject> stars;
    // Use this for initialization
    void Start ()
    {
        Black.SetActive(false);
        yes.SetActive(false);
        teach.SetActive(false);
        loss.SetActive(false);
        win.SetActive(false);
        for (int i = 0; i < stars.Count; i++)
        {
            stars[i].SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void pauseGame()
    {
        Black.SetActive(true);
    }

    public void continuGame()
    {
        Black.SetActive(false);
        yes.SetActive(false);
        teach.SetActive(false);
    }

    public void plaAgain()
    {
        Application.LoadLevel(Application.loadedLevelName);
    }

    public void TeachScene()
    {
        teach.SetActive(true);
        yes.SetActive(true);
    }

    public void SelectCheckpoint()
    {
        SceneManager.LoadScene(0);
    }

}
