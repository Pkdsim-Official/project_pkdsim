using UnityEngine.SceneManagement;
using UnityEngine;

namespace Project_Pkdsim.USys.TabChangeManagerSys.Modules.LoadNewGame
{
    public class LoadNGame : MonoBehaviour
    {
        public void LoadNewGameI()
        {
            SceneManager.LoadScene("Project_pkdsim");
        }
    }
}