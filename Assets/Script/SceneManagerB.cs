using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerB : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToSceneA(){
        SceneManager.LoadScene("TestA");
    }
}
