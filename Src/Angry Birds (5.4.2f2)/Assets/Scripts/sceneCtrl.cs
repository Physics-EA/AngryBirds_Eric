using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class sceneCtrl : MonoBehaviour {

    public bool OneSceneTurn;
    public GameObject scene;

    string SceneName;
	// Use this for initialization
	void Start ()
    {
        
        DontDestroyOnLoad(transform.gameObject);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (SceneManager.GetActiveScene().name == "S0")
        {
            if (scene == null)
            {
                Destroy(gameObject);
            }
        }

        if (scene != null)
        {
            OneSceneTurn = scene.GetComponent<SceneOneCtrl>().turn;
        }


        SceneName = SceneManager.GetActiveScene().name;
        string[] SceneNameNum = SceneName.Split('S');
        if (GameObject.Find("score" + SceneNameNum[1]) != null)
        {
            if (int.Parse(GameObject.Find("score" + SceneNameNum[1]).GetComponent<Text>().text) > PlayerPrefs.GetInt("score_Level" + SceneNameNum[1]))
            {
                //存储数据
                PlayerPrefs.SetInt("score_Level" + SceneNameNum[1], int.Parse(GameObject.Find("score" + SceneNameNum[1]).GetComponent<Text>().text));
            }
        }

        if (GameObject.Find("score" + SceneNameNum[1] + "_"+ SceneNameNum[1]) != null)
        {
            GameObject.Find("score" + SceneNameNum[1] + "_" + SceneNameNum[1]).GetComponent<Text>().text = PlayerPrefs.GetInt("score_Level" + SceneNameNum[1]).ToString();
        }
    }
}
