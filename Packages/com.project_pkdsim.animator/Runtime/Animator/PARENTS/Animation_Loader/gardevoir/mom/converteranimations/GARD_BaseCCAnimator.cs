using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations
{
	public class GardevoirParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private GARD_SittingTo GardevoirSittingto;
		
		private GARD_WalkingTo GardevoirWalkingto;
		
		private GARD_IdleTo GardevoirIdleto;

		public void GARD_ConverterAnimatorController()
		{
			GardevoirWalkingto.GARD_WalkingToController();

			GardevoirIdleto.GARD_IdleToController();
			
			GardevoirSittingto.GARD_SittingToController();	
		}
	}
}