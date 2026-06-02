using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleSitting;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation
{
	public class LeafeonParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private LEParent_IdleStanding LEParent_idlestanding;
		
		private LEParent_IdleSitting LEParent_idlesitting;

		private void LEParent_IdleAnimatorController()
		{
			LEParent_idlestanding.LEParent_IdleStandingController();
			LEParent_idlesitting.LEParent_IdleSittingController();	
		}
	}
}