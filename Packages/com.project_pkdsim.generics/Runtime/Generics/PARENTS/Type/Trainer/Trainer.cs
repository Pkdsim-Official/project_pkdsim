namespace project_pkdsim.Generics.Parents.Type.Trainer
{
    public enum ParentsTrainerType
    {
        GymLeader,
        EliteFour,
        Champion,
        Rival,
        Professor,
        AceTrainer,
        BattleGirl,
        BattleMan,
        BlackBelt,
        BugCatcher,
        Camper,
        Collector,
        CoolTrainer,
        CoolTrainerFemale,
        Breeder,
        Ranger,
        Researcher,
        SchoolTeacher,
        Swimmer,
        Tamer,
        Trainer,
        Veteran,
        Worker
    }

    public interface IParentTrainer
    {
        ParentsTrainerType ParentsTrainer { get; }
    }
}