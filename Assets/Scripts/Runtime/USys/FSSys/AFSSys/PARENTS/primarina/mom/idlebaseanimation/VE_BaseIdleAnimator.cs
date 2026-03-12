using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.idlebaseanimation
{
	public class PrimarinaParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private PRParentMom_IdleStanding PRParentMom_Idlestanding;
		
		private PRParentMom_IdleSitting PRParentMom_Idlesitting;
		
		public void	PRParentMom_IdleAnimatorController()
		{
			PRParentMom_IdleStandingAnimatorController();
			PRParentMom_IdleSittingAnimatorController();
		}
		private void PRParentMom_IdleStandingAnimatorController()
		{
			PRParentMom_Idlestanding.PRParentMom_IdleStandingController();
		}
		private void PRParentMom_IdleSittingAnimatorController()
		{
			PRParentMom_Idlesitting.PRParentMom_IdleSittingController();
		}
	}
}