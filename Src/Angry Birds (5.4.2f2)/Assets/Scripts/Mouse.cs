using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour
{

    //public Texture2D myCursor;
    //public Texture2D myClickCursor;
    //bool isClicked = false;
    //public float cursorWidth;
    //public float cursorHeight;

    public Ray ray;
    public Vector3 v3;
    public bool pull = false;
    public float sensitivity = 10f;
    float fov;

    // Use this for initialization
    void Start()
    {
        //UnityEngine.Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        v3 = ray.origin;
        //ray.origin;
        fov = Camera.main.orthographicSize;
        fov -= Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && Camera.main.orthographicSize != 5)
        {
            Camera.main.transform.position = new Vector3(Mathf.Clamp(ray.origin.x,-5,9), Mathf.Clamp(ray.origin.y, -5, 4), -10);
            
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Camera.main.transform.position = new Vector3(0, 0, -10);
        }
        Camera.main.orthographicSize = fov;

        if (fov >= 10)
        {
            Camera.main.orthographicSize = 10;
        }
        else if (fov <= 5)
        {
            Camera.main.orthographicSize = 5;
        }
        else
        {

        }


        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        v3 = ray.origin;
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                pull = true;
                
            }
        }
    }
}
