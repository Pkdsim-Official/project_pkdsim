using UnityEngine;
using project_pkdsim.Assets.USys.TabManagerSys;

namespace project_pkdsim.Assets.USys.TabManagerSys
{
    public class TABSys : MonoBehaviour
    {
        private TABSysI TabSys;
        public void TABSysI()
        {
            TabSys.TABSys_PkPhoneAppsI();
        }
    }
}