using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeSceneController : MonoBehaviour
{
    
    public void LoadDifferences()
    {
        GameFlowEvents.LoadScene.Invoke("Differences");
    }
}
