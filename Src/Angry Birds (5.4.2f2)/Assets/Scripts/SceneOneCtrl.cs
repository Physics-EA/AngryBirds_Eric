using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneOneCtrl : MonoBehaviour {

    public GameObject start;
    public GameObject selection;
    public GameObject title;
    public GameObject returnBack;
    public GameObject music;
    public GameObject opition;
    public bool turn = false;
    // Use this for initialization
    void Start ()
    {
        selection.SetActive(false);
        returnBack.SetActive(false);
        if (GameObject.Find("SceneCtrl") != null)
        {
            turn = GameObject.Find("SceneCtrl").GetComponent<sceneCtrl>().OneSceneTurn;
        }

        if (turn)
        {
            chooseLevel();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    public void chooseLevel()
    {
        selection.SetActive(true);
        returnBack.SetActive(true);
        start.SetActive(false);
        title.SetActive(false);
        music.transform.position = opition.transform.position;
        opition.transform.GetChild(0).GetComponent<OptionCtl>().open = false;
        music.GetComponent<Image>().enabled = false;
        music.transform.GetChild(0).gameObject.SetActive(false);
        opition.SetActive(false);
        turn = true;
    }

    public void backToStart()
    {
        selection.SetActive(false);
        returnBack.SetActive(false);
        start.SetActive(true);
        title.SetActive(true);
        music.GetComponent<Image>().enabled = true;
        music.transform.GetChild(0).gameObject.SetActive(true);
        opition.SetActive(true);
        turn = false;
    }
}
