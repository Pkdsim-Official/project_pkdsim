using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation
{
	public class Glaceon_IdleAnimatorController : MonoBehaviour 
	{
		private GL_IdleStanding Glaceon_idlestanding;
		
		private GL_IdleSitting Glaceon_idlesitting;
			

		private void GLParent_IdleAnimatorController()
		{
			Glaceon_idlestanding.GL_IdleStandingController();
			Glaceon_idlesitting.GL_IdleSittingController();	
		}
	}
}