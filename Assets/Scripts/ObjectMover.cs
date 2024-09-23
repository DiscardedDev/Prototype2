using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{

    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if(this.gameObject.tag == "food" && transform.position.z > 30){
            Destroy(this.gameObject);
        }

        else if(this.gameObject.tag == "animal" && transform.position.z < -20){
            Destroy(this.gameObject);
        }

    }
}
