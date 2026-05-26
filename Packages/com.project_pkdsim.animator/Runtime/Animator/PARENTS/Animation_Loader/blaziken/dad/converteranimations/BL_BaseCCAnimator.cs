using project_pkdsim.ANIMATOR.Parents.Blaziken.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Blaziken.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Blaziken.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.converteranimations
{
	public class BlazikenCoverterAnimatorController : MonoBehaviour 
	{
		private BL_SittingTo BlazikenSittingto;
		
		private BL_WalkingTo BlazikenWalkingto;
		
		private BL_IdleTo BlazikenIdleto;

		public void BLCoverterToAnimatorController()
		{
			BlazikenWalkingto.BL_WalkingToController();

			BlazikenIdleto.BL_IdleToController();
			
			BlazikenSittingto.BL_SittingToController();	
		}
	}
}