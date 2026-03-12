using Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Frostlass.Mom.converteranimations.SittingTo
{
	public class FRParentMom_SittingTo : MonoBehaviour 
	{
		private FRParentMom_SittingToStartWalking FrostlassParentMomSittingToStartWalking;
		private FRParentMom_SittingToStanding FrostlassParentMomSittingToStanding;
		public void FRParentMom_SittingToController()
		{
			FRParentMom_SittingToStartWalking();
			FRParentMom_SittingToStanding();
		}
		private void FRParentMom_SittingToStartWalking()
		{
			FrostlassParentMomSittingToStartWalking.FRParentMom_SittingToStartWalkingController();
		}
		private void FRParentMom_SittingToStanding()
		{
			FrostlassParentMomSittingToStanding.FRParentMom_SittingToStandingController();
		}

	}
}