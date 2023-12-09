using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;



public class Main_Raycast : MonoBehaviour
{
    public Transform mytransform;
    public GameObject balle;
    public GameObject button;
    public Transform _spawnRes;
    public Transform _spawnTem;
 
    public GameObject prefabCylindre;

    public TMPro.TextMeshProUGUI text;
    public TMPro.TextMeshProUGUI time;


    private Quaternion rotationVide;
    public string[] _listeTagPlayer = new string[4];
    public string[] _listeTag = new string[4];
    public Ray ray;
    Vector3 _spawnResVec;
    Vector3 _spawnTemVec;
    Vector3 _distanceSpawn;
   

    GameObject[] listeCubeRes = new GameObject[4];
    GameObject[] listeCubeTem = new GameObject[4];
    int i = 0;
    int j;
    int layer_mask;
    // Start is called before the first frame update
    void Start()
    {
        _distanceSpawn = new Vector3(0, 3, 0);
        _spawnResVec = new Vector3(_spawnRes.position.x, _spawnRes.position.y, _spawnRes.position.z);
        _spawnTemVec = new Vector3(_spawnTem.position.x, _spawnTem.position.y, _spawnTem.position.z);
        //mytransform = GetComponent<Transform>();
        int layer_mask = LayerMask.GetMask("Default");
        _listeAleatoire();
        SpawnTem();
        

    }

    // Update is called once per frame
    void Update()
    {
        AfficherTime();
        afficherListeAlea();

        RaycastHit hit;
        
        Debug.DrawRay(mytransform.position, mytransform.forward * 100, Color.blue);
        //Physics.Raycast(mytransform.position, -mytransform.up,layer_mask);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(mytransform.position, mytransform.forward, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.layer == layer_mask)
                {
                    Debug.Log("Le raycast touche un objet !");
                    _listeTagPlayer[i] = hit.transform.tag;
                    i = i + 1;
                    Destroy(hit.transform.gameObject);
                    //balle.transform.position=hit.point;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
                Debug.Log("tessttttt");
                //button.transform.gameObject = false;
                SpawnRes();

        }
        

    }
    void AfficherTime()
    {
        
        float elapsedTime = Time.time;
        string formattedTime = FormatTime(elapsedTime);

        time.text = "Time :" + formattedTime;

    }

    string FormatTime(float timeInSeconds)
    {
        // Convert seconds to hours, minutes, and seconds
        int hours = Mathf.FloorToInt(timeInSeconds / 3600);
        int minutes = Mathf.FloorToInt((timeInSeconds % 3600) / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);

        // Format the time as HH:mm:ss
        string formattedTime = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);

        return formattedTime;
    }
    void afficherListeAlea()
    {
        int i = 0;
        if (i < 4)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                text.text = _listeTag[i];
                i++;
            }
        }
        else
        {
            text.text = "";
        }
        

    }

    void _listeAleatoire()
    {
        string[] _tagCree = new string[4];
        _tagCree[0] = "Bleu";
        _tagCree[1] = "Noir";
        _tagCree[2] = "Rouge";
        _tagCree[3] = "Blanc";
        for (int k = 0; k < 4; k++)
        {
            _listeTag[k] = _tagCree[Random.Range(0, 4)];
            Debug.Log(_listeTag[k]);
        }
    }
    public void SpawnRes()
    {   if (_spawnRes.childCount < 4)
        {
            for (j = 0; j < 4; j++)
            {
                Transform _tfCylindre;
                listeCubeRes[j] = Instantiate(prefabCylindre, _spawnResVec+new Vector3(0,2*j,0),rotationVide, _spawnRes);
                listeCubeRes[j].tag = _listeTagPlayer[j];
                _tfCylindre = listeCubeRes[j].GetComponent<Transform>();
                _tfCylindre.tag = _listeTagPlayer[j];
               
            }
        }

    }
    public void SpawnTem()
    {
        if (_spawnRes.childCount < 4)
        {
            for (j = 0; j < 4; j++)
            {
                Transform _tfCylindre;
                listeCubeTem[j] = Instantiate(prefabCylindre,_spawnTemVec + new Vector3(0, 3 * j, 0), rotationVide, _spawnTem);
                listeCubeTem[j].tag = _listeTag[j];
                _tfCylindre = listeCubeTem[j].GetComponent<Transform>();
                _tfCylindre.tag = _listeTag[j];

            }
        }

    }
}

