using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private Enemy[] _enemies;
    private int _nextLevelIndex;

    private void OnEnable()
    {
        
        _enemies = FindObjectsOfType<Enemy>();    
    }

    void Update()
    {
        foreach (Enemy enemy in _enemies)
        {
            if (enemy != null) 
                return;
        }

        Debug.Log(SceneManager.GetActiveScene().name.Substring(5));
    
        _nextLevelIndex = int.Parse(SceneManager.GetActiveScene().name.Substring(5));
        _nextLevelIndex++;
        string nextLevelName = "Level" + _nextLevelIndex;
        SceneManager.LoadScene(nextLevelName);
    }
}
