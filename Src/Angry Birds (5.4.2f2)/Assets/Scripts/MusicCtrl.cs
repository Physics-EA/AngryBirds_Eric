using UnityEngine;
using System.Collections;

public class MusicCtrl : MonoBehaviour {

    public GameObject stop;
    bool open = false;
    // Use this for initialization
    void Start ()
    {
        stop.SetActive(false);

    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}


    public void Open()
    {
        if (open)
        {
            stop.SetActive(false);
            GetComponent<AudioSource>().mute = false;
            open = false;
        }
        else
        {
            stop.SetActive(true);
            GetComponent<AudioSource>().mute = true;
            open = true;
        }
    }
}
