using project_pkdsim.USys.SceneManagerSys.Modules;
using UnityEngine.SceneManagement;

namespace project_pkdsim.USys.SceneManagerSys
{
    public class UnitySceneManagerSys : UnitySceneManagerSysI
    {
        public void LoadScene(string project_pkdsim, string sceneName)
        {
            SceneManager.LoadScene(project_pkdsim);
        }
        public void SCMSys_I()
        {
            LoadScene("project_pkdsim", "MainMenuScene");
        }
    }
}