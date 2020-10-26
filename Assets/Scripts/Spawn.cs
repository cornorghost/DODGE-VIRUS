using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] viruses;

    private int[] side = { 1, -1 };

    private int[] direction= { 0, 1 };

    private float minTime = 1.0f;

    private float maxTime = 1.1f;

    private float upTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(init());
    }

    IEnumerator init()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            spawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        upTime -= Time.deltaTime;
        if(upTime<0 && minTime>0.3)
        {
            minTime -= 0.1f;
            maxTime -= 0.1f;
            upTime = 5.0f;
        }
    }

    void spawn()
    {
        GameObject virus = getObject();
        Instantiate(virus, getPosition(), Quaternion.identity);
    }

    Vector3 getPosition()
    {
        int direction_index = Random.Range(0, direction.Length);
        int side_index = Random.Range(0, side.Length);
        float randX, randY;
        switch (direction[direction_index])
            {
            case 0:
                randX = Random.Range(side[side_index] * 9.3f, side[side_index] * 11.8f);
                randY = Random.Range(-8.0f, 8.0f);
                return new Vector3(randX, randY, 0);
            case 1:
                randX = Random.Range(-12.0f, 12.0f);
                randY = Random.Range(side[side_index] *5.5f, side[side_index] * 8.5f);
                return new Vector3(randX, randY, 0);
            default:
                return new Vector3(-10, -6, 0);
        }
    }

    GameObject getObject()
    {
        int object_index = Random.Range(0, viruses.Length);
        GameObject virus = viruses[object_index];
        GameObject clone = virus;
        //clone.transform.localScale = Vector3.one * Random.Range(0.5f, 1.0f);
        return clone;
    }
}
