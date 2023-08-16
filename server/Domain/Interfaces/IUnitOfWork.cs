﻿namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
    }
}
