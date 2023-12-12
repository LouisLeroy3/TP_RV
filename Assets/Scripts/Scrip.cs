using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrip : MonoBehaviour
{ 
    Transform _tfCube;
    Renderer _rdrCube;
    private float _blueSpeedx=6f;
    private float _blueSpeedy=6f;
    private float _redSpeedx = 6f;
    private float _redSpeedy = 6f;
    private float _blackSpeed=6f;
    private float _whiteSpeed=6f;
    // Start is called before the first frame update

    private double _xmin1 = 41, _xmax1 = 57.5, _ymin1 = 0.5, _ymax1 = 39.5,_zmin= 33.5,_zmax=109.5;
    void Start()
    {
        _tfCube = GetComponent<Transform>();
        _rdrCube = GetComponent<Renderer>();
           

        switch(_tfCube.tag)
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
   
    void movementBlue()
    {
        _tfCube.Translate(new Vector3(_blueSpeedx * Time.deltaTime, _blueSpeedy * Time.deltaTime, 0));
        if (_tfCube.position.y > _ymax1 || _tfCube.position.y < _ymin1)
        {
            _blueSpeedy *= -1f;
        }
        if (_tfCube.position.x > _xmax1|| _tfCube.position.x < _xmin1)
        {
            _blueSpeedx *= -1f;
        }
    }
    void movementBlack()
    {
        _tfCube.Translate(new Vector3(_blackSpeed * Time.deltaTime, 0, 0));
        if(_tfCube.position.x > _xmax1 || _tfCube.position.x < _xmin1)
        {
            _blackSpeed *= -1f;
        }
        
    }
    void movementWhite()
    {
        _tfCube.Translate(new Vector3(0,_whiteSpeed * Time.deltaTime, 0));
        if (_tfCube.position.y > _ymax1 || _tfCube.position.y < _ymin1)
        {
            _whiteSpeed *= -1f;
        }

    }
void movementRed()
    {
        _tfCube.Translate(new Vector3(_redSpeedx,0 , _redSpeedy) * Time.deltaTime);
        if (_tfCube.position.z > _zmax || _tfCube.position.z < _zmin)
        {
            _redSpeedy *= -1f;
        }
        if (_tfCube.position.x > _xmax1 || _tfCube.position.x < _xmin1)
        {
            _redSpeedx *= -1f;
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        switch (_tfCube.tag)
        {
            case "Bleu":
                movementBlue();
                break;
            case "Noir":
                movementBlack();
                break;
            case "Blanc":
                movementWhite();

                break;
            case "Rouge":
                movementRed();

                break;
        }
    }
}
