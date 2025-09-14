using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation
{
	public class BraixenParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private BRParentDad_IdleStanding BRParentDad_idlestanding;
		
		private BRParentDad_IdleSitting BRParentDad_idlesitting;
		
		public void	BRParentDad_IdleAnimatorController()
		{
			BRParentDad_IdleStandingAnimatorController();
			BRParentDad_IdleSittingAnimatorController();
		}
		private void BRParentDad_IdleStandingAnimatorController()
		{
			BRParentDad_idlestanding.BRParentDad_IdleStandingController();
		}
		private void BRParentDad_IdleSittingAnimatorController()
		{
			BRParentDad_idlesitting.BRParentDad_IdleSittingController();
		}
	}
}