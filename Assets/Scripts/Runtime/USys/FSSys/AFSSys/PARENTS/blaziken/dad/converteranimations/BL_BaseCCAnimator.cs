using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.converteranimations
{
	public class BlazikenConverterAnimatorController : MonoBehaviour 
	{
		private BL_SittingTo BlazikenSittingto;
		
		private BL_WalkingTo BlazikenWalkingto;
		
		private BL_IdleTo BlazikenIdleto;

		public void BLConverterAnimatorController()
		{
			BlazikenWalkingto.BL_WalkingToController();

			BlazikenIdleto.BL_IdleToController();
			
			BlazikenSittingto.BL_SittingToController();	
		}
	}
}