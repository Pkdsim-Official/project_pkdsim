using project_pkdsim.ANIMATOR.Parents.Sylveon.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Sylveon.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.idlebaseanimation
{
	public class Sylveon_IdleAnimatorController : MonoBehaviour 
	{
		private SYL_IdleStanding SYL_idlestanding;
		
		private SYL_IdleSitting SYL_idlesitting;

		private void SYL_Base_IdleAnimatorController()
		{
			SYL_idlestanding.SYL_IdleStandingController();
			SYL_idlesitting.SYL_IdleSittingController();	
		}
	}
}