using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowController : MonoBehaviour
{
    GameObject player;

    private void gc(bool position, GameObject obj)
    {
        if (position)
        {
            Destroy(obj);
        }
    }

    private void Start()
    {
        this.player = GameObject.Find("player");
    }

    private void Update()
    {
        
        transform.Translate(0, -0.1f, 0);

        this.gc(transform.position.y<-5.0f, gameObject);

        Vector2 v1 = transform.position;
        Vector2 v2 = this.player.transform.position;
        Vector2 dir = v1 - v2;

        float Dir = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (Dir < r1 + r2)
        {
            GameObject director = GameObject.Find("gameDirector");
            director.GetComponent<gameDirector>().DecreaseHP();

            Destroy(gameObject);
        }


    }
}
