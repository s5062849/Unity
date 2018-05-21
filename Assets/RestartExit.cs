using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartExit : MonoBehaviour {

	public void Resatrt()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Debug.Log("Has quit");
        Application.Quit();
    }

}
