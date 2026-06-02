using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo
{
	public class LUCAParentDad_SittingTo : MonoBehaviour 
	{
		private LUCAParentDad_SittingToStartWalking LucariosittingToStartWalking;
		private LUCAParentDad_SittingToStanding LucariosittingToStanding;
		public void LUCAParentDad_SittingToController()
		{
			LUCAParentDad_SittingToStartWalking();
			LUCAParentDad_SittingToStanding();
		}
		private void LUCAParentDad_SittingToStartWalking()
		{
			LucariosittingToStartWalking.LUCAParentDad_SittingToStartWalkingController();
		}
		private void LUCAParentDad_SittingToStanding()
		{
			LucariosittingToStanding.LUCAParentDad_SittingToStandingController();
		}
	}
}