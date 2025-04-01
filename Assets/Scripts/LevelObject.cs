using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelObject : MonoBehaviour
{
    public string nextLevel;

    public void MovetonextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
    
}
