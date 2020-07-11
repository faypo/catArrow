using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrawGemerator : MonoBehaviour
{
    public GameObject arrowPrefeb;
    float span = 1.0f;
    float delta = 0;


    private void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefeb) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);

        }

    }
}
