using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation
{
	public class SylveonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private SYLParentMom_IdleStanding SYLParentMom_Idlestanding;
		
		private SYLParentMom_IdleSitting SYLParentMom_Idlesitting;
		
		public void	SYLParentMom_IdleAnimatorController()
		{
			SYLParentMom_IdleStandingAnimatorController();
			SYLParentMom_IdleSittingAnimatorController();
		}
		private void SYLParentMom_IdleStandingAnimatorController()
		{
			SYLParentMom_Idlestanding.SYLParentMom_IdleStandingController();
		}
		private void SYLParentMom_IdleSittingAnimatorController()
		{
			SYLParentMom_Idlesitting.SYLParentMom_IdleSittingController();
		}
	}
}