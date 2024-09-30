using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animals;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 5.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)){
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal(){
        int index = Random.Range(0, animals.Length);
        Instantiate(animals[index], new(Mathf.Floor(Random.Range(-12,12)),0,30), animals[index].transform.rotation);
        Debug.Log($"Spawning {animals[index].name}");
    }
}
