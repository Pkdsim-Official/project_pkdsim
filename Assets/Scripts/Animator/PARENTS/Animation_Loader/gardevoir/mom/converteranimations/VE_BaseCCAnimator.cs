using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations
{
	public class GardevoirParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private GARDParentMom_SittingTo GardevoirParentMomSittingto;
		
		private GARDParentMom_WalkingTo GardevoirParentMomWalkingto;
		
		private GARDParentMom_IdleTo GardevoirParentMomIdleto;

		public void GARDParentMom_ConverterAnimatorController()
		{
			GardevoirParentMomWalkingto.GARDParentMom_WalkingToController();

			GardevoirParentMomIdleto.GARDParentMom_IdleToController();
			
			GardevoirParentMomSittingto.GARDParentMom_SittingToController();	
		}
	}
}