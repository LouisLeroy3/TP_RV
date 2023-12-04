using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Raycast : MonoBehaviour
{
    public Transform mytransform;
    public GameObject balle;
    public Ray ray;
    int layer_mask;
    // Start is called before the first frame update
    void Start()
    {
        //mytransform = GetComponent<Transform>();
        int layer_mask = LayerMask.GetMask("Raycast");
    }

    // Update is called once per frame
    void Update()
    {



        RaycastHit hit;
        Debug.DrawRay(mytransform.position, mytransform.forward * 100, Color.blue);
        //Physics.Raycast(mytransform.position, -mytransform.up,layer_mask);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(mytransform.position, mytransform.forward, out hit, Mathf.Infinity))
            {
                Debug.Log("Le raycast touche un objet !");
                //Destroy(hit.transform.gameObject);
                balle.transform.position=hit.point;
            }
        }






        /*
        // Déclarer un rayon qui part de la position de cet objet vers l'avant (axe Z négatif)
        Ray ray = new Ray(transform.position, -transform.forward);

        // Déclarer un RaycastHit pour stocker les informations de la collision
        RaycastHit hit;

        // Longueur maximale du rayon
        float raycastDistance = 10f;

        // Effectuer le Raycast
        if (Physics.Raycast(ray, out hit, raycastDistance))
        {
            // Objet touché
            GameObject objetTouche = hit.collider.gameObject;

            // Position du point de contact
            Vector3 pointDeContact = hit.point;

            // Normale de la surface touchée
            Vector3 normale = hit.normal;

            // Faire quelque chose avec les informations de collision
            Debug.Log("Objet touché : " + objetTouche.name);
            Debug.Log("Point de contact : " + pointDeContact);
            Debug.Log("Normale : " + normale);
        */
        }
    }

