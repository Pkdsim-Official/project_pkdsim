using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo
{
	public class LEParentDad_SittingTo : MonoBehaviour 
	{
		
		private LEParentDad_SittingToStanding LeafeonParentDad_sittingtostanding;
		private LEParentDad_SittingToStartWalking LeafeonParentDad_sittingtostartwalking;
		public void LEParentDad_SittingToController()
		{
			Load_LEParentDad_SittingToWalking();
			Load_LEParentDad_SittingToStanding();
		}
		private void Load_LEParentDad_SittingToStanding()
		{
			LeafeonParentDad_sittingtostanding.LEParentDad_SittingToStandingController();
		}
		private void Load_LEParentDad_SittingToWalking()
		{
			LeafeonParentDad_sittingtostartwalking.LEParentDad_SittingToStartWalkingController();
		}
	}
}