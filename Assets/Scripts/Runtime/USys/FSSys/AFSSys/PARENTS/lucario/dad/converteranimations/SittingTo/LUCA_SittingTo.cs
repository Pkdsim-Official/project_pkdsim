using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.SittingTo
{
	public class LUCAParentDad_SittingTo : MonoBehaviour 
	{
		private LUCAParentDad_SittingToStartWalking LucarioParentDadsittingToStartWalking;
		private LUCAParentDad_SittingToStanding LucarioParentDadsittingToStanding;
		public void LUCAParentDad_SittingToController()
		{
			LUCAParentDad_SittingToStartWalking();
			LUCAParentDad_SittingToStanding();
		}
		private void LUCAParentDad_SittingToStartWalking()
		{
			LucarioParentDadsittingToStartWalking.LUCAParentDad_SittingToStartWalkingController();
		}
		private void LUCAParentDad_SittingToStanding()
		{
			LucarioParentDadsittingToStanding.LUCAParentDad_SittingToStandingController();
		}
	}
}