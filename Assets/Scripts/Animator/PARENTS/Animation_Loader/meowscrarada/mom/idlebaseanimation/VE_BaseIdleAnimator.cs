using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.Mom.idlebaseanimation
{
	public class MeowscaradaParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private MEOWParentMom_IdleStanding MEOWParentMom_Idlestanding;
		
		private MEOWParentMom_IdleSitting MEOWParentMom_Idlesitting;
		
		public void	MEOWParentMom_IdleAnimatorController()
		{
			MEOWParentMom_IdleStandingAnimatorController();
			MEOWParentMom_IdleSittingAnimatorController();
		}
		private void MEOWParentMom_IdleStandingAnimatorController()
		{
			MEOWParentMom_Idlestanding.MEOWParentMom_IdleStandingController();
		}
		private void MEOWParentMom_IdleSittingAnimatorController()
		{
			MEOWParentMom_Idlesitting.MEOWParentMom_IdleSittingController();
		}
	}
}