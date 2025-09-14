using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.idlebaseanimation
{
	public class LopunnyParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private LOParentMom_IdleStanding LOParentMom_Idlestanding;
		
		private LOParentMom_IdleSitting LOParentMom_Idlesitting;
		
		public void	LOParentMom_IdleAnimatorController()
		{
			LOParentMom_IdleStandingAnimatorController();
			LOParentMom_IdleSittingAnimatorController();
		}
		private void LOParentMom_IdleStandingAnimatorController()
		{
			LOParentMom_Idlestanding.LOParentMom_IdleStandingController();
		}
		private void LOParentMom_IdleSittingAnimatorController()
		{
			LOParentMom_Idlesitting.LOParentMom_IdleSittingController();
		}
	}
}