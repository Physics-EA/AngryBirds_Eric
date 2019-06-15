using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainGameCtrl : MonoBehaviour {

    public Mouse mouse;
    public List<birdMove> birds;
    public int step = 0;
    public GameObject pigScoreShow;
    public GameObject woodLScoreShow;
    public GameObject Bexplosion;
    public GameObject Wexplosion;
    public GameObject SlingShotR;
    public SceneTwoCtrl scene;
    public scoreCtrl score;
    public int twoStar;
    public int threeStar;
    public List<GameObject> pigs;
    int i = 0; 
    // Use this for initialization
    void Start ()
    {
        pigScoreShow.SetActive(false);
        woodLScoreShow.SetActive(false);
        Bexplosion.SetActive(false);
        Wexplosion.SetActive(false);
    }
	
    
	// Update is called once per frame
	void Update ()
    {
        if (step == 1)
        {
            birds[i].myturn = true;
            step = 2;
        }
        if (step == 2)
        {
            if (birds[i].birdStep == 1)
            {
                if (i<birds.Count - 1 )
                {
                    i++;
                    mouse.pull = false;
                    step = 1;
                }
                else
                {
                    mouse.pull = false;
                    SlingShotR.GetComponent<BoxCollider>().enabled = false;
                    step = 3;
                }
            }
        }

        if (step == 3)
        {
            if (birds[i].birdStep == 4 || birds[i] == null)
            {
                step = 4;
            }
            
        }


        if (step == 4)
        {
            SlingShotR.GetComponent<BoxCollider>().enabled = false;
            for (int j = 0; j < pigs.Count; j++)
            {
                if (pigs[j] != null)
                {
                    step = 5;
                    Invoke("loss", 4f);
                    break;
                }
            }
        }

        if (step == 4)
        {
            step = 5;
            Invoke("win", 4f);
            
        }
    }

   void loss()
    {
        scene.loss.SetActive(true);
    }

    void win()
    {
        scene.win.SetActive(true);
        scene.stars[0].SetActive(true);
        if (score.score > twoStar)
        {
            Invoke("TwoStar",1f);
        }

        if (score.score > threeStar)
        {
            Invoke("ThreeStar", 2f);
        }
    }

    void TwoStar()
    {
        scene.stars[1].SetActive(true);
    }
    void ThreeStar()
    {
        scene.stars[2].SetActive(true);
    }

}
