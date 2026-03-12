using Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.Modules;
using UnityEngine.SceneManagement;

namespace Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys
{
    public class UHTeleporterSys : UHTPSysI
    {
        public void LoadScene(string Street)
        {
            SceneManager.LoadScene(Street);
        }
        public void UHTPSysI()
        {
            LoadScene("Street");
        }
    }
}