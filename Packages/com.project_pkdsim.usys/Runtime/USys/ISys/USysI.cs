using project_pkdsim.USys.AUSys;
using project_pkdsim.USys.ADSys;
using project_pkdsim.USys.FSSys;
using project_pkdsim.USys.SCMSys;
using project_pkdsim.USys.SBSys;
using project_pkdsim.USys.LOSys;
using project_pkdsim.USys.ITSys;
using project_pkdsim.USys.TABSys;
using project_pkdsim.USys.UPSSys;
using project_pkdsim.USys.UTPSys;
using project_pkdsim.USys.AISys;
using project_pkdsim.USys.HDSys;
using project_pkdsim.USys.MOSys;
using project_pkdsim.USys.DSys;
using project_pkdsim.USys.TCMSys;
using project_pkdsim.USys.ATSys;
using UnityEngine;

namespace project_pkdsim.USys.ImportSys
{
    public class USysI : MonoBehaviour
    {
        private AIISys aiiSys;

        private HDSSys hdsSys;

        private ITSSys itSys;

        private LOSSys loSys;

        private UPSaveSys upsSys;

        private TabCMSys tcmsSys;

        private TABSSys tabsSys;

        private SceneSys sceneManagerSys;

        private UTSys unityTeleporterSys;

        private MOSSys moneySys;

        private DLSys dialogueSys;

        private AUISys audioSys;

        private ADISys antiDateAndTimeSys;

        private AnimatedTSys animatedTexturesSys;

        private SBOSys skyBoxSys;

        private FSys failSafeSys;

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
            LoadMOSys();
            LoadHTPSys();
            LoadDSys();
            LoadAUSys();
            LoadADSys();
            LoadATSys();
            LoadSBSys();
            LoadFSSys();
        }
        private void LoadAIRSys()
        {
            aiiSys.AIISysI();
        }
        private void LoadHDSys()
        {
            hdsSys.HDSysI();
        }
        private void LoadITEMSSys()
        {
            itSys.ITSysI();
        }
        private void LoadLOVESys()
        {
            loSys.LOSysI();
        }
        private void LoadUPSSys()
        {
            upsSys.UPSSysI();
        }
        private void LoadTCMSys()
        {
            tcmsSys.TCMSysI();
        }
        private void LoadTABSys()
        {
            tabsSys.TABSSysI();
        }
        private void LoadSCMSys()
        {
            sceneManagerSys.SCMSysI();
        }
        private void LoadHTPSys()
        {
            unityTeleporterSys.UTPSysI();
        }
        private void LoadMOSys()
        {
            moneySys.MOSysI();
        }
        private void LoadDSys()
        {
            dialogueSys.DSysI();
        }
        private void LoadAUSys()
        {
            audioSys.AUSysI();
        }
        private void LoadADSys()
        {
            antiDateAndTimeSys.ADSysI();
        }
        private void LoadATSys()
        {
            animatedTexturesSys.ATSysI();
        }
        private void LoadSBSys()
        {
            skyBoxSys.SBSysI();
        }
        private void LoadFSSys()
        {
            failSafeSys.FSSysI();
        }
    }
}