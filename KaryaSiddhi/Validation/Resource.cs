namespace KaryaSiddhi.Validation
{
    public class Resource<T>
    {

        public T Data { get; set; }
        public string Message { get; set; }
        public Resource(T data, string message)
        {
            Data = data;
            Message = message;
        }
        
    }

    public class Success<T>: Resource<T>
    {
        public Success(T data): base(data, "")
        {

        }
    }

    //public class Fauilure<T> : Resource<T>
    //{
    //    public Fauilure() : base()
    //    {

    //    }
    //} 

    public class BadRequest<T>: Resource<T>
    {
        public BadRequest(T data,string message): base(data, message)
        {

        }
    }

}
