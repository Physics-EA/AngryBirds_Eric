using UnityEngine;
using System.Collections;

public class OptionCtl : MonoBehaviour {

    public GameObject go;
    public GameObject music;
    float CanClick = 0.5f;
    public bool open = false;
    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        CanClick += Time.deltaTime;
        if (CanClick > 1)
        {
            CanClick = 1;
        }
    }

    public void Open()
    {
        if (CanClick > 0.9f)
        {
            CanClick = 0;
            if (!open)
            {
                go.GetComponent<Animation>().Play("L");
                music.GetComponent<Animation>().Play("U");
                open = true;
            }
            else
            {
                go.GetComponent<Animation>().Play("R");
                music.GetComponent<Animation>().Play("D");
                open = false;
            }
        }
        
    }
}
