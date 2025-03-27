using project_pkdsim.Assets.USys.TabChangeManagerSys.I.LoadNewGame;
using project_pkdsim.Assets.USys.TabChangeManagerSys.I.LoadSavedGame;
using project_pkdsim.Assets.USys.TabChangeManagerSys.I.QuitSavedGame;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TabChangeManagerSys.I
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
