using UnityEngine.SceneManagement;
using UnityEngine;

namespace project_pkdsim.USys.TabChangeManagerSys.Modules.LoadNewGame
{
    public class LoadNGame : MonoBehaviour
    {
        public void LoadNewGameI()
        {
            SceneManager.LoadScene("Project_pkdsim");
        }
    }
}