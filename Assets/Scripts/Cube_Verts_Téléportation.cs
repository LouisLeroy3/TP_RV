using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Téléportation : MonoBehaviour
{
    public Transform _player;
    public Transform _spawnPoint1;
    public Transform _spawnPoint2;
    public Transform _spawnPoint3;
    private Quaternion _rotaPoint1 = new Quaternion(0, -90, 0, 0);
    private Quaternion _rotaPoint2 = new Quaternion(0, 0, 0, 0);
    private Quaternion _rotaPoint3 = new Quaternion(0, 0, 0, 0);
    private Main_Raycast _main;


  

   




    // Start is called before the first frame update
    void Start()
    {
        _main = GetComponent<Main_Raycast>();

       
    }
    
    void OnTriggerEnter(Collider other)
    {
        // Vérifiez si la collision implique un autre objet avec un composant Collider
        if (other != null)
        {
            // Vérifiez si l'autre objet est un cube
            if (other.CompareTag("LVL1"))
            {
                _player.SetPositionAndRotation(_spawnPoint1.position, _rotaPoint1);
                _main._menu = false;
                

            }
            if (other.CompareTag("LVL2"))
            {
                _player.SetPositionAndRotation(_spawnPoint2.position, _rotaPoint2);
                _main._menu = false;

               


            }
            if (other.CompareTag("LVL3"))
            {
                _player.SetPositionAndRotation(_spawnPoint3.position, _rotaPoint3);
                _main._menu = false;

              

            }



        }
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
