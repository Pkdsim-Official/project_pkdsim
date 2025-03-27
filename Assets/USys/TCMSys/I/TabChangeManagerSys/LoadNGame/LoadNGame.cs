using UnityEngine.SceneManagement;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TabChangeManagerSys.I.LoadNewGame
{
    public class LoadNGame : MonoBehaviour
    {
        public void LoadNewGameI()
        {
            SceneManager.LoadScene("Project_pkdsim");
        }
    }
}