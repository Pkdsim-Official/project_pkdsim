using  project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations.WalkingTo;
using  project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations.IdleTo;
using  project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations.SittingTo;
using UnityEngine;


namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations
{
	public class LeafeonParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private LE_SittingTo LeafeonParentMom_sittingto;
		
		private LE_WalkingTo LeafeonParentMom_walkingto;
		
		private LE_IdleTo LeafeonParentMom_idleto;

		private void LEParent_IdleAnimatorController()
		{
			LeafeonParentMom_walkingto.LE_WalkingToController();

			LeafeonParentMom_idleto.LE_IdleToController();
			
			LeafeonParentMom_sittingto.LE_SittingToController();	
		}
	}
}