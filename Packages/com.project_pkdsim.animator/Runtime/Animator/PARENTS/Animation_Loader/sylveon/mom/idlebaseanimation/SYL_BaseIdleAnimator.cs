using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation
{
	public class Sylveon_IdleAnimatorController : MonoBehaviour 
	{
		private SYL_IdleStanding SYL_idlestanding;
		
		private SYL_IdleSitting SYL_idlesitting;

		private void SYLParent_IdleAnimatorController()
		{
			SYL_idlestanding.SYL_IdleStandingController();
			SYL_idlesitting.SYL_IdleSittingController();	
		}
	}
}