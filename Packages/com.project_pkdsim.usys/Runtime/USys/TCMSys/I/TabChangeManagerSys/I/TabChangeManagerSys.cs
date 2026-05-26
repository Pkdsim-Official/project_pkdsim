using project_pkdsim.USys.TabChangeManagerSys.Modules.LoadNewGame;
using project_pkdsim.USys.TabChangeManagerSys.Modules.LoadSavedGame;
using project_pkdsim.USys.TabChangeManagerSys.Modules.QuitSavedGame;
using UnityEngine;

namespace project_pkdsim.USys.TabChangeManagerSys.Modules
{
    public class TCMSysI : MonoBehaviour
    {
        protected LoadNGame loadNewGame;
        protected LoadSGame loadSavedGame;
        protected QuitGame loadQuitGame;

        public void LNG()
        {
            loadNewGame.LoadNewGameI();
        }

        public void LSG()
        {
            loadSavedGame.LoadSavedGameI();
        }

        public void LQG()
        {
            loadQuitGame.LoadQuitGameI();
        }
    }
}
