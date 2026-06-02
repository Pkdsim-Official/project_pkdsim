using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.idlebaseanimation
{
	public class LeafeonParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private LEParentDad_IdleStanding LEParent_idlestanding;
		
		private LEParentDad_IdleSitting LEParent_idlesitting;

		public void LEParentDad_IdleAnimatorController()
		{
			LEParent_idlestanding.LEParentDad_IdleStandingController();
			LEParent_idlesitting.LEParentDad_IdleSittingController();	
		}
	}
}