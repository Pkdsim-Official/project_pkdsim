using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.idlebaseanimation
{
	public class JolteonParent_AnimatorIdleController : MonoBehaviour 
	{
		private JT_IdleStanding JT_idlestanding;
		
		private JT_IdleSitting JT_idlesitting;

		private void JT_Base_IdleAnimatorController()
		{
			JT_idlestanding.JT_IdleStandingController();
			JT_idlesitting.JT_IdleSittingController();	
		}
	}
}