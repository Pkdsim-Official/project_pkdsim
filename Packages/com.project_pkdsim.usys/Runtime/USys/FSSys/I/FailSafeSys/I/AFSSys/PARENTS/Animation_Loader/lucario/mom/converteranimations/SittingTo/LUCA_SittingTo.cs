using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.SittingTo
{
	public class LUCAParentMom_SittingTo : MonoBehaviour 
	{
		private LUCAParentMom_SittingToStartWalking LucariosittingToStartWalking;
		private LUCAParentMom_SittingToStanding LucariosittingToStanding;
		public void LUCAParentMom_SittingToController()
		{
			LUCAParentMom_SittingToStartWalking();
			LUCAParentMom_SittingToStanding();
		}
		private void LUCAParentMom_SittingToStartWalking()
		{
			LucariosittingToStartWalking.LUCAParentMom_SittingToStartWalkingController();
		}
		private void LUCAParentMom_SittingToStanding()
		{
			LucariosittingToStanding.LUCAParentMom_SittingToStandingController();
		}
	}
}