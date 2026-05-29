using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.idlebaseanimation
{
	public class ES_Base_IdleAnimator : MonoBehaviour 
	{
		private ES_IdleStanding ES_idlestanding;
		
		private ES_IdleSitting ES_idlesitting;
		

		private void ES_Base_IdleAnimatorController()
		{
			ES_idlestanding.ES_IdleStandingController();
			ES_idlesitting.ES_IdleSittingController();	
		}
	}
}