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
using UnityEngine;


namespace project_pkdsim.USys
{
    public class USys : MonoBehaviour
    {
        private AIRSys AIRSys;

        private HDSys HolidaySys;

        private ITEMSys ItemsSys;
        
        private LOVERSys LoveSys;

        private UPSSys UPSSys;

        private TCMSys TCMSys;

        private TABSys TABSys;

        private SCMSys SCMSys;

        private UnityTeleporterSys UTPSys;

        private MOSys MoneySys;

        private DialSys DialogueSys;

        private AudioSys AudioSys;

        private ADATSys ADATSys;

        private ATSys ATSys;

        private SBSys SBSys;

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
        }
        private void LoadAIRSys()
        {
            AIRSys.AIRoutesSysI();
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
            UPSSys.UPSSysI();
        }
        private void LoadTCMSys()
        {
            TCMSys.TCMSysI();
        }
        private void LoadTABSys()
        {
            TABSys.TABSysI();
        }
        private void LoadSCMSys()
        {
            SCMSys.SCMSysI();
        }
        private void LoadHTPSys() 
        {
            UTPSys.UTPSysI();
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
            ADATSys.ADATSysI();
        }
        private void LoadATSys() 
        {
            ATSys.ATSysI();
        }
        private void LoadSBSys() 
        {
            SBSys.SBSysI();
        }
    }
}