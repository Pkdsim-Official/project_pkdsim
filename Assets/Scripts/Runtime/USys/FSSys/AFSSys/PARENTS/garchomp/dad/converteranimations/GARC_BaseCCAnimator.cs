using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.converteranimations
{
	public class GarchompConverterAnimatorController : MonoBehaviour 
	{
		private GARC_SittingTo GarchompSittingto;
		
		private GARC_WalkingTo GarchompWalkingto;
		
		private GARC_IdleTo GarchompIdleto;

		public void GARCConverterAnimatorController()
		{
			GarchompWalkingto.GARC_WalkingToController();

			GarchompIdleto.GARC_IdleToController();
			
			GarchompSittingto.GARC_SittingToController();	
		}
	}
}