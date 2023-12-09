using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementCubeLvl3 : MonoBehaviour
{
    //public GameObject cube;
    public float initialForce = 1000f;
    private Rigidbody rb;
    private Vector3 force;
    public int rand;

    // Start is called before the first frame update
    void Start()
    {

        force = new Vector3(1, 1, 1);
        rb = GetComponent<Rigidbody>();
        // Ajouter une force initiale au démarrage
        rb.AddForce(force*initialForce);
    

}

// Update is called once per frame
void Update()
    {   
        
        rand=Random.Range(0, 1000);
       // velo=rb.velocity;
        if(rand==1)
        {
            rb.AddForce(force*initialForce);

        }
       // Debug.Log(velo);
       


    }
}
