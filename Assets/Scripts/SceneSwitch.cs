using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Loader()
    {
        Debug.Log("begin");
        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        Debug.Log("begin");
        SceneManager.LoadScene(1);
    }
}
