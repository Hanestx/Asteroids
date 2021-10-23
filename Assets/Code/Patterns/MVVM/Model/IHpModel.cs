﻿namespace Code.Patterns.MVVM.Model
{
    public interface IHpModel
    {
        float MaxHp { get; }

        float CurrentHp { get; set; }
    }
}