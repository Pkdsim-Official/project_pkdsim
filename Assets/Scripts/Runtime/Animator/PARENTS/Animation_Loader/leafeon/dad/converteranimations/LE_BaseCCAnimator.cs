using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.WalkingTo;
using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations.SittingTo;
using UnityEngine;


namespace Project_Pkdsim.ANIMATOR.Parents.Leafeon.Dad.converteranimations
{
	public class LeafeonParentDad_ConverterAnimatorController : MonoBehaviour
	{
		private LEParentDad_SittingTo Leafeon_sittingto;

		private LEParentDad_WalkingTo Leafeon_walkingto;

		private LEParentDad_IdleTo Leafeon_idleto;

		public void LEParentDad_ConverterAnimatorController()
		{
			Leafeon_walkingto.LEParentDad_WalkingToController();

			Leafeon_idleto.LEParentDad_IdleToController();

			Leafeon_sittingto.LEParentDad_SittingToController();
		}
	}
}