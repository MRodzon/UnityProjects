using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceScript : MonoBehaviour {

    public GameObject gameOverPanel, objectiveAchievedPanel;

    public void OnGameOver ()
    {
        gameOverPanel.SetActive(true);
        GameObject playerComponent = GameObject.FindGameObjectWithTag("Player");
        Destroy(playerComponent);
        
    }

    public void OnObjectiveAchieved ()
    {
        objectiveAchievedPanel.SetActive(true);
        GameObject playerComponent = GameObject.FindGameObjectWithTag("Player");
        Destroy(playerComponent);
    }

	public void OnRestart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnNextLevel ()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
