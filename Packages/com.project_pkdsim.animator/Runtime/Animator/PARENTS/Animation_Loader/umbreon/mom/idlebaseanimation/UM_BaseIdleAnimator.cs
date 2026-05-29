using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.idlebaseanimation
{
	public class Umbreon_AnimatorIdleController : MonoBehaviour 
	{
		private UM_IdleStanding UM_idlestanding;
		
		private UM_IdleSitting UM_idlesitting;
		private void UM_Base_IdleAnimatorController()
		{
			UM_idlestanding.UM_IdleStandingController();
			UM_idlesitting.UM_IdleSittingController();	
		}
	}
}