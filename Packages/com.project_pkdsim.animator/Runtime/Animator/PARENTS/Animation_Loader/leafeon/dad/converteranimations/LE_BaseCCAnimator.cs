using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.WalkingTo;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations
{
	public class LeafeonParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private LEParentDad_SittingTo LeafeonParentDad_sittingto;
		
		private LEParentDad_WalkingTo LeafeonParentDad_walkingto;
		
		private LEParentDad_IdleTo LeafeonParentDad_idleto;

		public void LEParentDad_ConverterAnimatorController()
		{
			LeafeonParentDad_walkingto.LEParentDad_WalkingToController();

			LeafeonParentDad_idleto.LEParentDad_IdleToController();
			
			LeafeonParentDad_sittingto.LEParentDad_SittingToController();	
		}
	}
}