using Project_Pkdsim.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation
{
	public class GlaceonParentDad_AnimatorIdleController : MonoBehaviour 
	{
		private GLParentDad_IdleStanding GlaceonParentDadidlestanding;
		
		private GLParentDad_IdleSitting GlaceonParentDadidlesitting;

		public void GLParentDad_IdleAnimatorController()
		{
			GlaceonParentDadidlestanding.GLParentDad_IdleStandingController();
			GlaceonParentDadidlesitting.GLParentDad_IdleSittingController();	
		}
	}
}