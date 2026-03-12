using Project_Pkdsim.USys.TabChangeManagerSys.Modules.LoadNewGame;
using Project_Pkdsim.USys.TabChangeManagerSys.Modules.LoadSavedGame;
using Project_Pkdsim.USys.TabChangeManagerSys.Modules.QuitSavedGame;
using UnityEngine;

namespace Project_Pkdsim.USys.TabChangeManagerSys.Modules
{
    public class UntiyTabChangerManagerSysI : MonoBehaviour
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
