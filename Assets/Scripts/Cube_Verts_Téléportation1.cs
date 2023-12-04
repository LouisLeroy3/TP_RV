using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Verts_Téléportation : MonoBehaviour
{
    private Transform myTransform;
    public Transform Cube_Vert1_tf;
    public Transform Cube_Vert2_tf;
    private Collider myCollider;
    public Vector3 _posDeBase = new Vector3(3.0f, 0.0f, 0.0f);
    private Quaternion _rotaBase = new Quaternion(0, 0, 0, 0);



    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        myCollider = GetComponent<Collider>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        // Vérifiez si la collision implique un autre objet avec un composant Collider
        if (other != null)
        {
            // Vérifiez si l'autre objet est un cube
            if (other.CompareTag("TP")&& other.name=="Cube_Vert1")
            {
                myTransform.SetPositionAndRotation(Cube_Vert2_tf.position+_posDeBase, _rotaBase);
                Debug.Log("VERT");

            }
            if (other.CompareTag("TP") && other.name == "Cube_Vert2")
            {
                myTransform.SetPositionAndRotation(Cube_Vert1_tf.position+_posDeBase, _rotaBase);
                Debug.Log("VERT");

            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        OnTriggerEnter(myCollider);

        
    }
}
