namespace Assets
{
    public abstract class Entity
    {
        protected static int CurrentId;

        public int Id;
        public Util.EntityType EntityType;
    }
}