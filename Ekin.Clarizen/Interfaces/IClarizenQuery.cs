﻿namespace Ekin.Clarizen.Interfaces
{
    public interface IClarizenQuery
    {
        IClarizenQuery Select(string query);
        IClarizenQuery From(string query);
        IClarizenQuery Where(string query);
        IClarizenQuery GroupBy(string query);
        IClarizenQuery OrderBy(string query);
        IClarizenQuery Limit(int rows);
        IClarizenQuery Offset(int startFrom);

        string ToCZQL();
    }
}
