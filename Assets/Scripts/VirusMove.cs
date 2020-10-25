using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMove : MonoBehaviour
{
    private Vector3 start;
    private Vector3 target;
    private Vector3 direction;
    private float viruspeed;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("player");
        start = player.transform.position;
        target = start + new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 0);

        direction = target - transform.position;

        direction.z = 0f;

        direction = direction.normalized;

        viruspeed = Random.Range(0.03f, 0.06f);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Move());
        destroy();
    }

    IEnumerator Move()
    {
        while(true)
        {
            transform.Translate(direction * viruspeed * Time.deltaTime);
            yield return null;
        }
    }

    void destroy()
    {
        if(transform.position.x<-12 || transform.position.x > 12 || transform.position.y > 9 || transform.position.y < -9)
        {
            Destroy(this.gameObject);
        }
    }
}
