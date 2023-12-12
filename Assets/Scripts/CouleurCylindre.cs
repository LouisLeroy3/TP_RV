using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouleurCylindre : MonoBehaviour
{
    Renderer _rdrCube;
    Transform _tfCube;
    // Start is called before the first frame update
    void Start()
    {
        _tfCube = GetComponent<Transform>();
        _rdrCube = GetComponent<Renderer>();


        switch (_tfCube.tag)
        {
            case "Bleu":
                _rdrCube.material.SetColor("_Color", Color.blue);
                break;
            case "Noir":
                _rdrCube.material.SetColor("_Color", Color.black);
                break;
            case "Blanc":
                _rdrCube.material.SetColor("_Color", Color.white);
                break;
            case "Rouge":
                _rdrCube.material.SetColor("_Color", Color.red);
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
