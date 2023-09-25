using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransitions : MonoBehaviour{

    public void ClickStartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
