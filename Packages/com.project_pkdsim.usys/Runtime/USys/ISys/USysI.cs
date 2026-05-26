using project_pkdsim.USys.AIRoutesSys;
using project_pkdsim.USys.AnimatedTexturesSys;
using project_pkdsim.USys.AntiDateAndTimeSys;
using project_pkdsim.USys.AUDIOSys;
using project_pkdsim.USys.DialogueSys;
using project_pkdsim.USys.HolidaySys;
using project_pkdsim.USys.LoveSys;
using project_pkdsim.USys.MoneySys;
using project_pkdsim.USys.SceneManagerSys;
using project_pkdsim.USys.SkyboxSys;
using project_pkdsim.USys.TabChangeManagerSys;
using project_pkdsim.USys.UnityPlayerSaveSys;
using project_pkdsim.USys.UItemsSystemSys;
using project_pkdsim.USys.UTeleporterSys;
using project_pkdsim.USys.TabManagerSys;
using project_pkdsim.USys.FailSafeSys;
using UnityEngine;


namespace project_pkdsim.USys.ImportSys
{
    public class USysI : MonoBehaviour
    {
        private AIRSys AIRoutesSys;

        private HDSys HolidaySys;

        private ITEMSys ItemsSys;

        private LOVERSys LoveSys;

        private UPSSys UnityPlayerSaveSys;

        private TCMSys TabChangeManagerSys;

        private TABSys TabSys;

        private SCMSys SceneManagerSys;

        private UTSys UnityTeleporterSys;

        private MOSys MoneySys;

        private DSys DialogueSys;

        private AudioSys AudioSys;

        private ADATSys AntiDateAndTimeSys;

        private ATSys AnimatedTexturesSys;

        private SBSys SkyBoxSys;

        private FSSys FailSafeSys;

        private void LoadUSys()
        {
            LoadAIRSys();
            LoadHDSys();
            LoadITEMSSys();
            LoadLOVESys();
            LoadUPSSys();
            LoadTCMSys();
            LoadTABSys();
            LoadSCMSys();
            LoadMoneySys();
            LoadHTPSys();
            LoadDialogueSys();
            LoadAudioSys();
            LoadADATSys();
            LoadATSys();
            LoadSBSys();
            LoadFSSys();
        }
        private void LoadAIRSys()
        {
            AIRoutesSys.AIRoutesSysI();
        }
        private void LoadHDSys()
        {
            HolidaySys.HDSysI();
        }
        private void LoadITEMSSys()
        {
            ItemsSys.ITEMSSysI();
        }
        private void LoadLOVESys()
        {
            LoveSys.LoveSysI();
        }
        private void LoadUPSSys()
        {
            UnityPlayerSaveSys.UPSSysI();
        }
        private void LoadTCMSys()
        {
            TabChangeManagerSys.TCMSysI();
        }
        private void LoadTABSys()
        {
            TabSys.TABSysI();
        }
        private void LoadSCMSys()
        {
            SceneManagerSys.SCMSysI();
        }
        private void LoadHTPSys()
        {
            UnityTeleporterSys.UTPSysI();
        }
        private void LoadMoneySys()
        {
            MoneySys.MoneySysI();
        }
        private void LoadDialogueSys()
        {
            DialogueSys.DialogueSysI();
        }
        private void LoadAudioSys()
        {
            AudioSys.AudioSysI();
        }
        private void LoadADATSys()
        {
            AntiDateAndTimeSys.ADATSysI();
        }
        private void LoadATSys()
        {
            AnimatedTexturesSys.ATSysI();
        }
        private void LoadSBSys()
        {
            SkyBoxSys.SBSysI();
        }
        private void LoadFSSys()
        {
            FailSafeSys.FSSysI();
        }
    }
}