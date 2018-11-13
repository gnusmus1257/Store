using System;
namespace Entity.models
{
    public class Review : Entity
    {
        ApplicationUser User { get; set; }

        DateTime Date { get; set; }

        string Message { get; set; }

        int Value { get; set; }
    }
}
