using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.converteranimations
{
	public class Garchomp_ConverterToAnimatorController : MonoBehaviour 
	{
		private GARC_SittingTo GarchompSittingto;
		
		private GARC_WalkingTo GarchompWalkingto;
		
		private GARC_IdleTo GarchompIdleto;

		public void GARC_ConverterToAnimatorController()
		{
			GarchompWalkingto.GARC_WalkingToController();

			GarchompIdleto.GARC_IdleToController();
			
			GarchompSittingto.GARC_SittingToController();	
		}
	}
}