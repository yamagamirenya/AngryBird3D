using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateObject: MonoBehaviour
{

    // Use this for initialization


    public Color color;
    public Texture2D tex; 
    public GameObject[,] prefabs; 
    
    public int i, f;

    public void Start()
    {
         
        prefabs = new GameObject[tex.width, tex.height];

        for (i = 0; i<tex.width; i++)
        {
            for(f=0; f< tex.height; f++)
            {
                prefabs[i, f] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                prefabs[i, f].GetComponent<Renderer>().material.color = tex.GetPixel(i, f);            
                prefabs[i, f].transform.position = new Vector3(30, f,  i-20);
                prefabs[i, f].gameObject.AddComponent<Rigidbody>();
            }
        }
    }

    
     void OnCollisionEnter(Collision other)
    {

        for (i = 0; i < tex.width; i++)
        {
            for (f = 0; f < tex.height; f++)
            {
                if (other.gameObject == prefabs[i, f])
        {
                 
                    prefabs[i, f].GetComponent<Renderer>().material.color= Color.red;
                 //   prefabs[i, f].gameObject.AddComponent<BoxCollider>().enabled = true;
                    


                }
            }
        }
    }
   
}
