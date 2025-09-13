using project_pkdsim.ANIMATOR.Parents.Zoroark.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Zoroark.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Zoroark.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Zoroark.Mom.converteranimations
{
	public class ZoroarkParentMom_CoverterAnimatorController : MonoBehaviour 
	{
		private ZParentMom_SittingTo ZoroarkParentMomSittingto;
		
		private ZParentMom_WalkingTo ZoroarkParentMomWalkingto;
		
		private ZParentMom_IdleTo ZoroarkParentMomIdleto;

		public void ZParentMom_CoverterToAnimatorController()
		{
			ZoroarkParentMomWalkingto.ZParentMom_WalkingToController();

			ZoroarkParentMomIdleto.ZParentMom_IdleToController();
			
			ZoroarkParentMomSittingto.ZParentMom_SittingToController();	
		}
	}
}