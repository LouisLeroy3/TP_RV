using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciateurCible : MonoBehaviour
{
    public GameObject prefabCube;
    public GameObject prefabCube_LVL3;

    public Transform _lVL1;
    public Transform _lVL3;

    GameObject[] listeCube= new GameObject[15];
    Transform[] _tfCube = new Transform[15];
    public string[] _listeTag = new string[4];
    private Quaternion rotationVide;
    private int i = 0;
    private float xmin1 = 49, xmax1 = 47+10, ymin1 = 1, ymax1 = 10, zmin1 = 80-10, zmax1 = 80+10;
    private float xmin3 , xmax3 , ymin3, ymax3 , zmin3 , zmax3 ;
    public int range;
    
    // Start is called before the first frame update
    public Vector3 _genRandomPosition()
    {
        Vector3 pos = new Vector3(0,0,0);
        return(pos);
    }
    void Start()
    {
        range = 2;
        xmin3=_lVL3.position.x-range;
        xmax3 = _lVL3.position.x + range;

        ymin3 = _lVL3.position.y +4;
        ymax3 = _lVL3.position.y+8;

        zmin3 = _lVL3.position.z - range;
        zmax3 = _lVL3.position.z + range;



        //Init Liste Tag
        _listeTag[0] = "Bleu";
        _listeTag[1] = "Noir";
        _listeTag[2] = "Rouge";
        _listeTag[3] = "Blanc";
        // init quaternion vide 
        rotationVide = new Quaternion(0, 0, 0, 0);


        //instanciation des 15 "cibles"
        /*for (i = 0; i < 15; i++)
        {
            listeCube[i] = Instantiate(prefabCube, new Vector3(Random.Range(xmin1, xmax1), Random.Range(ymin1, ymax1), Random.Range(zmin1, zmax1)), rotationVide, _lVL1);
            _tfCube[i] = listeCube[i].GetComponent<Transform>();
            _tfCube[i].tag = _listeTag[Random.Range(0, 3)];
        }
        */

        Instanciate(_lVL1);
        Instanciate(_lVL3 );

        
    }
    void Instanciate(Transform LEVEL)
    {
        if (LEVEL == _lVL1)
        {
            for (i = 0; i < 15; i++)
            {
                listeCube[i] = Instantiate(prefabCube, new Vector3(Random.Range(xmin1, xmax1), Random.Range(ymin1, ymax1), Random.Range(zmin1, zmax1)), rotationVide, _lVL1);
                _tfCube[i] = listeCube[i].GetComponent<Transform>();
                _tfCube[i].tag = _listeTag[Random.Range(0, 4)];
            }
        }
        if (LEVEL==_lVL3)
        {
            for (i = 0; i < 15; i++)
            {
                listeCube[i] = Instantiate(prefabCube_LVL3, new Vector3(Random.Range(xmin3, xmax3), Random.Range(ymin3, ymax3), Random.Range(zmin3, zmax3)), rotationVide, _lVL3);
                _tfCube[i] = listeCube[i].GetComponent<Transform>();
                _tfCube[i].tag = _listeTag[Random.Range(0, 4)];
            }

        }


    }
    
  

    

    // Update is called once per frame
    void Update()
    {
      
    }
}
