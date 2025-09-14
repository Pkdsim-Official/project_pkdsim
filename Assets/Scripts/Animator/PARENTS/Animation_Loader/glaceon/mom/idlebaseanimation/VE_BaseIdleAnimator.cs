using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.idlebaseanimation
{
	public class GlaceonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private GLParentMom_IdleStanding GLParentMom_Idlestanding;
		
		private GLParentMom_IdleSitting GLParentMom_Idlesitting;
		
		public void	GLParentMom_IdleAnimatorController()
		{
			GLParentMom_IdleStandingAnimatorController();
			GLParentMom_IdleSittingAnimatorController();
		}
		private void GLParentMom_IdleStandingAnimatorController()
		{
			GLParentMom_Idlestanding.GLParentMom_IdleStandingController();
		}
		private void GLParentMom_IdleSittingAnimatorController()
		{
			GLParentMom_Idlesitting.GLParentMom_IdleSittingController();
		}
	}
}