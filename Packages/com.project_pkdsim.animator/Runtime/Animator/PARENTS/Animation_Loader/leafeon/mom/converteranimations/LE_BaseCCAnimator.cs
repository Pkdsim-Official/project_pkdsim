using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.WalkingTo;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.IdleTo;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.SittingTo;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations
{
	public class LeafeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private LEParent_SittingTo LeafeonParentMom_sittingto;
		
		private LEParent_WalkingTo LeafeonParentMom_walkingto;
		
		private LEParent_IdleTo LeafeonParentMom_idleto;

		private void LEParent_IdleAnimatorController()
		{
			LeafeonParentMom_walkingto.LEParent_WalkingToController();

			LeafeonParentMom_idleto.LEParent_IdleToController();
			
			LeafeonParentMom_sittingto.LEParent_SittingToController();	
		}
	}
}