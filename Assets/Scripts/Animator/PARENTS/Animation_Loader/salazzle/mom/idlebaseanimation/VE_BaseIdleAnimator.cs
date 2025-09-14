using project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Salazzle.Mom.idlebaseanimation
{
	public class SalazzleParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private SParentMom_IdleStanding SParentMom_Idlestanding;
		
		private SParentMom_IdleSitting SParentMom_Idlesitting;
		
		public void	SParentMom_IdleAnimatorController()
		{
			SParentMom_IdleStandingAnimatorController();
			SParentMom_IdleSittingAnimatorController();
		}
		private void SParentMom_IdleStandingAnimatorController()
		{
			SParentMom_Idlestanding.SParentMom_IdleStandingController();
		}
		private void SParentMom_IdleSittingAnimatorController()
		{
			SParentMom_Idlesitting.SParentMom_IdleSittingController();
		}
	}
}