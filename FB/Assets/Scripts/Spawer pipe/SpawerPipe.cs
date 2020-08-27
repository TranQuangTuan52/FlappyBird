using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawerPipe : MonoBehaviour
{
    [SerializeField]
    public GameObject piperHolder;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
        
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(3);
        Vector3 temp = piperHolder.transform.position;
        temp.y = Random.Range(-2.5f, 0.75f);
        Instantiate(piperHolder, temp, Quaternion.identity);
        StartCoroutine(Spawner());


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
