using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel Void Islemleri Icin Baslangic
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
