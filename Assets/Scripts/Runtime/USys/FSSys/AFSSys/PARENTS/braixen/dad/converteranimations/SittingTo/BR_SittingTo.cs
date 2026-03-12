using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Dad.converteranimations.SittingTo
{
	public class BRParentDad_SittingTo : MonoBehaviour 
	{
		private BRParentDad_SittingToStartWalking BraixenParentDadSittingToStartWalking;
		private BRParentDad_SittingToStanding BraixenParentDadSittingToStanding;
		public void BRParentDad_SittingToController()
		{
			BRParentDad_SittingToStartWalking();
			BRParentDad_SittingToStanding();
		}
		private void BRParentDad_SittingToStartWalking()
		{
			BraixenParentDadSittingToStartWalking.BRParentDad_SittingToStartWalkingController();
		}
		private void BRParentDad_SittingToStanding()
		{
			BraixenParentDadSittingToStanding.BRParentDad_SittingToStandingController();
		}

	}
}