using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.converteranimations.IdleTo;
using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.converteranimations.SittingTo;
using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Blaziken.converteranimations
{
	public class BlazikenCoverterAnimatorController : MonoBehaviour 
	{
		private BLSittingTo Blazikensittingto;
		
		private BLWalkingTo Blazikenwalkingto;
		
		private BLIdleTo Blazikenidleto;

		public void BLCoverterToAnimatorController()
		{
			Blazikenwalkingto.BLWalkingToController();

			Blazikenidleto.BLIdleToController();
			
			Blazikensittingto.BLSittingToController();	
		}
	}
}