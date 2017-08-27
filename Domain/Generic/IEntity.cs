namespace Domain.Generic
{
    using System;

    public interface IEntity<T> where T : struct
    {
        /// <summary> The Unique Identifier of the Entity </summary>
         T Id {get; set;}
    }
}