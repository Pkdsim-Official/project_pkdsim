using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.idlebaseanimation
{
	public class FlareonParentDad_AnimatorIdleController : MonoBehaviour 
	{
		private FL_IdleStanding FL_idlestanding;
		
		private FL_IdleSitting FL_idlesitting;
		
		private void FL_Base_IdleAnimatorController()
		{
			FL_idlestanding.FL_IdleStandingController();
			FL_idlesitting.FL_IdleSittingController();	
		}
	}
}