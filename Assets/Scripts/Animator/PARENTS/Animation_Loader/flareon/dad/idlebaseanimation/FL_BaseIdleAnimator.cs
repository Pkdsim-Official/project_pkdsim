using project_pkdsim.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation
{
	public class FlareonParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private FLParentDadDad_IdleStanding FLParentDadDad_Idlestanding;
		
		private FLParentDadDad_IdleSitting FLParentDadDad_Idlesitting;

		public void	FLParentDadDad_IdleAnimatorController()
		{
			FLParentDadDad_IdleStandingAnimatorController();
			FLParentDadDad_IdleSittingAnimatorController();
		}
		private void FLParentDadDad_IdleStandingAnimatorController()
		{
			FLParentDadDad_Idlestanding.FLParentDadDad_IdleStandingController();
		}
		private void FLParentDadDad_IdleSittingAnimatorController()
		{
			FLParentDadDad_Idlesitting.FLParentDadDad_IdleSittingController();
		}
	}
}