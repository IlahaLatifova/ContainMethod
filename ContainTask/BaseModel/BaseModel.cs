
    internal abstract class BaseModel
    {
        static int id = 0;
        public int Id { get { return id; } }
        public BaseModel()
        {
            id++;
        }
    }

