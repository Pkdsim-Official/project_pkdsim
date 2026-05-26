using project_pkdsim.USys.UTPSys.UHousesTeleporterSys.Modules;
using UnityEngine.SceneManagement;

namespace project_pkdsim.USys.UTPSys.UHousesTeleporterSys
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