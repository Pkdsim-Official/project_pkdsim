using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations
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