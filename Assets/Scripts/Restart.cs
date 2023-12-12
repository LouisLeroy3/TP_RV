using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    //public Transform _player;
    public Main_Raycast _mainRaycast;
    private Vector3 _posDeBase = new Vector3(0f, 1.0f, 0.0f);
    private Quaternion test = new Quaternion(0, 0, 0, 0);
  
    //private float _nul=0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        // Vérifiez si la collision implique un autre objet avec un composant Collider
        if (other != null)
        {
            // Vérifiez si l'autre objet est un cube
            if (other.CompareTag("Player"))
            {
                _mainRaycast = other.transform.parent.GetComponent<Main_Raycast>();
                other.transform.parent.SetPositionAndRotation(_posDeBase, test);
                //_mainRaycast.elapsedTime = 0.0f;
                //_mainRaycast.formattedTime = null;
                _mainRaycast._menu = true;
                //Debug.Log("Player");

            }


        }
    }
}
