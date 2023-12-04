using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public float vitesseDeplacement = 10.0f;
    public float vitesseRotation = 50f;
    private Transform myTransform;
    private Vector3 _posDeBase= new Vector3(10.0f,7.0f,10.0f);
    private Quaternion test = new Quaternion(0,0,0,0);
    public float sensivity = 4.0f;

    private float _rotationX=0.0f;
    private float _rotationY=0.0f;
    // Start is called before the first frame update
    void Start()

    {
        myTransform = GetComponent<Transform>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        {
            // Obtenez les entrées du clavier pour les touches Z, Q, S et D
            float deplacementHorizontal = Input.GetAxis("Horizontal");
            float deplacementVertical = Input.GetAxis("Vertical");

            // Calculez le vecteur de déplacement
            Vector3 deplacement = new Vector3(deplacementHorizontal, 0f, deplacementVertical) * vitesseDeplacement * Time.deltaTime;



            // Appliquez le déplacement en utilisant le Transform
            myTransform.Translate(deplacement);

            // Appliquez la rotation en utilisant le Transform
            //myTransform.rotation *= rotationQuat;

            //test ci dessous
            _rotationX += Input.GetAxis("Mouse Y")*sensivity;
            _rotationY += Input.GetAxis("Mouse X") * sensivity;
            //_rotationY = Mathf.Clamp(_rotationY, -120, 120);
            myTransform.GetComponent<Transform>().localRotation = Quaternion.Euler(-_rotationX, _rotationY, 0);




        }


        //si il y a une chute
        if (myTransform.position.y<0)
        {
            myTransform.SetPositionAndRotation(_posDeBase,test);

        }
    }




}
