using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.converteranimations
{
	public class GardevoirParentDad_ConverterAnimatorController : MonoBehaviour 
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