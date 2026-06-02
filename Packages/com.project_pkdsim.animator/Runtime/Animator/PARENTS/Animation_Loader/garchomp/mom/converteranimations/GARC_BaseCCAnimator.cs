using project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.Mom.converteranimations
{
	public class Garchomp_ConverterAnimatorController : MonoBehaviour 
	{
		private GARC_SittingTo GarchompSittingto;
		
		private GARC_WalkingTo GarchompWalkingto;
		
		private GARC_IdleTo GarchompIdleto;

		public void GARC_ConverterAnimatorController()
		{
			GarchompWalkingto.GARC_WalkingToController();

			GarchompIdleto.GARC_IdleToController();
			
			GarchompSittingto.GARC_SittingToController();	
		}
	}
}