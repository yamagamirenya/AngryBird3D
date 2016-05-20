using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateObject: MonoBehaviour
{

    // Use this for initialization


    public Color color;
    public Texture2D tex;
    //private Texture texture=null; 
    public GameObject prefab;
    GameObject[,] prefabs;

    void Start()
    {
        prefabs = new GameObject[tex.width, tex.height];

        for (int i = 0; i<tex.width; i++)
        {
            for(int f=0; f< tex.height; f++)
            {
                prefabs[i, f] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                prefabs[i, f].GetComponent<Renderer>().material.color = tex.GetPixel(i, f);
                prefabs[i, f].transform.position = new Vector3(i, f, 0);


               // int a = tex.width/2-Mathf.Abs(tex.width/2-i);
                //int b = tex.height/2-Mathf.Abs(tex.height/2-f);
                //prefabs[i, f].transform.localScale = new Vector3(1, 1, a*b/10);

            }
        }


    
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {



         

            Vector3 screen_position = Input.mousePosition;
            screen_position.z = GameObject.Find("Main_Camera").transform.position.z;

             Vector3 position_world = Camera.main.ScreenToWorldPoint(screen_position);

            print(screen_position);
            print(position_world);
            print(tex.width);
            print(tex.height);



          

            //Below can make a little 3D
            for (int i = 0; i < tex.width; i++)
            {
                for (int f = 0; f < tex.height; f++)
                {
                   

                  
                    float a = Mathf.Abs(position_world.x-tex.width/2) - Mathf.Abs(Mathf.Abs(position_world.x-tex.width/2) - i);
                    float b = Mathf.Abs(position_world.y-tex.width/2) - Mathf.Abs(position_world.y-tex.width/2 - f);
                    prefabs[i, f].transform.localScale = new Vector3(1, 1, a * b/10 );
                }
            }

        }

    }

}
