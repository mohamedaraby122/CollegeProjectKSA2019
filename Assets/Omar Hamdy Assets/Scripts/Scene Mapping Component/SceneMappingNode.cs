using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMappingNode : MonoBehaviour
{
    public SceneName sceneName;
    public void ChangeScene()
    {
        SceneMappingManager.Instance.changeScene(sceneName);
    }
    public void setSceneToChangeTo()
    {
        SceneMappingManager.Instance.sceneName = sceneName;
    }
    public void setSceneToChangeTo(string sceneName)
    {
        SceneMappingManager.Instance.sceneNameStr = sceneName;
    }


}
