[System.Serializable]

public class QuestGoal
{
    //goal type
    public GoalType goalType;
    //required amount
    public int requiredAmount;
    //currentAmount
    public int currentAmount;
    //isReached
    public bool isReached()
    {
        return (currentAmount >= requiredAmount);
    }
    //EnemyKilled
    public void EnemyKilled()
    {
        if(goalType == GoalType.Kill)
        {
            currentAmount++;
        }
    }
    //ObjectCollected
    public void ObjectCollected()
    {
        if(goalType == GoalType.Gather)
        {
            currentAmount++;
        }
    }
	
}

public enum GoalType
{
    Kill,
    Gather
}
