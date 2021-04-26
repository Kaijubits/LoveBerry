using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        GameFlowEvents.LoadScene.Invoke("Configuration");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
