using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation
{
	public class TsareenaParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private TParentMom_IdleStanding TParentMom_Idlestanding;
		
		private TParentMom_IdleSitting TParentMom_Idlesitting;
		
		public void	TParentMom_IdleAnimatorController()
		{
			TParentMom_IdleStandingAnimatorController();
			TParentMom_IdleSittingAnimatorController();
		}
		private void TParentMom_IdleStandingAnimatorController()
		{
			TParentMom_Idlestanding.TParentMom_IdleStandingController();
		}
		private void TParentMom_IdleSittingAnimatorController()
		{
			TParentMom_Idlesitting.TParentMom_IdleSittingController();
		}
	}
}