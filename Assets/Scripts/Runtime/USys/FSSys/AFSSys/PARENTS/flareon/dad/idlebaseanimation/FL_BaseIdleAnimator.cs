using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.idlebaseanimation
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