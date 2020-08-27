using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BG : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        float wordHeight = Camera.main.orthographicSize * 3f;
        float wordWidth = wordHeight * Screen.width / Screen.height;

        transform.localScale = new Vector3(wordWidth, wordHeight, 0);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
