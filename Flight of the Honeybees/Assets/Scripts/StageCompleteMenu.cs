using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageCompleteMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextStageButton()
    {
        SceneManager.LoadScene("");
    }

    public void ExitStageButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
