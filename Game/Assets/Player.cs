namespace Assets
{
    public class Player : Entity
    {
        protected static int CurrentPlayerId;

        public int PlayerId;
        //public Character Character;
        //player has a character but its not implemented yet, its abstract and needs subclasses first to construct it
        //When specific characters are made then it will be implemented
        public Player()
        {
            Id = CurrentId++;
            PlayerId = CurrentPlayerId++;
            EntityType = Util.EntityType.Player;
        }
    }
}
