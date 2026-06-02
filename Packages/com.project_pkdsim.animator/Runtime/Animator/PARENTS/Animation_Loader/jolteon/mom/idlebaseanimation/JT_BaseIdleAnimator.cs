using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation
{
	public class JolteonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private JTParentMom_IdleStanding JTParentMom_idlestanding;
		
		private JTParentMom_IdleSitting JTParentMom_idlesitting;

		private void JTParentMom_IdleAnimatorController()
		{
			JTParentMom_idlestanding.JTParentMom_IdleStandingController();
			JTParentMom_idlesitting.JTParentMom_IdleSittingController();	
		}
	}
}