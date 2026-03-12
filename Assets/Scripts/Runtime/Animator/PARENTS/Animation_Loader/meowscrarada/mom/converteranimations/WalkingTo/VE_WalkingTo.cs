using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.WalkingTo
{
		public class MEOWParentMom_WalkingTo : MonoBehaviour 
	{
		private MEOWParentMom_WalkingToSitting MeowscaradaParentMomWalkingToSitting;
		private MEOWParentMom_WalkingToStanding MeowscaradaParentMomWalkingToStanding;
		public void MEOWParentMom_WalkingToController()
		{
			MEOWParentMom_WalkingToStartWalking();
			MEOWParentMom_WalkingToStanding();
		}
		private void MEOWParentMom_WalkingToStartWalking()
		{
			MeowscaradaParentMomWalkingToSitting.MEOWParentMom_WalkingToSittingController();
		}
		private void MEOWParentMom_WalkingToStanding()
		{
			MeowscaradaParentMomWalkingToStanding.MEOWParentMom_WalkingToStandingController();
		}
	}
}