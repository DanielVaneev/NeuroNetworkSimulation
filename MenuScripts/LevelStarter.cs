using UnityEngine;
using UnityEngine.SceneManagement;

namespace MenuScripts
{
    public class LevelStarter : MonoBehaviour
    {
        public int sceneNumber;
        public void StartLevel()
        {
            SceneManager.LoadScene(sceneNumber);
        }
 
    }
}
