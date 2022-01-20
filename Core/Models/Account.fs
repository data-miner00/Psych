namespace Psych.Core.Models

open System

type AccountType =
| Savings = 0
| Current = 1
| Investment = 2

type Account(createdAt: DateTime, updatedAt: DateTime, id: string, _type: AccountType,
    balance: float, ownerId: string) =
    member this.CreatedAt = createdAt
    member this.UpdatedAt = updatedAt
    member this.Id = id
    member this.Type = _type
    member this.Balance = balance
    member this.OwnerId = ownerId
