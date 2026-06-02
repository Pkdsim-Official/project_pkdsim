using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.idlebaseanimation
{
	public class TsareenaParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private TParentMom_IdleStanding Tidlestanding;
		
		private TParentMom_IdleSitting Tidlesitting;
		
		public void	TParentMom_IdleAnimatorController()
		{
			TParentMom_IdleStandingAnimatorController();
			TParentMom_IdleSittingAnimatorController();
		}
		private void TParentMom_IdleStandingAnimatorController()
		{
			Tidlestanding.TParentMom_IdleStandingController();
		}
		private void TParentMom_IdleSittingAnimatorController()
		{
			Tidlesitting.TParentMom_IdleSittingController();
		}
	}
}