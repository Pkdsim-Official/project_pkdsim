using project_pkdsim.USys.DSys;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys;
using project_pkdsim.USys.SBSys;
using project_pkdsim.USys.UTPSys;
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

        private DLSys DialSys;

        private AUSys AudioSys;

        private ADATSys AntiDateAndTimeSys;

        private ATSys AnimatedTexturesSys;

        private SBOSys SkyBoxSys;

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