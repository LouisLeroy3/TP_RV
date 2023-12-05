using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrip : MonoBehaviour
{
    Transform _tfCube;
    Renderer _rdrCube;
    private float _blueSpeedx=6f;
    private float _blueSpeedy=6f;
    private float _blackSpeed=6f;
    private float _whiteSpeed=6f;
    // Start is called before the first frame update
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
            case "Marron":
                _rdrCube.material.SetColor("_Color", Color.gray);
                break;
        }

    }
   
    void movementBlue()
    {
        _tfCube.Translate(new Vector3(_blueSpeedx * Time.deltaTime, _blueSpeedy * Time.deltaTime, 0));
        if (_tfCube.position.y > 19.5 || _tfCube.position.y < 0.5)
        {
            _blueSpeedy *= -1f;
        }
        if (_tfCube.position.x > 57 || _tfCube.position.x < 39)
        {
            _blueSpeedx *= -1f;
        }
    }
    void movementBlack()
    {
        _tfCube.Translate(new Vector3(_blackSpeed * Time.deltaTime, 0, 0));
        if(_tfCube.position.x > 57 || _tfCube.position.x < 39)
        {
            _blackSpeed *= -1f;
        }
        
    }
    void movementWhite()
    {
        _tfCube.Translate(new Vector3(0,_whiteSpeed * Time.deltaTime, 0));
        if (_tfCube.position.y > 19.5 || _tfCube.position.y < 0.5)
        {
            _whiteSpeed *= -1f;
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
            case "Marron":
                movementWhite();

                break;
        }
    }
}
