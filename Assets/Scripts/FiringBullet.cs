using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringBullet : MonoBehaviour
{
    public GameObject _bullet;
    public Transform _spawnPoint;
    public float _fireSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireBullet();
           
        }


    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LVL1"))
        {
            Destroy(_bullet);
            Destroy(other.gameObject);
            Debug.Log("TESSSST");// à revoir
        }



    }

    public void FireBullet()
    {
        GameObject _spawnBullet=Instantiate(_bullet);
        _spawnBullet.transform.position= _spawnPoint.position;
        _spawnBullet.GetComponent<Rigidbody>().velocity = _spawnPoint.forward * _fireSpeed;
        Destroy(_spawnBullet, 5);

    }
}
