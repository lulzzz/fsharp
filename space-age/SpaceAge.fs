﻿module SpaceAge
open System.Linq.Expressions
open Microsoft.VisualStudio.TestPlatform.ObjectModel
open System.Data.SqlTypes
open System.Security.Cryptography
open System;
// TODO: define the Planet type

type Planet =
    | Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

 let age (planet: Planet) (seconds: int64): float = 
    match planet with
        | Mercury -> System.Math.Round((seconds |> float) / ((31557600 |> float) * 0.2408467), 2)
        | Earth -> System.Math.Round( (seconds |> float) / (31557600 |> float), 2)
    