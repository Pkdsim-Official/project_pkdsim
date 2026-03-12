using UnityEngine.SceneManagement;
using UnityEngine;

namespace Project_Pkdsim.USys.TabChangeManagerSys.Modules.LoadSavedGame
{
    public class LoadSGame : MonoBehaviour
    {
        public void LoadSavedGameI()
        {
            // Add logic for loading a saved game if applicable
            SceneManager.LoadScene("SavedGameScene"); // Replace with your saved game scene name
        }
    }
}