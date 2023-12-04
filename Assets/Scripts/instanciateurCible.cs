using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciateurCible : MonoBehaviour
{
    public GameObject prefabCube;
    public Transform _lVL1;
    public Transform _lVL2;

    GameObject[] listeCube= new GameObject[15];
    Transform[] _tfCube = new Transform[15];
    string[] _listeTag = new string[4];
    private Quaternion rotationVide;
    private int i = 0;
    private float xmin1 = 48-10, xmax1 = 48+10, ymin1 = 1, ymax1 = 10, zmin1 = 80-10, zmax1 = 80+10;
    //private float xmin2 = -10, xmax2 = 10, ymin2 = 0, ymax2 = 10, zmin2 = -10, zmax2 = 10;
    
    // Start is called before the first frame update
    public Vector3 _genRandomPosition()
    {
        Vector3 pos = new Vector3(0,0,0);
        return(pos);
    }
    void Start()
    {
        //Init Liste Tag
        _listeTag[0] = "Bleu";
        _listeTag[1] = "Noir";
        _listeTag[2] = "Marron";
        _listeTag[3] = "Blanc";
        // init quaternion vide 
        rotationVide = new Quaternion(0, 0, 0, 0);


        //instanciation des 15 "cibles"
        for (i = 0; i < 15; i++)
        {
            listeCube[i] = Instantiate(prefabCube, new Vector3(Random.Range(xmin1, xmax1), Random.Range(ymin1, ymax1), Random.Range(zmin1, zmax1)), rotationVide, _lVL1);
            _tfCube[i] = listeCube[i].GetComponent<Transform>();
            _tfCube[i].tag = _listeTag[Random.Range(0, 3)];
        }



    }
    /*void Instanciate()
    {
        for (i = 0; i < 15; i++)
        {
            listeCube[i] = Instantiate(prefabCube, new Vector3(Random.Range(xmin1, xmax1), Random.Range(ymin1, ymax1), Random.Range(zmin1, zmax1)), rotationVide, _lVL1);
            _tfCube[i] = listeCube[i].GetComponent<Transform>();
            _tfCube[i].tag = _listeTag[Random.Range(0, 3)];
        }

    }
    */
  

    

    // Update is called once per frame
    void Update()
    {
      
    }
}
