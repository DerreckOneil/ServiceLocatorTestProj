﻿
public interface IServiceLocator
{
    T GetService<T>() where T : class;

}