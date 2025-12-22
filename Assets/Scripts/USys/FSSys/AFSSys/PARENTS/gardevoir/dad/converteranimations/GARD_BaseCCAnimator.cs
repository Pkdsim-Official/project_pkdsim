using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations.IdleTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations.SittingTo;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.converteranimations
{
	public class GardevoirConverterAnimatorController : MonoBehaviour 
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