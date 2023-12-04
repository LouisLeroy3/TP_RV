using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Raycast : MonoBehaviour
{
    public Transform mytransform;
    public Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        RaycastHit hit;
        Debug.DrawRay(mytransform.position, transform.forward * 10, Color.blue);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(mytransform.position, transform.forward, out hit, 10))
            {
                Debug.Log("Le raycast touche un objet !");
                Destroy(hit.transform.gameObject);
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

