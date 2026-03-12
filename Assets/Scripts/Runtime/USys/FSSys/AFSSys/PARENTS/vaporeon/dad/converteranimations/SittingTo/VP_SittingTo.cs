using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.SittingTo.SittingToStanding;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.converteranimations.SittingTo
{
	public class VPParentDad_SittingTo : MonoBehaviour 
	{
		private VPParentDad_SittingToStanding VaporeonParentDad_sittingtostanding;
		private VPParentDad_SittingToStartWalking VaporeonParentDad_sittingtostartwalking;
		public void VPParentDad_SittingToController()
		{
			Load_VPParentDad_SittingToRun();
			Load_VPParentDad_SittingToWalk();
		}
		private void Load_VPParentDad_SittingToRun()
		{
			VaporeonParentDad_sittingtostanding.VPParentDad_SittingToStandingController();
		}
		private void Load_VPParentDad_SittingToWalk()
		{
			VaporeonParentDad_sittingtostartwalking.VPParentDad_SittingToStartWalkingController();
		}
	}
}