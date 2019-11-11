using System;

namespace App
{
    public interface IValidator
    {
        bool IsSequenceValid(string input);
    }
}
